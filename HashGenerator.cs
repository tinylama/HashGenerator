using CryptSharp;
using CryptSharp.Utility;
using Konscious.Security.Cryptography;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace HashGenerator
{
    public partial class HashGeneratorForm : Form
    {
        public HashGeneratorForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadHashTypes();
        }      

        private void LoadHashTypes()
        {
            hashTypesCombo.Items.Add("MD5");
            hashTypesCombo.Items.Add("SHA1");
            hashTypesCombo.Items.Add("SHA256");
            hashTypesCombo.Items.Add("SHA512");
            hashTypesCombo.Items.Add("PHPASS");
            hashTypesCombo.Items.Add("MYSQL5");
            hashTypesCombo.Items.Add("NTLM");
            hashTypesCombo.Items.Add("ARGON2");
            hashTypesCombo.Items.Add("SCRYPT");
            hashTypesCombo.Items.Add("BCRYPT");
            hashTypesCombo.SelectedItem = "BCRYPT";
        }

        private static string GenerateSCRYPT(string password, string salt)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(password);
            byte[] saltBytes = Encoding.UTF8.GetBytes(salt);
            int cost = 262144; //16384;
            int blockSize = 8;
            int parallel = 1; //Environment.ProcessorCount
            var maxThreads = (int?)null;
            var derivedKeyLength = 128;
            return Convert.ToBase64String(SCrypt.ComputeDerivedKey(keyBytes, saltBytes, cost, blockSize, parallel, maxThreads, derivedKeyLength));
            
        }

        private static string GeneratePHPASS(string password)
        {
            return PhpassCrypter.Phpass.Crypt(password);
        }

        private static string GenerateMD5(string password, string salt)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] keyBytes = Encoding.ASCII.GetBytes(salt+password);
                byte[] hashBytes = md5.ComputeHash(keyBytes);
                return GetHex(hashBytes);
            }
        }

        private static string GenerateSHA1(string password, string salt)
        {
            using (SHA1 sha1 = SHA1.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(salt + password);
                byte[] hashBytes = sha1.ComputeHash(inputBytes);
                return GetHex(hashBytes);
            }
        }

        private static string GenerateSHA256(string password, string salt)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(salt + password);
                byte[] hashBytes = sha256.ComputeHash(inputBytes);
                return GetHex(hashBytes);
            }
        }
        private static string GenerateSHA512(string password, string salt)
        {
            using (SHA512 sha512 = SHA512.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(salt+password);
                byte[] hashBytes = sha512.ComputeHash(inputBytes);
                return GetHex(hashBytes);
            }
        }

        string GenerateMYSQL5(string password)
        {
            byte[] passBytes = Encoding.UTF8.GetBytes(password);
            byte[] hash;
            using (var sha1 = SHA1.Create())
            {
                hash = sha1.ComputeHash(passBytes);
                hash = sha1.ComputeHash(hash);
            }
            return "*"+GetHex(hash);
        }

        private static string GetHex(byte[] hashBytes)
        {
            return BitConverter.ToString(hashBytes).Replace("-", "");
        }
               
        private static string GetUniqueSalt(int size)
        {
            char[] chars =
            "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
            byte[] data = new byte[4 * size];
            using (var crypto = RandomNumberGenerator.Create())
            {
                crypto.GetBytes(data);
            }
            StringBuilder result = new StringBuilder(size);
            for (int i = 0; i < size; i++)
            {
                var rnd = BitConverter.ToUInt32(data, i * 4);
                var idx = rnd % chars.Length;

                result.Append(chars[idx]);
            }

            return result.ToString();
        }

        private static byte[] CreateSecureSalt()
        {
            var buffer = new byte[16];
            var rng = new RNGCryptoServiceProvider();
            rng.GetBytes(buffer);
            return buffer;
        }

        private static string GenerateARGON2(string password, string salt)
        {
            string algorithm = "argon2id";
            string version = "19";
            var argon2 = new Argon2id(Encoding.UTF8.GetBytes(password))
            {
                Salt = Encoding.ASCII.GetBytes(salt),
                DegreeOfParallelism = Environment.ProcessorCount,
                Iterations = 4,
                MemorySize = 1024 * 1024 // 1 GB                
            };
            
            return $"${algorithm}$v={version}$m={argon2.MemorySize},t={argon2.Iterations},p={argon2.DegreeOfParallelism}${Convert.ToBase64String(argon2.Salt).Replace("=", "")}${Convert.ToBase64String(argon2.GetBytes(16)).Replace("=","")}";
            //return GetHex(argon2.GetBytes(16));
        }

        private static string GenerateBCRYPT(string password)
        {
            return BCrypt.Net.BCrypt.EnhancedHashPassword(password);
        }

        private void RegenerateHash()
        {
            if (passwordTextbox.Text != "")
            {
                DisplayHash();
                copyButton.Visible = true;
                generateButton.Text = "&Clear";
            }
            
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            if (passwordTextbox.Text != "")
            {
                if (generateButton.Text == "&Generate")
                {
                    DisplayHash();
                    copyButton.Visible = true;
                    generateButton.Text = "&Clear";
                }
                else
                {
                    generateButton.Text = "&Generate";
                    copyButton.Visible = false;
                    hashTextbox.Clear();
                    passwordTextbox.Clear();
                    saltTextbox.Clear();
                    hashLabel.Visible = false;
                    hashTextbox.Visible = false;
                }
            }
            else
            {
                hashLabel.Visible = true;
                hashTextbox.Visible = true;
                hashLabel.Text = "Information";
                hashTextbox.Text = "Password is required.";
            }
        }

            private void DisplayHash()
        {
            string salt = saltTextbox.Text;
            string key = passwordTextbox.Text;
            hashLabel.Visible = true;
            hashTextbox.Visible = true;
            hashLabel.Text = "Information";
            hashTextbox.Text = "Calculating...";
            string hash;
            switch (hashTypesCombo.Text)
            {

                case "MD5":
                    hash = GenerateMD5(key, salt); break;
                case "SHA1":
                    hash = GenerateSHA1(key, salt); break;
                case "SHA256":
                    hash = GenerateSHA256(key, salt); break;
                case "SHA512":
                    hash = GenerateSHA512(key, salt); break;
                case "PHPASS":
                    hash = GeneratePHPASS(key);
                    break;
                case "MYSQL5":
                    hash = GenerateMYSQL5(key); break;
                case "NTLM":
                    hash = NTLM.GenerateNTLM(key); break;
                case "BCRYPT":
                    hash = GenerateBCRYPT(key); break;
                case "ARGON2":
                    if (salt == "")
                    {
                        salt = GetUniqueSalt(16);
                        saltTextbox.Text = salt;
                    }
                    hashLabel.Text = "Information";
                    hashTextbox.Text = "Calculating...";
                    hash = GenerateARGON2(key, salt); 
                    break;
                case "SCRYPT":
                    if (salt == "")
                    {
                        salt = GetUniqueSalt(16);
                        saltTextbox.Text = salt;
                    }
                    hashLabel.Text = "Information";
                    hashTextbox.Text = "Calculating...";
                    hash = GenerateSCRYPT(key, salt);
                    break;
                default:
                    hashLabel.Text = "Information";
                    hash = "Hash type is required.";
                    break;
            }
            hashLabel.Text = "Hash";
            hashTextbox.Text = hash;
            
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(hashTextbox.Text);
        }

        private void HasSalt()
        {
            bool salt;
            switch (hashTypesCombo.Text)
            {
                case "MD5":
                    salt = true; break;
                case "SHA1":
                    salt = true; break;
                case "SHA256":
                    salt = true; break;
                case "SHA512":
                    salt = true; break;
                case "PHPASS":
                    salt = false; break;
                case "MYSQL5":
                    salt = false; break;
                case "NTLM":
                    salt = false; break;
                case "BCRYPT":
                    salt = false; break;
                case "ARGON2":
                    salt = true; break;
                case "SCRYPT":
                    salt = true; break;
                default: 
                    salt = false; break;
            }
            saltLabel.Enabled = salt;
            generateSaltButton.Visible = salt;
            if (salt) { saltTextbox.BorderStyle = BorderStyle.FixedSingle; saltTextbox.Enabled = true; }
            else{
                saltTextbox.BorderStyle = BorderStyle.None;
                saltTextbox.Text = "";
                saltTextbox.Enabled = false;
            }
        }

        private void HashTypeChanged(object sender, EventArgs e)
        {
            HasSalt();            
            RegenerateHash();
        }

        private void SaltChanged(object sender, EventArgs e)
        {
            generateButton.Text = "&Generate";
            copyButton.Visible = false;
            hashTextbox.Clear();
        }

        private void GenerateSalt(object sender, EventArgs e)
        {
            saltTextbox.Text = GetUniqueSalt(16);
        }

        private void PasswordChanged(object sender, EventArgs e)
        {
            generateButton.Text = "&Generate";
            copyButton.Visible = false;
            hashTextbox.Clear();
        }
    }
}

namespace HashGenerator
{
    partial class HashGeneratorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HashGeneratorForm));
            this.generateButton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.hashTextbox = new System.Windows.Forms.TextBox();
            this.hashLabel = new System.Windows.Forms.Label();
            this.saltTextbox = new System.Windows.Forms.TextBox();
            this.saltLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hashTypePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.hashTypeLabel = new System.Windows.Forms.Label();
            this.hashTypesCombo = new System.Windows.Forms.ComboBox();
            this.mainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.generateSaltButton = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.hashTypePanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generateSaltButton)).BeginInit();
            this.SuspendLayout();
            // 
            // generateButton
            // 
            this.generateButton.ForeColor = System.Drawing.Color.Black;
            this.generateButton.Location = new System.Drawing.Point(84, 117);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 23);
            this.generateButton.TabIndex = 6;
            this.generateButton.Text = "&Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // copyButton
            // 
            this.copyButton.ForeColor = System.Drawing.Color.Black;
            this.copyButton.Location = new System.Drawing.Point(3, 117);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(75, 23);
            this.copyButton.TabIndex = 5;
            this.copyButton.Text = "&Copy";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Visible = false;
            this.copyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // hashTextbox
            // 
            this.hashTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hashTextbox.BackColor = System.Drawing.Color.Black;
            this.hashTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hashTextbox.ForeColor = System.Drawing.Color.White;
            this.hashTextbox.Location = new System.Drawing.Point(3, 91);
            this.hashTextbox.Name = "hashTextbox";
            this.hashTextbox.Size = new System.Drawing.Size(377, 20);
            this.hashTextbox.TabIndex = 4;
            this.hashTextbox.Visible = false;
            // 
            // hashLabel
            // 
            this.hashLabel.AutoSize = true;
            this.hashLabel.Location = new System.Drawing.Point(3, 75);
            this.hashLabel.Name = "hashLabel";
            this.hashLabel.Size = new System.Drawing.Size(32, 13);
            this.hashLabel.TabIndex = 3;
            this.hashLabel.Text = "Hash";
            this.hashLabel.Visible = false;
            // 
            // saltTextbox
            // 
            this.saltTextbox.BackColor = System.Drawing.Color.Black;
            this.saltTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.saltTextbox.Enabled = false;
            this.saltTextbox.ForeColor = System.Drawing.Color.White;
            this.saltTextbox.Location = new System.Drawing.Point(34, 52);
            this.saltTextbox.Multiline = true;
            this.saltTextbox.Name = "saltTextbox";
            this.saltTextbox.Size = new System.Drawing.Size(97, 20);
            this.saltTextbox.TabIndex = 2;
            this.saltTextbox.TextChanged += new System.EventHandler(this.SaltChanged);
            // 
            // saltLabel
            // 
            this.saltLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.saltLabel.AutoSize = true;
            this.saltLabel.Enabled = false;
            this.saltLabel.Location = new System.Drawing.Point(3, 55);
            this.saltLabel.Name = "saltLabel";
            this.saltLabel.Size = new System.Drawing.Size(25, 13);
            this.saltLabel.TabIndex = 1;
            this.saltLabel.Text = "Salt";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.hashTypePanel);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 43);
            this.panel1.TabIndex = 0;
            // 
            // hashTypePanel
            // 
            this.hashTypePanel.Controls.Add(this.hashTypeLabel);
            this.hashTypePanel.Controls.Add(this.hashTypesCombo);
            this.hashTypePanel.Location = new System.Drawing.Point(0, 0);
            this.hashTypePanel.Name = "hashTypePanel";
            this.hashTypePanel.Size = new System.Drawing.Size(381, 42);
            this.hashTypePanel.TabIndex = 0;
            // 
            // hashTypeLabel
            // 
            this.hashTypeLabel.AutoSize = true;
            this.hashTypeLabel.Location = new System.Drawing.Point(3, 0);
            this.hashTypeLabel.Name = "hashTypeLabel";
            this.hashTypeLabel.Size = new System.Drawing.Size(59, 13);
            this.hashTypeLabel.TabIndex = 0;
            this.hashTypeLabel.Text = "Hash Type";
            // 
            // hashTypesCombo
            // 
            this.hashTypesCombo.BackColor = System.Drawing.Color.Black;
            this.hashTypesCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hashTypesCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hashTypesCombo.ForeColor = System.Drawing.Color.White;
            this.hashTypesCombo.FormattingEnabled = true;
            this.hashTypesCombo.Location = new System.Drawing.Point(3, 16);
            this.hashTypesCombo.Name = "hashTypesCombo";
            this.hashTypesCombo.Size = new System.Drawing.Size(373, 21);
            this.hashTypesCombo.TabIndex = 1;
            this.hashTypesCombo.SelectedIndexChanged += new System.EventHandler(this.HashTypeChanged);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Black;
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.saltLabel);
            this.mainPanel.Controls.Add(this.saltTextbox);
            this.mainPanel.Controls.Add(this.generateSaltButton);
            this.mainPanel.Controls.Add(this.passwordLabel);
            this.mainPanel.Controls.Add(this.passwordTextbox);
            this.mainPanel.Controls.Add(this.hashLabel);
            this.mainPanel.Controls.Add(this.hashTextbox);
            this.mainPanel.Controls.Add(this.copyButton);
            this.mainPanel.Controls.Add(this.generateButton);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.ForeColor = System.Drawing.Color.White;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(384, 146);
            this.mainPanel.TabIndex = 0;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextbox.BackColor = System.Drawing.Color.Black;
            this.passwordTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextbox.ForeColor = System.Drawing.Color.White;
            this.passwordTextbox.Location = new System.Drawing.Point(218, 52);
            this.passwordTextbox.Multiline = true;
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(161, 20);
            this.passwordTextbox.TabIndex = 7;
            this.passwordTextbox.TextChanged += new System.EventHandler(this.PasswordChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(159, 55);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 8;
            this.passwordLabel.Text = "Password";
            // 
            // generateSaltButton
            // 
            this.generateSaltButton.Image = ((System.Drawing.Image)(resources.GetObject("generateSaltButton.Image")));
            this.generateSaltButton.Location = new System.Drawing.Point(137, 52);
            this.generateSaltButton.Name = "generateSaltButton";
            this.generateSaltButton.Size = new System.Drawing.Size(16, 16);
            this.generateSaltButton.TabIndex = 9;
            this.generateSaltButton.TabStop = false;
            this.generateSaltButton.Click += new System.EventHandler(this.GenerateSalt);
            // 
            // HashGeneratorForm
            // 
            this.AcceptButton = this.generateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 146);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(400, 185);
            this.MinimumSize = new System.Drawing.Size(400, 185);
            this.Name = "HashGeneratorForm";
            this.ShowIcon = false;
            this.Text = "Hash Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.hashTypePanel.ResumeLayout(false);
            this.hashTypePanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generateSaltButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.TextBox hashTextbox;
        private System.Windows.Forms.Label hashLabel;
        private System.Windows.Forms.TextBox saltTextbox;
        private System.Windows.Forms.Label saltLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel hashTypePanel;
        private System.Windows.Forms.Label hashTypeLabel;
        private System.Windows.Forms.ComboBox hashTypesCombo;
        private System.Windows.Forms.FlowLayoutPanel mainPanel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.PictureBox generateSaltButton;
    }
}


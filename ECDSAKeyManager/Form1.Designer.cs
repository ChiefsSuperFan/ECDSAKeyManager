namespace ECDSAKeyManager
{
    partial class frmAdmin
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
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.txtPrivateKey = new System.Windows.Forms.TextBox();
            this.txtPublicKey = new System.Windows.Forms.TextBox();
            this.txtUserAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtFileURL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHash = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMAC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnVerify = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSign = new System.Windows.Forms.Button();
            this.lblVerify = new System.Windows.Forms.Label();
            this.txtPrKeyLen = new System.Windows.Forms.TextBox();
            this.txtPubKeyLen = new System.Windows.Forms.TextBox();
            this.txtAddrLen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(59, 308);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(199, 66);
            this.btnCreateUser.TabIndex = 0;
            this.btnCreateUser.Text = "Create User";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // txtPrivateKey
            // 
            this.txtPrivateKey.Location = new System.Drawing.Point(251, 71);
            this.txtPrivateKey.Name = "txtPrivateKey";
            this.txtPrivateKey.Size = new System.Drawing.Size(1276, 38);
            this.txtPrivateKey.TabIndex = 1;
            // 
            // txtPublicKey
            // 
            this.txtPublicKey.Location = new System.Drawing.Point(251, 139);
            this.txtPublicKey.Name = "txtPublicKey";
            this.txtPublicKey.Size = new System.Drawing.Size(1276, 38);
            this.txtPublicKey.TabIndex = 2;
            // 
            // txtUserAddress
            // 
            this.txtUserAddress.Location = new System.Drawing.Point(264, 208);
            this.txtUserAddress.Name = "txtUserAddress";
            this.txtUserAddress.Size = new System.Drawing.Size(1263, 38);
            this.txtUserAddress.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Private Key:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Public Key:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Public Address:";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(1288, 503);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(115, 43);
            this.btnSelect.TabIndex = 7;
            this.btnSelect.Text = "...";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtFileURL
            // 
            this.txtFileURL.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtFileURL.Enabled = false;
            this.txtFileURL.ForeColor = System.Drawing.Color.Black;
            this.txtFileURL.Location = new System.Drawing.Point(241, 503);
            this.txtFileURL.Name = "txtFileURL";
            this.txtFileURL.Size = new System.Drawing.Size(1031, 38);
            this.txtFileURL.TabIndex = 8;
            this.txtFileURL.TextChanged += new System.EventHandler(this.txtFileURL_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 503);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "File URL:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtHash
            // 
            this.txtHash.Location = new System.Drawing.Point(241, 679);
            this.txtHash.Name = "txtHash";
            this.txtHash.Size = new System.Drawing.Size(1122, 38);
            this.txtHash.TabIndex = 10;
            this.txtHash.TextChanged += new System.EventHandler(this.txtHash_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 679);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "File Hash:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtMAC
            // 
            this.txtMAC.Location = new System.Drawing.Point(241, 778);
            this.txtMAC.Name = "txtMAC";
            this.txtMAC.Size = new System.Drawing.Size(1122, 38);
            this.txtMAC.TabIndex = 12;
            this.txtMAC.TextChanged += new System.EventHandler(this.txtMAC_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 778);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 32);
            this.label6.TabIndex = 13;
            this.label6.Text = "MAC:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(650, 308);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(192, 66);
            this.btnVerify.TabIndex = 14;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(169, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(869, 32);
            this.label7.TabIndex = 15;
            this.label7.Text = "Step 1:  Enter an existing account\'s information or create a new one.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(198, 438);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 32);
            this.label8.TabIndex = 16;
            this.label8.Text = "Select A File:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(251, 575);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(459, 32);
            this.label9.TabIndex = 17;
            this.label9.Text = "Generate MAC or digitial signature:";
            // 
            // btnSign
            // 
            this.btnSign.Location = new System.Drawing.Point(347, 867);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(225, 60);
            this.btnSign.TabIndex = 18;
            this.btnSign.Text = "Sign";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // lblVerify
            // 
            this.lblVerify.AutoSize = true;
            this.lblVerify.Location = new System.Drawing.Point(933, 320);
            this.lblVerify.Name = "lblVerify";
            this.lblVerify.Size = new System.Drawing.Size(109, 32);
            this.lblVerify.TabIndex = 19;
            this.lblVerify.Text = "label10";
            // 
            // txtPrKeyLen
            // 
            this.txtPrKeyLen.Location = new System.Drawing.Point(1571, 71);
            this.txtPrKeyLen.Name = "txtPrKeyLen";
            this.txtPrKeyLen.Size = new System.Drawing.Size(100, 38);
            this.txtPrKeyLen.TabIndex = 20;
            // 
            // txtPubKeyLen
            // 
            this.txtPubKeyLen.Location = new System.Drawing.Point(1571, 138);
            this.txtPubKeyLen.Name = "txtPubKeyLen";
            this.txtPubKeyLen.Size = new System.Drawing.Size(100, 38);
            this.txtPubKeyLen.TabIndex = 21;
            // 
            // txtAddrLen
            // 
            this.txtAddrLen.Location = new System.Drawing.Point(1571, 214);
            this.txtAddrLen.Name = "txtAddrLen";
            this.txtAddrLen.Size = new System.Drawing.Size(100, 38);
            this.txtAddrLen.TabIndex = 22;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1797, 1016);
            this.Controls.Add(this.txtAddrLen);
            this.Controls.Add(this.txtPubKeyLen);
            this.Controls.Add(this.txtPrKeyLen);
            this.Controls.Add(this.lblVerify);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMAC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHash);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFileURL);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUserAddress);
            this.Controls.Add(this.txtPublicKey);
            this.Controls.Add(this.txtPrivateKey);
            this.Controls.Add(this.btnCreateUser);
            this.Name = "frmAdmin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.TextBox txtPrivateKey;
        private System.Windows.Forms.TextBox txtPublicKey;
        private System.Windows.Forms.TextBox txtUserAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtFileURL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHash;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMAC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Label lblVerify;
        private System.Windows.Forms.TextBox txtPrKeyLen;
        private System.Windows.Forms.TextBox txtPubKeyLen;
        private System.Windows.Forms.TextBox txtAddrLen;
    }
}


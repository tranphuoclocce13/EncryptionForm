namespace EncryptionForm
{
    partial class EDForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EDForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rbDES = new System.Windows.Forms.RadioButton();
            this.rbRSA = new System.Windows.Forms.RadioButton();
            this.rbAES = new System.Windows.Forms.RadioButton();
            this.btDecrypt = new System.Windows.Forms.Button();
            this.btEncrypt = new System.Windows.Forms.Button();
            this.btChooseKey = new System.Windows.Forms.Button();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btOutputDirectory = new System.Windows.Forms.Button();
            this.btSourceFile = new System.Windows.Forms.Button();
            this.tbOutputDirectory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSourceFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btStart = new System.Windows.Forms.Button();
            this.rbVerify = new System.Windows.Forms.RadioButton();
            this.rdGetMD5 = new System.Windows.Forms.RadioButton();
            this.tbCompare = new System.Windows.Forms.TextBox();
            this.tbMD5Checksum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btCopyMD5 = new System.Windows.Forms.Button();
            this.btGetMD5 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbGetMD5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btPlaceStoreKey = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tbPlaceStoreKey = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btGenerate = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPublicE = new System.Windows.Forms.TextBox();
            this.tbPrimeQ = new System.Windows.Forms.TextBox();
            this.tbPrimeP = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-1, -2);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(445, 360);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.rbDES);
            this.tabPage1.Controls.Add(this.rbRSA);
            this.tabPage1.Controls.Add(this.rbAES);
            this.tabPage1.Controls.Add(this.btDecrypt);
            this.tabPage1.Controls.Add(this.btEncrypt);
            this.tabPage1.Controls.Add(this.btChooseKey);
            this.tabPage1.Controls.Add(this.tbKey);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btOutputDirectory);
            this.tabPage1.Controls.Add(this.btSourceFile);
            this.tabPage1.Controls.Add(this.tbOutputDirectory);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tbSourceFile);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(437, 334);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Encrypt/Decrypt";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rbDES
            // 
            this.rbDES.AutoSize = true;
            this.rbDES.Location = new System.Drawing.Point(317, 30);
            this.rbDES.Name = "rbDES";
            this.rbDES.Size = new System.Drawing.Size(47, 17);
            this.rbDES.TabIndex = 14;
            this.rbDES.TabStop = true;
            this.rbDES.Text = "DES";
            this.rbDES.UseVisualStyleBackColor = true;
            this.rbDES.CheckedChanged += new System.EventHandler(this.rbDES_CheckedChanged);
            // 
            // rbRSA
            // 
            this.rbRSA.AutoSize = true;
            this.rbRSA.Location = new System.Drawing.Point(183, 30);
            this.rbRSA.Name = "rbRSA";
            this.rbRSA.Size = new System.Drawing.Size(47, 17);
            this.rbRSA.TabIndex = 13;
            this.rbRSA.TabStop = true;
            this.rbRSA.Text = "RSA";
            this.rbRSA.UseVisualStyleBackColor = true;
            this.rbRSA.CheckedChanged += new System.EventHandler(this.rbRSA_CheckedChanged);
            // 
            // rbAES
            // 
            this.rbAES.AutoSize = true;
            this.rbAES.Location = new System.Drawing.Point(56, 30);
            this.rbAES.Name = "rbAES";
            this.rbAES.Size = new System.Drawing.Size(46, 17);
            this.rbAES.TabIndex = 12;
            this.rbAES.TabStop = true;
            this.rbAES.Text = "AES";
            this.rbAES.UseVisualStyleBackColor = true;
            this.rbAES.CheckedChanged += new System.EventHandler(this.rbAES_CheckedChanged);
            // 
            // btDecrypt
            // 
            this.btDecrypt.Enabled = false;
            this.btDecrypt.Location = new System.Drawing.Point(249, 269);
            this.btDecrypt.Name = "btDecrypt";
            this.btDecrypt.Size = new System.Drawing.Size(92, 54);
            this.btDecrypt.TabIndex = 11;
            this.btDecrypt.Text = "Decypt";
            this.btDecrypt.UseVisualStyleBackColor = true;
            this.btDecrypt.Click += new System.EventHandler(this.btDecrypt_Click);
            // 
            // btEncrypt
            // 
            this.btEncrypt.Enabled = false;
            this.btEncrypt.Location = new System.Drawing.Point(84, 269);
            this.btEncrypt.Name = "btEncrypt";
            this.btEncrypt.Size = new System.Drawing.Size(92, 54);
            this.btEncrypt.TabIndex = 10;
            this.btEncrypt.Text = "Encrypt";
            this.btEncrypt.UseVisualStyleBackColor = true;
            this.btEncrypt.Click += new System.EventHandler(this.btEncrypt_Click);
            // 
            // btChooseKey
            // 
            this.btChooseKey.Enabled = false;
            this.btChooseKey.Location = new System.Drawing.Point(347, 193);
            this.btChooseKey.Name = "btChooseKey";
            this.btChooseKey.Size = new System.Drawing.Size(75, 46);
            this.btChooseKey.TabIndex = 9;
            this.btChooseKey.Text = "Choose Key File";
            this.btChooseKey.UseVisualStyleBackColor = true;
            this.btChooseKey.Click += new System.EventHandler(this.btChooseKey_Click);
            // 
            // tbKey
            // 
            this.tbKey.Enabled = false;
            this.tbKey.Location = new System.Drawing.Point(12, 193);
            this.tbKey.Multiline = true;
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(329, 46);
            this.tbKey.TabIndex = 8;
            this.tbKey.TextChanged += new System.EventHandler(this.tbKey_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Key";
            // 
            // btOutputDirectory
            // 
            this.btOutputDirectory.Location = new System.Drawing.Point(347, 131);
            this.btOutputDirectory.Name = "btOutputDirectory";
            this.btOutputDirectory.Size = new System.Drawing.Size(75, 22);
            this.btOutputDirectory.TabIndex = 6;
            this.btOutputDirectory.Text = "Browse...";
            this.btOutputDirectory.UseVisualStyleBackColor = true;
            this.btOutputDirectory.Click += new System.EventHandler(this.btOutputDirectory_Click);
            // 
            // btSourceFile
            // 
            this.btSourceFile.Location = new System.Drawing.Point(347, 77);
            this.btSourceFile.Name = "btSourceFile";
            this.btSourceFile.Size = new System.Drawing.Size(75, 22);
            this.btSourceFile.TabIndex = 6;
            this.btSourceFile.Text = "Browse..";
            this.btSourceFile.UseVisualStyleBackColor = true;
            this.btSourceFile.Click += new System.EventHandler(this.btSourceFile_Click);
            // 
            // tbOutputDirectory
            // 
            this.tbOutputDirectory.Location = new System.Drawing.Point(12, 132);
            this.tbOutputDirectory.Name = "tbOutputDirectory";
            this.tbOutputDirectory.Size = new System.Drawing.Size(329, 20);
            this.tbOutputDirectory.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Output Directory";
            // 
            // tbSourceFile
            // 
            this.tbSourceFile.Location = new System.Drawing.Point(12, 79);
            this.tbSourceFile.Name = "tbSourceFile";
            this.tbSourceFile.Size = new System.Drawing.Size(329, 20);
            this.tbSourceFile.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Source File";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Algorithm";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btStart);
            this.tabPage2.Controls.Add(this.rbVerify);
            this.tabPage2.Controls.Add(this.rdGetMD5);
            this.tabPage2.Controls.Add(this.tbCompare);
            this.tabPage2.Controls.Add(this.tbMD5Checksum);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.btCopyMD5);
            this.tabPage2.Controls.Add(this.btGetMD5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.tbGetMD5);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(437, 334);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MD5 Checksum";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(69, 263);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(305, 52);
            this.btStart.TabIndex = 5;
            this.btStart.Text = "START";
            this.btStart.UseVisualStyleBackColor = true;
            // 
            // rbVerify
            // 
            this.rbVerify.AutoSize = true;
            this.rbVerify.Location = new System.Drawing.Point(217, 16);
            this.rbVerify.Name = "rbVerify";
            this.rbVerify.Size = new System.Drawing.Size(77, 17);
            this.rbVerify.TabIndex = 4;
            this.rbVerify.TabStop = true;
            this.rbVerify.Text = "Verify MD5";
            this.rbVerify.UseVisualStyleBackColor = true;
            // 
            // rdGetMD5
            // 
            this.rdGetMD5.AutoSize = true;
            this.rdGetMD5.Location = new System.Drawing.Point(69, 16);
            this.rdGetMD5.Name = "rdGetMD5";
            this.rdGetMD5.Size = new System.Drawing.Size(71, 17);
            this.rdGetMD5.TabIndex = 3;
            this.rdGetMD5.TabStop = true;
            this.rdGetMD5.Text = "Get MD5 ";
            this.rdGetMD5.UseVisualStyleBackColor = true;
            // 
            // tbCompare
            // 
            this.tbCompare.Location = new System.Drawing.Point(25, 203);
            this.tbCompare.Name = "tbCompare";
            this.tbCompare.Size = new System.Drawing.Size(311, 20);
            this.tbCompare.TabIndex = 1;
            // 
            // tbMD5Checksum
            // 
            this.tbMD5Checksum.Location = new System.Drawing.Point(25, 142);
            this.tbMD5Checksum.Name = "tbMD5Checksum";
            this.tbMD5Checksum.Size = new System.Drawing.Size(311, 20);
            this.tbMD5Checksum.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Compare With";
            // 
            // btCopyMD5
            // 
            this.btCopyMD5.Location = new System.Drawing.Point(351, 141);
            this.btCopyMD5.Name = "btCopyMD5";
            this.btCopyMD5.Size = new System.Drawing.Size(75, 23);
            this.btCopyMD5.TabIndex = 2;
            this.btCopyMD5.Text = "Copy MD5";
            this.btCopyMD5.UseVisualStyleBackColor = true;
            // 
            // btGetMD5
            // 
            this.btGetMD5.Location = new System.Drawing.Point(351, 66);
            this.btGetMD5.Name = "btGetMD5";
            this.btGetMD5.Size = new System.Drawing.Size(75, 23);
            this.btGetMD5.TabIndex = 2;
            this.btGetMD5.Text = "Browse...";
            this.btGetMD5.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "MD5 Checksum";
            // 
            // tbGetMD5
            // 
            this.tbGetMD5.Location = new System.Drawing.Point(25, 68);
            this.tbGetMD5.Name = "tbGetMD5";
            this.tbGetMD5.Size = new System.Drawing.Size(311, 20);
            this.tbGetMD5.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Get MD5 Signature from:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btPlaceStoreKey);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.tbPlaceStoreKey);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.btGenerate);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.tbPublicE);
            this.tabPage3.Controls.Add(this.tbPrimeQ);
            this.tabPage3.Controls.Add(this.tbPrimeP);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(437, 334);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Generate Key";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btPlaceStoreKey
            // 
            this.btPlaceStoreKey.Location = new System.Drawing.Point(337, 255);
            this.btPlaceStoreKey.Name = "btPlaceStoreKey";
            this.btPlaceStoreKey.Size = new System.Drawing.Size(75, 23);
            this.btPlaceStoreKey.TabIndex = 7;
            this.btPlaceStoreKey.Text = "Browse...";
            this.btPlaceStoreKey.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Place where to store key:";
            // 
            // tbPlaceStoreKey
            // 
            this.tbPlaceStoreKey.Location = new System.Drawing.Point(19, 257);
            this.tbPlaceStoreKey.Name = "tbPlaceStoreKey";
            this.tbPlaceStoreKey.Size = new System.Drawing.Size(311, 20);
            this.tbPlaceStoreKey.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Public Key e";
            // 
            // btGenerate
            // 
            this.btGenerate.Location = new System.Drawing.Point(128, 288);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(176, 42);
            this.btGenerate.TabIndex = 3;
            this.btGenerate.Text = "GENERATE";
            this.btGenerate.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Prime Number q";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Prime Number p";
            // 
            // tbPublicE
            // 
            this.tbPublicE.Location = new System.Drawing.Point(105, 81);
            this.tbPublicE.Name = "tbPublicE";
            this.tbPublicE.Size = new System.Drawing.Size(100, 20);
            this.tbPublicE.TabIndex = 0;
            this.tbPublicE.Text = "65537";
            // 
            // tbPrimeQ
            // 
            this.tbPrimeQ.Location = new System.Drawing.Point(105, 52);
            this.tbPrimeQ.Name = "tbPrimeQ";
            this.tbPrimeQ.Size = new System.Drawing.Size(100, 20);
            this.tbPrimeQ.TabIndex = 0;
            // 
            // tbPrimeP
            // 
            this.tbPrimeP.Location = new System.Drawing.Point(105, 19);
            this.tbPrimeP.Name = "tbPrimeP";
            this.tbPrimeP.Size = new System.Drawing.Size(100, 20);
            this.tbPrimeP.TabIndex = 0;
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.Red;
            this.progressBar.ForeColor = System.Drawing.Color.Fuchsia;
            this.progressBar.Location = new System.Drawing.Point(-1, 356);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(444, 32);
            this.progressBar.TabIndex = 12;
            this.progressBar.Tag = "";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "hello",
            "world",
            "oc ",
            "cho"});
            this.comboBox1.Location = new System.Drawing.Point(96, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // EDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 387);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EDForm";
            this.Text = "Encryp/Decrypt Program";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btChooseKey;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btOutputDirectory;
        private System.Windows.Forms.Button btSourceFile;
        private System.Windows.Forms.TextBox tbOutputDirectory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSourceFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btDecrypt;
        private System.Windows.Forms.Button btEncrypt;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RadioButton rbVerify;
        private System.Windows.Forms.RadioButton rdGetMD5;
        private System.Windows.Forms.TextBox tbMD5Checksum;
        private System.Windows.Forms.Button btGetMD5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbGetMD5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbDES;
        private System.Windows.Forms.RadioButton rbRSA;
        private System.Windows.Forms.RadioButton rbAES;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.TextBox tbCompare;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btCopyMD5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btGenerate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbPublicE;
        private System.Windows.Forms.TextBox tbPrimeQ;
        private System.Windows.Forms.TextBox tbPrimeP;
        private System.Windows.Forms.Button btPlaceStoreKey;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbPlaceStoreKey;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}


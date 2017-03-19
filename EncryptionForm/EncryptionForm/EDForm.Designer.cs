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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btChooseKey = new System.Windows.Forms.Button();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btOutputDirectory = new System.Windows.Forms.Button();
            this.btSourceFile = new System.Windows.Forms.Button();
            this.tbOutputDirectory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSourceFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.rbDecryption = new System.Windows.Forms.RadioButton();
            this.rbEncryption = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.keyLength = new System.Windows.Forms.ComboBox();
            this.rbDES = new System.Windows.Forms.RadioButton();
            this.rbRSA = new System.Windows.Forms.RadioButton();
            this.rbAES = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btStart_1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btStart_2 = new System.Windows.Forms.Button();
            this.rbVerify = new System.Windows.Forms.RadioButton();
            this.rbGetMD5 = new System.Windows.Forms.RadioButton();
            this.tbCompare = new System.Windows.Forms.TextBox();
            this.tbMD5Checksum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btCopyMD5 = new System.Windows.Forms.Button();
            this.btGetMD5 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbGetMD5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.keyLengthGenAES = new System.Windows.Forms.ComboBox();
            this.tbGenAES = new System.Windows.Forms.TextBox();
            this.tbGenDES = new System.Windows.Forms.TextBox();
            this.tbRange = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.rbGenAES = new System.Windows.Forms.RadioButton();
            this.rbGenDES = new System.Windows.Forms.RadioButton();
            this.btStore = new System.Windows.Forms.Button();
            this.rbGenRSA = new System.Windows.Forms.RadioButton();
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
            this.tbPsw = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, -2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(591, 480);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.btStart_1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(583, 451);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Encrypt/Decrypt";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btChooseKey);
            this.panel3.Controls.Add(this.tbKey);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btOutputDirectory);
            this.panel3.Controls.Add(this.btSourceFile);
            this.panel3.Controls.Add(this.tbOutputDirectory);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.tbSourceFile);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(-5, 138);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(591, 215);
            this.panel3.TabIndex = 22;
            // 
            // btChooseKey
            // 
            this.btChooseKey.Enabled = false;
            this.btChooseKey.Location = new System.Drawing.Point(473, 148);
            this.btChooseKey.Margin = new System.Windows.Forms.Padding(4);
            this.btChooseKey.Name = "btChooseKey";
            this.btChooseKey.Size = new System.Drawing.Size(100, 53);
            this.btChooseKey.TabIndex = 18;
            this.btChooseKey.Text = "Choose Key File";
            this.btChooseKey.UseVisualStyleBackColor = true;
            this.btChooseKey.Click += new System.EventHandler(this.btChooseKey_Click);
            // 
            // tbKey
            // 
            this.tbKey.Enabled = false;
            this.tbKey.Location = new System.Drawing.Point(19, 148);
            this.tbKey.Margin = new System.Windows.Forms.Padding(4);
            this.tbKey.Multiline = true;
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(445, 52);
            this.tbKey.TabIndex = 17;
            this.tbKey.TextChanged += new System.EventHandler(this.tbKey_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Key";
            // 
            // btOutputDirectory
            // 
            this.btOutputDirectory.Enabled = false;
            this.btOutputDirectory.Location = new System.Drawing.Point(475, 100);
            this.btOutputDirectory.Margin = new System.Windows.Forms.Padding(4);
            this.btOutputDirectory.Name = "btOutputDirectory";
            this.btOutputDirectory.Size = new System.Drawing.Size(100, 27);
            this.btOutputDirectory.TabIndex = 14;
            this.btOutputDirectory.Text = "Browse...";
            this.btOutputDirectory.UseVisualStyleBackColor = true;
            this.btOutputDirectory.Click += new System.EventHandler(this.btOutputDirectory_Click);
            // 
            // btSourceFile
            // 
            this.btSourceFile.Enabled = false;
            this.btSourceFile.Location = new System.Drawing.Point(475, 30);
            this.btSourceFile.Margin = new System.Windows.Forms.Padding(4);
            this.btSourceFile.Name = "btSourceFile";
            this.btSourceFile.Size = new System.Drawing.Size(100, 27);
            this.btSourceFile.TabIndex = 15;
            this.btSourceFile.Text = "Browse..";
            this.btSourceFile.UseVisualStyleBackColor = true;
            this.btSourceFile.Click += new System.EventHandler(this.btSourceFile_Click);
            // 
            // tbOutputDirectory
            // 
            this.tbOutputDirectory.Enabled = false;
            this.tbOutputDirectory.Location = new System.Drawing.Point(20, 100);
            this.tbOutputDirectory.Margin = new System.Windows.Forms.Padding(4);
            this.tbOutputDirectory.Name = "tbOutputDirectory";
            this.tbOutputDirectory.Size = new System.Drawing.Size(445, 22);
            this.tbOutputDirectory.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Output Directory";
            // 
            // tbSourceFile
            // 
            this.tbSourceFile.Enabled = false;
            this.tbSourceFile.Location = new System.Drawing.Point(20, 32);
            this.tbSourceFile.Margin = new System.Windows.Forms.Padding(4);
            this.tbSourceFile.Name = "tbSourceFile";
            this.tbSourceFile.Size = new System.Drawing.Size(445, 22);
            this.tbSourceFile.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Source File";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.rbDecryption);
            this.panel2.Controls.Add(this.rbEncryption);
            this.panel2.Location = new System.Drawing.Point(-7, 69);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(591, 61);
            this.panel2.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 6);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 17);
            this.label12.TabIndex = 21;
            this.label12.Text = "Operation";
            // 
            // rbDecryption
            // 
            this.rbDecryption.AutoSize = true;
            this.rbDecryption.Enabled = false;
            this.rbDecryption.Location = new System.Drawing.Point(348, 27);
            this.rbDecryption.Margin = new System.Windows.Forms.Padding(4);
            this.rbDecryption.Name = "rbDecryption";
            this.rbDecryption.Size = new System.Drawing.Size(97, 21);
            this.rbDecryption.TabIndex = 20;
            this.rbDecryption.TabStop = true;
            this.rbDecryption.Text = "Decryption";
            this.rbDecryption.UseVisualStyleBackColor = true;
            this.rbDecryption.CheckedChanged += new System.EventHandler(this.rbDecryption_CheckedChanged);
            // 
            // rbEncryption
            // 
            this.rbEncryption.AutoSize = true;
            this.rbEncryption.Enabled = false;
            this.rbEncryption.Location = new System.Drawing.Point(132, 27);
            this.rbEncryption.Margin = new System.Windows.Forms.Padding(4);
            this.rbEncryption.Name = "rbEncryption";
            this.rbEncryption.Size = new System.Drawing.Size(96, 21);
            this.rbEncryption.TabIndex = 19;
            this.rbEncryption.TabStop = true;
            this.rbEncryption.Text = "Encryption";
            this.rbEncryption.UseVisualStyleBackColor = true;
            this.rbEncryption.CheckedChanged += new System.EventHandler(this.rbEncryption_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.keyLength);
            this.panel1.Controls.Add(this.rbDES);
            this.panel1.Controls.Add(this.rbRSA);
            this.panel1.Controls.Add(this.rbAES);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-7, -10);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 81);
            this.panel1.TabIndex = 20;
            // 
            // keyLength
            // 
            this.keyLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.keyLength.Enabled = false;
            this.keyLength.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.keyLength.FormattingEnabled = true;
            this.keyLength.Items.AddRange(new object[] {
            "128 bits",
            "192 bits",
            "256 bits"});
            this.keyLength.Location = new System.Drawing.Point(120, 38);
            this.keyLength.Margin = new System.Windows.Forms.Padding(4);
            this.keyLength.Name = "keyLength";
            this.keyLength.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.keyLength.Size = new System.Drawing.Size(83, 24);
            this.keyLength.TabIndex = 20;
            // 
            // rbDES
            // 
            this.rbDES.AutoSize = true;
            this.rbDES.Location = new System.Drawing.Point(445, 41);
            this.rbDES.Margin = new System.Windows.Forms.Padding(5);
            this.rbDES.Name = "rbDES";
            this.rbDES.Size = new System.Drawing.Size(57, 21);
            this.rbDES.TabIndex = 19;
            this.rbDES.TabStop = true;
            this.rbDES.Text = "DES";
            this.rbDES.UseVisualStyleBackColor = true;
            this.rbDES.CheckedChanged += new System.EventHandler(this.rbDES_CheckedChanged);
            // 
            // rbRSA
            // 
            this.rbRSA.AutoSize = true;
            this.rbRSA.Location = new System.Drawing.Point(251, 41);
            this.rbRSA.Margin = new System.Windows.Forms.Padding(5);
            this.rbRSA.Name = "rbRSA";
            this.rbRSA.Size = new System.Drawing.Size(57, 21);
            this.rbRSA.TabIndex = 18;
            this.rbRSA.TabStop = true;
            this.rbRSA.Text = "RSA";
            this.rbRSA.UseVisualStyleBackColor = true;
            this.rbRSA.CheckedChanged += new System.EventHandler(this.rbRSA_CheckedChanged);
            // 
            // rbAES
            // 
            this.rbAES.AutoSize = true;
            this.rbAES.Location = new System.Drawing.Point(60, 41);
            this.rbAES.Margin = new System.Windows.Forms.Padding(4);
            this.rbAES.Name = "rbAES";
            this.rbAES.Size = new System.Drawing.Size(56, 21);
            this.rbAES.TabIndex = 17;
            this.rbAES.TabStop = true;
            this.rbAES.Text = "AES";
            this.rbAES.UseVisualStyleBackColor = true;
            this.rbAES.CheckedChanged += new System.EventHandler(this.rbAES_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Algorithm";
            // 
            // btStart_1
            // 
            this.btStart_1.Enabled = false;
            this.btStart_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStart_1.Location = new System.Drawing.Point(193, 367);
            this.btStart_1.Margin = new System.Windows.Forms.Padding(4);
            this.btStart_1.Name = "btStart_1";
            this.btStart_1.Size = new System.Drawing.Size(180, 65);
            this.btStart_1.TabIndex = 19;
            this.btStart_1.Text = "START";
            this.btStart_1.UseVisualStyleBackColor = true;
            this.btStart_1.Click += new System.EventHandler(this.btStart_1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btStart_2);
            this.tabPage2.Controls.Add(this.rbVerify);
            this.tabPage2.Controls.Add(this.rbGetMD5);
            this.tabPage2.Controls.Add(this.tbCompare);
            this.tabPage2.Controls.Add(this.tbMD5Checksum);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.btCopyMD5);
            this.tabPage2.Controls.Add(this.btGetMD5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.tbGetMD5);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(583, 451);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MD5 Checksum";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btStart_2
            // 
            this.btStart_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStart_2.Location = new System.Drawing.Point(193, 367);
            this.btStart_2.Margin = new System.Windows.Forms.Padding(4);
            this.btStart_2.Name = "btStart_2";
            this.btStart_2.Size = new System.Drawing.Size(183, 65);
            this.btStart_2.TabIndex = 5;
            this.btStart_2.Text = "START";
            this.btStart_2.UseVisualStyleBackColor = true;
            this.btStart_2.Click += new System.EventHandler(this.btStart_2_Click);
            // 
            // rbVerify
            // 
            this.rbVerify.AutoSize = true;
            this.rbVerify.Location = new System.Drawing.Point(307, 21);
            this.rbVerify.Margin = new System.Windows.Forms.Padding(4);
            this.rbVerify.Name = "rbVerify";
            this.rbVerify.Size = new System.Drawing.Size(98, 21);
            this.rbVerify.TabIndex = 4;
            this.rbVerify.TabStop = true;
            this.rbVerify.Text = "Verify MD5";
            this.rbVerify.UseVisualStyleBackColor = true;
            this.rbVerify.CheckedChanged += new System.EventHandler(this.rbVerify_CheckedChanged);
            // 
            // rbGetMD5
            // 
            this.rbGetMD5.AutoSize = true;
            this.rbGetMD5.Location = new System.Drawing.Point(109, 21);
            this.rbGetMD5.Margin = new System.Windows.Forms.Padding(4);
            this.rbGetMD5.Name = "rbGetMD5";
            this.rbGetMD5.Size = new System.Drawing.Size(89, 21);
            this.rbGetMD5.TabIndex = 3;
            this.rbGetMD5.TabStop = true;
            this.rbGetMD5.Text = "Get MD5 ";
            this.rbGetMD5.UseVisualStyleBackColor = true;
            this.rbGetMD5.CheckedChanged += new System.EventHandler(this.rbGetMD5_CheckedChanged);
            // 
            // tbCompare
            // 
            this.tbCompare.Enabled = false;
            this.tbCompare.Location = new System.Drawing.Point(33, 256);
            this.tbCompare.Margin = new System.Windows.Forms.Padding(4);
            this.tbCompare.Name = "tbCompare";
            this.tbCompare.Size = new System.Drawing.Size(413, 22);
            this.tbCompare.TabIndex = 1;
            // 
            // tbMD5Checksum
            // 
            this.tbMD5Checksum.Enabled = false;
            this.tbMD5Checksum.Location = new System.Drawing.Point(33, 175);
            this.tbMD5Checksum.Margin = new System.Windows.Forms.Padding(4);
            this.tbMD5Checksum.Name = "tbMD5Checksum";
            this.tbMD5Checksum.Size = new System.Drawing.Size(413, 22);
            this.tbMD5Checksum.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 236);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Compare With";
            // 
            // btCopyMD5
            // 
            this.btCopyMD5.Enabled = false;
            this.btCopyMD5.Location = new System.Drawing.Point(468, 174);
            this.btCopyMD5.Margin = new System.Windows.Forms.Padding(4);
            this.btCopyMD5.Name = "btCopyMD5";
            this.btCopyMD5.Size = new System.Drawing.Size(100, 28);
            this.btCopyMD5.TabIndex = 2;
            this.btCopyMD5.Text = "Copy MD5";
            this.btCopyMD5.UseVisualStyleBackColor = true;
            this.btCopyMD5.Click += new System.EventHandler(this.btCopyMD5_Click);
            // 
            // btGetMD5
            // 
            this.btGetMD5.Enabled = false;
            this.btGetMD5.Location = new System.Drawing.Point(468, 81);
            this.btGetMD5.Margin = new System.Windows.Forms.Padding(4);
            this.btGetMD5.Name = "btGetMD5";
            this.btGetMD5.Size = new System.Drawing.Size(100, 28);
            this.btGetMD5.TabIndex = 2;
            this.btGetMD5.Text = "Browse...";
            this.btGetMD5.UseVisualStyleBackColor = true;
            this.btGetMD5.Click += new System.EventHandler(this.btGetMD5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 155);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "MD5 Checksum";
            // 
            // tbGetMD5
            // 
            this.tbGetMD5.Enabled = false;
            this.tbGetMD5.Location = new System.Drawing.Point(33, 84);
            this.tbGetMD5.Margin = new System.Windows.Forms.Padding(4);
            this.tbGetMD5.Name = "tbGetMD5";
            this.tbGetMD5.Size = new System.Drawing.Size(413, 22);
            this.tbGetMD5.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Get MD5 Signature from:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tbPsw);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.keyLengthGenAES);
            this.tabPage3.Controls.Add(this.tbGenAES);
            this.tabPage3.Controls.Add(this.tbGenDES);
            this.tabPage3.Controls.Add(this.tbRange);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.rbGenAES);
            this.tabPage3.Controls.Add(this.rbGenDES);
            this.tabPage3.Controls.Add(this.btStore);
            this.tabPage3.Controls.Add(this.rbGenRSA);
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
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(583, 451);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Generate Key";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(294, 227);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 17);
            this.label14.TabIndex = 16;
            this.label14.Text = "Password";
            // 
            // keyLengthGenAES
            // 
            this.keyLengthGenAES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.keyLengthGenAES.Enabled = false;
            this.keyLengthGenAES.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.keyLengthGenAES.FormattingEnabled = true;
            this.keyLengthGenAES.Items.AddRange(new object[] {
            "128 bits",
            "192 bits",
            "256 bits"});
            this.keyLengthGenAES.Location = new System.Drawing.Point(88, 223);
            this.keyLengthGenAES.Name = "keyLengthGenAES";
            this.keyLengthGenAES.Size = new System.Drawing.Size(82, 24);
            this.keyLengthGenAES.TabIndex = 15;
            // 
            // tbGenAES
            // 
            this.tbGenAES.Enabled = false;
            this.tbGenAES.Location = new System.Drawing.Point(36, 257);
            this.tbGenAES.Margin = new System.Windows.Forms.Padding(4);
            this.tbGenAES.Multiline = true;
            this.tbGenAES.Name = "tbGenAES";
            this.tbGenAES.ReadOnly = true;
            this.tbGenAES.Size = new System.Drawing.Size(512, 50);
            this.tbGenAES.TabIndex = 14;
            // 
            // tbGenDES
            // 
            this.tbGenDES.Enabled = false;
            this.tbGenDES.Location = new System.Drawing.Point(36, 162);
            this.tbGenDES.Margin = new System.Windows.Forms.Padding(4);
            this.tbGenDES.Multiline = true;
            this.tbGenDES.Name = "tbGenDES";
            this.tbGenDES.Size = new System.Drawing.Size(512, 50);
            this.tbGenDES.TabIndex = 14;
            // 
            // tbRange
            // 
            this.tbRange.Enabled = false;
            this.tbRange.Location = new System.Drawing.Point(483, 98);
            this.tbRange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRange.Name = "tbRange";
            this.tbRange.Size = new System.Drawing.Size(65, 22);
            this.tbRange.TabIndex = 13;
            this.tbRange.Text = "10";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(409, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 17);
            this.label13.TabIndex = 12;
            this.label13.Text = "Range  >";
            // 
            // rbGenAES
            // 
            this.rbGenAES.AutoSize = true;
            this.rbGenAES.Location = new System.Drawing.Point(25, 225);
            this.rbGenAES.Margin = new System.Windows.Forms.Padding(4);
            this.rbGenAES.Name = "rbGenAES";
            this.rbGenAES.Size = new System.Drawing.Size(56, 21);
            this.rbGenAES.TabIndex = 11;
            this.rbGenAES.TabStop = true;
            this.rbGenAES.Text = "AES";
            this.rbGenAES.UseVisualStyleBackColor = true;
            this.rbGenAES.CheckedChanged += new System.EventHandler(this.rbGenAES_CheckedChanged);
            // 
            // rbGenDES
            // 
            this.rbGenDES.AutoSize = true;
            this.rbGenDES.Location = new System.Drawing.Point(24, 133);
            this.rbGenDES.Margin = new System.Windows.Forms.Padding(4);
            this.rbGenDES.Name = "rbGenDES";
            this.rbGenDES.Size = new System.Drawing.Size(57, 21);
            this.rbGenDES.TabIndex = 10;
            this.rbGenDES.TabStop = true;
            this.rbGenDES.Text = "DES";
            this.rbGenDES.UseVisualStyleBackColor = true;
            this.rbGenDES.CheckedChanged += new System.EventHandler(this.rbGenDES_CheckedChanged);
            // 
            // btStore
            // 
            this.btStore.Enabled = false;
            this.btStore.Location = new System.Drawing.Point(331, 374);
            this.btStore.Margin = new System.Windows.Forms.Padding(4);
            this.btStore.Name = "btStore";
            this.btStore.Size = new System.Drawing.Size(160, 50);
            this.btStore.TabIndex = 9;
            this.btStore.Text = "Store";
            this.btStore.UseVisualStyleBackColor = true;
            this.btStore.Click += new System.EventHandler(this.btStore_Click);
            // 
            // rbGenRSA
            // 
            this.rbGenRSA.AutoSize = true;
            this.rbGenRSA.Location = new System.Drawing.Point(25, 4);
            this.rbGenRSA.Margin = new System.Windows.Forms.Padding(4);
            this.rbGenRSA.Name = "rbGenRSA";
            this.rbGenRSA.Size = new System.Drawing.Size(57, 21);
            this.rbGenRSA.TabIndex = 8;
            this.rbGenRSA.TabStop = true;
            this.rbGenRSA.Text = "RSA";
            this.rbGenRSA.UseVisualStyleBackColor = true;
            this.rbGenRSA.CheckedChanged += new System.EventHandler(this.rbGenRSA_CheckedChanged);
            // 
            // btPlaceStoreKey
            // 
            this.btPlaceStoreKey.Location = new System.Drawing.Point(449, 337);
            this.btPlaceStoreKey.Margin = new System.Windows.Forms.Padding(4);
            this.btPlaceStoreKey.Name = "btPlaceStoreKey";
            this.btPlaceStoreKey.Size = new System.Drawing.Size(100, 28);
            this.btPlaceStoreKey.TabIndex = 7;
            this.btPlaceStoreKey.Text = "Browse...";
            this.btPlaceStoreKey.UseVisualStyleBackColor = true;
            this.btPlaceStoreKey.Click += new System.EventHandler(this.btPlaceStoreKey_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 317);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "Place where to store key:";
            // 
            // tbPlaceStoreKey
            // 
            this.tbPlaceStoreKey.Location = new System.Drawing.Point(36, 340);
            this.tbPlaceStoreKey.Margin = new System.Windows.Forms.Padding(4);
            this.tbPlaceStoreKey.Name = "tbPlaceStoreKey";
            this.tbPlaceStoreKey.Size = new System.Drawing.Size(402, 22);
            this.tbPlaceStoreKey.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 102);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Public Key e";
            // 
            // btGenerate
            // 
            this.btGenerate.Enabled = false;
            this.btGenerate.Location = new System.Drawing.Point(88, 374);
            this.btGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(160, 50);
            this.btGenerate.TabIndex = 3;
            this.btGenerate.Text = "Generate";
            this.btGenerate.UseVisualStyleBackColor = true;
            this.btGenerate.Click += new System.EventHandler(this.btGenerate_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 70);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Prime Number q";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 38);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Prime Number p";
            // 
            // tbPublicE
            // 
            this.tbPublicE.Enabled = false;
            this.tbPublicE.Location = new System.Drawing.Point(148, 98);
            this.tbPublicE.Margin = new System.Windows.Forms.Padding(4);
            this.tbPublicE.Name = "tbPublicE";
            this.tbPublicE.Size = new System.Drawing.Size(103, 22);
            this.tbPublicE.TabIndex = 0;
            // 
            // tbPrimeQ
            // 
            this.tbPrimeQ.Enabled = false;
            this.tbPrimeQ.Location = new System.Drawing.Point(148, 66);
            this.tbPrimeQ.Margin = new System.Windows.Forms.Padding(4);
            this.tbPrimeQ.Name = "tbPrimeQ";
            this.tbPrimeQ.Size = new System.Drawing.Size(400, 22);
            this.tbPrimeQ.TabIndex = 0;
            // 
            // tbPrimeP
            // 
            this.tbPrimeP.Enabled = false;
            this.tbPrimeP.Location = new System.Drawing.Point(148, 34);
            this.tbPrimeP.Margin = new System.Windows.Forms.Padding(4);
            this.tbPrimeP.Name = "tbPrimeP";
            this.tbPrimeP.Size = new System.Drawing.Size(400, 22);
            this.tbPrimeP.TabIndex = 0;
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.Red;
            this.progressBar.ForeColor = System.Drawing.Color.Fuchsia;
            this.progressBar.Location = new System.Drawing.Point(-1, 464);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(592, 14);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 12;
            this.progressBar.Tag = "";
            // 
            // tbPsw
            // 
            this.tbPsw.Enabled = false;
            this.tbPsw.Location = new System.Drawing.Point(369, 225);
            this.tbPsw.Name = "tbPsw";
            this.tbPsw.Size = new System.Drawing.Size(178, 22);
            this.tbPsw.TabIndex = 17;
            this.tbPsw.UseSystemPasswordChar = true;
            // 
            // EDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 476);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EDForm";
            this.Text = "Encryp/Decrypt Program";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RadioButton rbVerify;
        private System.Windows.Forms.RadioButton rbGetMD5;
        private System.Windows.Forms.TextBox tbMD5Checksum;
        private System.Windows.Forms.Button btGetMD5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbGetMD5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btStart_2;
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
        private System.Windows.Forms.RadioButton rbGenRSA;
        private System.Windows.Forms.Button btStore;
        private System.Windows.Forms.RadioButton rbGenAES;
        private System.Windows.Forms.RadioButton rbGenDES;
        private System.Windows.Forms.Button btStart_1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox keyLength;
        private System.Windows.Forms.RadioButton rbDES;
        private System.Windows.Forms.RadioButton rbRSA;
        private System.Windows.Forms.RadioButton rbAES;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rbDecryption;
        private System.Windows.Forms.RadioButton rbEncryption;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btChooseKey;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btOutputDirectory;
        private System.Windows.Forms.Button btSourceFile;
        private System.Windows.Forms.TextBox tbOutputDirectory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSourceFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbRange;
        private System.Windows.Forms.TextBox tbGenAES;
        private System.Windows.Forms.TextBox tbGenDES;
        private System.Windows.Forms.ComboBox keyLengthGenAES;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbPsw;
    }
}


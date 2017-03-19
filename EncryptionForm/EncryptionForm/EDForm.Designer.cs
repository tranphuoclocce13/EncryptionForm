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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
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
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(443, 390);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.btStart_1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(435, 364);
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
            this.panel3.Location = new System.Drawing.Point(-4, 112);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(443, 175);
            this.panel3.TabIndex = 22;
            // 
            // btChooseKey
            // 
            this.btChooseKey.Enabled = false;
            this.btChooseKey.Location = new System.Drawing.Point(355, 120);
            this.btChooseKey.Name = "btChooseKey";
            this.btChooseKey.Size = new System.Drawing.Size(75, 43);
            this.btChooseKey.TabIndex = 18;
            this.btChooseKey.Text = "Choose Key File";
            this.btChooseKey.UseVisualStyleBackColor = true;
            this.btChooseKey.Click += new System.EventHandler(this.btChooseKey_Click);
            // 
            // tbKey
            // 
            this.tbKey.Enabled = false;
            this.tbKey.Location = new System.Drawing.Point(14, 120);
            this.tbKey.Multiline = true;
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(335, 43);
            this.tbKey.TabIndex = 17;
            this.tbKey.TextChanged += new System.EventHandler(this.tbKey_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Key";
            // 
            // btOutputDirectory
            // 
            this.btOutputDirectory.Enabled = false;
            this.btOutputDirectory.Location = new System.Drawing.Point(356, 81);
            this.btOutputDirectory.Name = "btOutputDirectory";
            this.btOutputDirectory.Size = new System.Drawing.Size(75, 22);
            this.btOutputDirectory.TabIndex = 14;
            this.btOutputDirectory.Text = "Browse...";
            this.btOutputDirectory.UseVisualStyleBackColor = true;
            this.btOutputDirectory.Click += new System.EventHandler(this.btOutputDirectory_Click);
            // 
            // btSourceFile
            // 
            this.btSourceFile.Enabled = false;
            this.btSourceFile.Location = new System.Drawing.Point(356, 24);
            this.btSourceFile.Name = "btSourceFile";
            this.btSourceFile.Size = new System.Drawing.Size(75, 22);
            this.btSourceFile.TabIndex = 15;
            this.btSourceFile.Text = "Browse..";
            this.btSourceFile.UseVisualStyleBackColor = true;
            this.btSourceFile.Click += new System.EventHandler(this.btSourceFile_Click);
            // 
            // tbOutputDirectory
            // 
            this.tbOutputDirectory.Enabled = false;
            this.tbOutputDirectory.Location = new System.Drawing.Point(15, 81);
            this.tbOutputDirectory.Name = "tbOutputDirectory";
            this.tbOutputDirectory.Size = new System.Drawing.Size(335, 20);
            this.tbOutputDirectory.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Output Directory";
            // 
            // tbSourceFile
            // 
            this.tbSourceFile.Enabled = false;
            this.tbSourceFile.Location = new System.Drawing.Point(15, 26);
            this.tbSourceFile.Name = "tbSourceFile";
            this.tbSourceFile.Size = new System.Drawing.Size(335, 20);
            this.tbSourceFile.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Source File";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.rbDecryption);
            this.panel2.Controls.Add(this.rbEncryption);
            this.panel2.Location = new System.Drawing.Point(-5, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 50);
            this.panel2.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Operation";
            // 
            // rbDecryption
            // 
            this.rbDecryption.AutoSize = true;
            this.rbDecryption.Enabled = false;
            this.rbDecryption.Location = new System.Drawing.Point(261, 22);
            this.rbDecryption.Name = "rbDecryption";
            this.rbDecryption.Size = new System.Drawing.Size(76, 17);
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
            this.rbEncryption.Location = new System.Drawing.Point(99, 22);
            this.rbEncryption.Name = "rbEncryption";
            this.rbEncryption.Size = new System.Drawing.Size(75, 17);
            this.rbEncryption.TabIndex = 19;
            this.rbEncryption.TabStop = true;
            this.rbEncryption.Text = "Encryption";
            this.rbEncryption.UseVisualStyleBackColor = true;
            this.rbEncryption.CheckedChanged += new System.EventHandler(this.rbEncryption_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.rbDES);
            this.panel1.Controls.Add(this.rbRSA);
            this.panel1.Controls.Add(this.rbAES);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-5, -8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 66);
            this.panel1.TabIndex = 20;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "128 bits",
            "192 bits",
            "256 bits"});
            this.comboBox1.Location = new System.Drawing.Point(90, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox1.Size = new System.Drawing.Size(63, 21);
            this.comboBox1.TabIndex = 20;
            // 
            // rbDES
            // 
            this.rbDES.AutoSize = true;
            this.rbDES.Location = new System.Drawing.Point(334, 33);
            this.rbDES.Margin = new System.Windows.Forms.Padding(4);
            this.rbDES.Name = "rbDES";
            this.rbDES.Size = new System.Drawing.Size(47, 17);
            this.rbDES.TabIndex = 19;
            this.rbDES.TabStop = true;
            this.rbDES.Text = "DES";
            this.rbDES.UseVisualStyleBackColor = true;
            this.rbDES.CheckedChanged += new System.EventHandler(this.rbDES_CheckedChanged);
            // 
            // rbRSA
            // 
            this.rbRSA.AutoSize = true;
            this.rbRSA.Location = new System.Drawing.Point(188, 33);
            this.rbRSA.Margin = new System.Windows.Forms.Padding(4);
            this.rbRSA.Name = "rbRSA";
            this.rbRSA.Size = new System.Drawing.Size(47, 17);
            this.rbRSA.TabIndex = 18;
            this.rbRSA.TabStop = true;
            this.rbRSA.Text = "RSA";
            this.rbRSA.UseVisualStyleBackColor = true;
            this.rbRSA.CheckedChanged += new System.EventHandler(this.rbRSA_CheckedChanged);
            // 
            // rbAES
            // 
            this.rbAES.AutoSize = true;
            this.rbAES.Location = new System.Drawing.Point(45, 33);
            this.rbAES.Name = "rbAES";
            this.rbAES.Size = new System.Drawing.Size(46, 17);
            this.rbAES.TabIndex = 17;
            this.rbAES.TabStop = true;
            this.rbAES.Text = "AES";
            this.rbAES.UseVisualStyleBackColor = true;
            this.rbAES.CheckedChanged += new System.EventHandler(this.rbAES_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Algorithm";
            // 
            // btStart_1
            // 
            this.btStart_1.Enabled = false;
            this.btStart_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStart_1.Location = new System.Drawing.Point(145, 298);
            this.btStart_1.Name = "btStart_1";
            this.btStart_1.Size = new System.Drawing.Size(135, 53);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(435, 364);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MD5 Checksum";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btStart_2
            // 
            this.btStart_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStart_2.Location = new System.Drawing.Point(145, 298);
            this.btStart_2.Name = "btStart_2";
            this.btStart_2.Size = new System.Drawing.Size(137, 53);
            this.btStart_2.TabIndex = 5;
            this.btStart_2.Text = "START";
            this.btStart_2.UseVisualStyleBackColor = true;
            this.btStart_2.Click += new System.EventHandler(this.btStart_2_Click);
            // 
            // rbVerify
            // 
            this.rbVerify.AutoSize = true;
            this.rbVerify.Location = new System.Drawing.Point(230, 17);
            this.rbVerify.Name = "rbVerify";
            this.rbVerify.Size = new System.Drawing.Size(77, 17);
            this.rbVerify.TabIndex = 4;
            this.rbVerify.TabStop = true;
            this.rbVerify.Text = "Verify MD5";
            this.rbVerify.UseVisualStyleBackColor = true;
            this.rbVerify.CheckedChanged += new System.EventHandler(this.rbVerify_CheckedChanged);
            // 
            // rbGetMD5
            // 
            this.rbGetMD5.AutoSize = true;
            this.rbGetMD5.Location = new System.Drawing.Point(82, 17);
            this.rbGetMD5.Name = "rbGetMD5";
            this.rbGetMD5.Size = new System.Drawing.Size(71, 17);
            this.rbGetMD5.TabIndex = 3;
            this.rbGetMD5.TabStop = true;
            this.rbGetMD5.Text = "Get MD5 ";
            this.rbGetMD5.UseVisualStyleBackColor = true;
            this.rbGetMD5.CheckedChanged += new System.EventHandler(this.rbGetMD5_CheckedChanged);
            // 
            // tbCompare
            // 
            this.tbCompare.Enabled = false;
            this.tbCompare.Location = new System.Drawing.Point(25, 208);
            this.tbCompare.Name = "tbCompare";
            this.tbCompare.Size = new System.Drawing.Size(311, 20);
            this.tbCompare.TabIndex = 1;
            // 
            // tbMD5Checksum
            // 
            this.tbMD5Checksum.Enabled = false;
            this.tbMD5Checksum.Location = new System.Drawing.Point(25, 142);
            this.tbMD5Checksum.Name = "tbMD5Checksum";
            this.tbMD5Checksum.Size = new System.Drawing.Size(311, 20);
            this.tbMD5Checksum.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Compare With";
            // 
            // btCopyMD5
            // 
            this.btCopyMD5.Enabled = false;
            this.btCopyMD5.Location = new System.Drawing.Point(351, 141);
            this.btCopyMD5.Name = "btCopyMD5";
            this.btCopyMD5.Size = new System.Drawing.Size(75, 23);
            this.btCopyMD5.TabIndex = 2;
            this.btCopyMD5.Text = "Copy MD5";
            this.btCopyMD5.UseVisualStyleBackColor = true;
            this.btCopyMD5.Click += new System.EventHandler(this.btCopyMD5_Click);
            // 
            // btGetMD5
            // 
            this.btGetMD5.Enabled = false;
            this.btGetMD5.Location = new System.Drawing.Point(351, 66);
            this.btGetMD5.Name = "btGetMD5";
            this.btGetMD5.Size = new System.Drawing.Size(75, 23);
            this.btGetMD5.TabIndex = 2;
            this.btGetMD5.Text = "Browse...";
            this.btGetMD5.UseVisualStyleBackColor = true;
            this.btGetMD5.Click += new System.EventHandler(this.btGetMD5_Click);
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
            this.tbGetMD5.Enabled = false;
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
            this.tabPage3.Controls.Add(this.radioButton2);
            this.tabPage3.Controls.Add(this.radioButton1);
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
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(435, 333);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Generate Key";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(22, 181);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(46, 17);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "AES";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(19, 123);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 17);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "DES";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btStore
            // 
            this.btStore.Location = new System.Drawing.Point(244, 284);
            this.btStore.Name = "btStore";
            this.btStore.Size = new System.Drawing.Size(122, 41);
            this.btStore.TabIndex = 9;
            this.btStore.Text = "Store";
            this.btStore.UseVisualStyleBackColor = true;
            this.btStore.Click += new System.EventHandler(this.btStore_Click);
            // 
            // rbGenRSA
            // 
            this.rbGenRSA.AutoSize = true;
            this.rbGenRSA.Location = new System.Drawing.Point(19, 3);
            this.rbGenRSA.Name = "rbGenRSA";
            this.rbGenRSA.Size = new System.Drawing.Size(47, 17);
            this.rbGenRSA.TabIndex = 8;
            this.rbGenRSA.TabStop = true;
            this.rbGenRSA.Text = "RSA";
            this.rbGenRSA.UseVisualStyleBackColor = true;
            this.rbGenRSA.CheckedChanged += new System.EventHandler(this.rbGenRSA_CheckedChanged);
            // 
            // btPlaceStoreKey
            // 
            this.btPlaceStoreKey.Location = new System.Drawing.Point(337, 255);
            this.btPlaceStoreKey.Name = "btPlaceStoreKey";
            this.btPlaceStoreKey.Size = new System.Drawing.Size(75, 23);
            this.btPlaceStoreKey.TabIndex = 7;
            this.btPlaceStoreKey.Text = "Browse...";
            this.btPlaceStoreKey.UseVisualStyleBackColor = true;
            this.btPlaceStoreKey.Click += new System.EventHandler(this.btPlaceStoreKey_Click);
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
            this.label10.Location = new System.Drawing.Point(25, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Public Key e";
            // 
            // btGenerate
            // 
            this.btGenerate.Location = new System.Drawing.Point(45, 283);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(146, 42);
            this.btGenerate.TabIndex = 3;
            this.btGenerate.Text = "Generate";
            this.btGenerate.UseVisualStyleBackColor = true;
            this.btGenerate.Click += new System.EventHandler(this.btGenerate_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Prime Number q";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Prime Number p";
            // 
            // tbPublicE
            // 
            this.tbPublicE.Enabled = false;
            this.tbPublicE.Location = new System.Drawing.Point(111, 80);
            this.tbPublicE.Name = "tbPublicE";
            this.tbPublicE.Size = new System.Drawing.Size(301, 20);
            this.tbPublicE.TabIndex = 0;
            this.tbPublicE.Text = "65537";
            // 
            // tbPrimeQ
            // 
            this.tbPrimeQ.Enabled = false;
            this.tbPrimeQ.Location = new System.Drawing.Point(111, 54);
            this.tbPrimeQ.Name = "tbPrimeQ";
            this.tbPrimeQ.Size = new System.Drawing.Size(301, 20);
            this.tbPrimeQ.TabIndex = 0;
            // 
            // tbPrimeP
            // 
            this.tbPrimeP.Enabled = false;
            this.tbPrimeP.Location = new System.Drawing.Point(111, 28);
            this.tbPrimeP.Name = "tbPrimeP";
            this.tbPrimeP.Size = new System.Drawing.Size(301, 20);
            this.tbPrimeP.TabIndex = 0;
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.Red;
            this.progressBar.ForeColor = System.Drawing.Color.Fuchsia;
            this.progressBar.Location = new System.Drawing.Point(-1, 377);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(444, 11);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 12;
            this.progressBar.Tag = "";
            // 
            // EDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 387);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btStart_1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
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
    }
}


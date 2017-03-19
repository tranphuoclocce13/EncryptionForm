using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptionForm
{
    public partial class EDForm : Form
    {
        private const string CIPHER_TEXT_FILE = "Cipher_Text.txt";
        private const string PUBLIC_KEY_FILE = "Public_key.txt";
        private const string PRIVATE_KEY_FILE = "Private_key.txt";

        public EDForm()
        {
            InitializeComponent();
        }

/*********************************Handle Event*******************************************************/
/*Encrypt/Decrypt*/
        private void rbAES_CheckedChanged(object sender, EventArgs e)
        {
            enableOperation();
        }

        private void rbRSA_CheckedChanged(object sender, EventArgs e)
        {
            enableOperation();
        }

        private void rbDES_CheckedChanged(object sender, EventArgs e)
        {
            enableOperation();
        }

        private void enableOperation()
        {
            if (rbDecryption.Enabled == false)
            {
                rbDecryption.Enabled = true;
                rbEncryption.Enabled = true;
            }
        }

        private void rbEncryption_CheckedChanged(object sender, EventArgs e)
        {
            enableKeyInput();
            if (rbEncryption.Checked)
            {
                tbOutputDirectory.Text = tbSourceFile.Text;
                tbSourceFile.Text = "";
            }
        }

        private void rbDecryption_CheckedChanged(object sender, EventArgs e)
        {
            enableKeyInput();
            tbKey.Text = "";
            if (rbDecryption.Checked)
            {
                tbSourceFile.Text = tbOutputDirectory.Text;
                tbOutputDirectory.Text = ""; 
            }

        }

        private void enableKeyInput()
        {
            if (tbKey.Enabled == false)
            {
                tbSourceFile.Enabled = true;
                btSourceFile.Enabled = true;
                tbOutputDirectory.Enabled = true;
                btOutputDirectory.Enabled = true;
                tbKey.Enabled = true;
                btChooseKey.Enabled = true;
            }
        }

        /*check Key null or not to enable Button Encrypt*/
        private void tbKey_TextChanged(object sender, EventArgs e)
        {
            if (tbKey.Text == "")
            {
                btStart_1.Enabled = false;
            }
            else
            {
                btStart_1.Enabled = true;
            }
        }

        /*Click Browse Source File*/
        private void btSourceFile_Click(object sender, EventArgs e)
        {

            OpenFileDialog openDialog = new OpenFileDialog();

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                tbSourceFile.Text = openDialog.FileName;
            }
        }

        /*Click Browse Destination directory*/
        private void btOutputDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                if (rbEncryption.Checked)
                {
                    tbOutputDirectory.Text = folderDialog.SelectedPath + CIPHER_TEXT_FILE;
                }

                else
                {
                    tbOutputDirectory.Text = folderDialog.SelectedPath;
                }      
            }
        }

        /*Click Choose Key Button*/
        private void btChooseKey_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            string filePath = string.Empty;
            string text = string.Empty;
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    filePath = openDialog.FileName;
                    text = System.IO.File.ReadAllText(filePath);
                    tbKey.Text = text;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Cannot read data from this file!!!", "Error File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btPlaceStoreKey_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                tbPlaceStoreKey.Text = folderDialog.SelectedPath;
            }
        }

        private void btStart_1_Click(object sender, EventArgs e)
        {
            if (isValidKey() == false) return;

            if (rbRSA.Checked == true)
            {
                if (rbEncryption.Checked == true)
                {
                    encryptUsingRSA();
                }
                else
                {
                    decryptUsingRSA();
                }
            }

            if (rbAES.Checked)
            {
                if (rbEncryption.Checked == true)
                {
                    //
                }
                else
                {
                    //
                }
            }

            if (rbDES.Checked)
            {
                if (rbEncryption.Checked == true)
                {
                    //
                }
                else
                {
                    //
                }
            }
        }

/*MD5 Checksum*/


/*Generate Key*/
        private void rbGenRSA_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGenRSA.Checked)
            {
                tbPrimeP.Enabled = true;
                tbPrimeQ.Enabled = true;
                tbPublicE.Enabled = true;
            }
            else
            {
                tbPrimeP.Enabled = false;
                tbPrimeQ.Enabled = false;
                tbPublicE.Enabled = false;
            }
        }

        private void btGenerate_Click(object sender, EventArgs e)
        {
            if (rbGenRSA.Checked)
            {
                generateRSA();
            }
        }

        private void btStore_Click(object sender, EventArgs e)
        {
            if (rbGenRSA.Checked)
            {
                storeRSA();
            }
        }

/*********************************Handle Valid Key*******************************************************/
/*Check Key is Valid before Encrypt/Decrypt*/
        private bool isValidKey()
        {
            if (rbAES.Checked == true)
                if (!isKeyAES())
                {
                    MessageBox.Show("AES Key not Valid", "Error File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            if (rbRSA.Checked == true)
                if (!isKeyRSA())
                {
                    MessageBox.Show("RSA Key not Valid", "Error File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            if (rbDES.Checked == true)
                if (!isKeyDES())
                {
                    MessageBox.Show("DES Key not Valid", "Error File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            return true;
        }

//Check Key if it is AES Key
        private bool isKeyAES()
        {
            // Add Code Here
            return true;
        }

//Check Key if it is RSA Key
        private bool isKeyRSA()
        {
            string[] text = tbKey.Lines;
            try
            {
                for (int i = 0; i < 2; i++)
                {
                    Int64.Parse(text[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

//Check Key if it is DES Key
        private bool isKeyDES()
        {
            // Add Code Here
            return true;
        }

/*********************************Implement Algorithm*******************************************************/
//Implement RSA
        private string getFileName(string filePath)
        {
            string fileName = string.Empty;
            for (int i = filePath.Length - 1; i >= 0; i--)
            {
                if (filePath[i] == '\\')
                {
                    fileName = filePath.Substring(i + 1, filePath.Length - i - 1);
                    break;
                }
            }
            return fileName;
        }

        private void encryptUsingRSA()
        {
            //generate e & n
            string[] key = tbKey.Lines;
            decimal e = Int64.Parse(key[0]);
            decimal n = Int64.Parse(key[1]);

            //create obj RSAEncrytion to encrypt
            RSA.RSAEncryption rsa = new RSA.RSAEncryption(e, n);


            string inputFile = tbSourceFile.Text;
            string outputFile = tbOutputDirectory.Text;
            string fileName = getFileName(inputFile);

            //open file to read
            FileStream inputStream = new FileStream(inputFile, FileMode.Open, FileAccess.Read);
            int fileLength = (int)inputStream.Length;
            string[] cipherText = new string [fileLength + 1]; //first line for File Name
            cipherText[0] = fileName;

            progressBar.Maximum = (int)fileLength;
           
            //encrypt
            for (int i = 1; i <= fileLength; i++)
            {
                int data = inputStream.ReadByte();
                progressBar.Value = (int)i;
                cipherText[i] = rsa.encrypt(data).ToString();
            }

            //write to output file
            System.IO.File.WriteAllLines(outputFile, cipherText);

            //close input file
            inputStream.Close();

            //Announcement 
            MessageBox.Show("Encryption Successful", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void decryptUsingRSA()
        {
            //generate d & n
            string[] key = tbKey.Lines;
            decimal d = Int64.Parse(key[0]);
            decimal n = Int64.Parse(key[1]);

            //create obj RSAEncrytion to encrypt
            RSA.RSADecryption rsa = new RSA.RSADecryption(d, n);

            //read input to get fileName for output 
            string inputFile = tbSourceFile.Text;
            string[] cipherText = System.IO.File.ReadAllLines(inputFile);
            string fileName = cipherText[0];
            long fileLength = cipherText.Length;

            string outputFile = tbOutputDirectory.Text;
            if (outputFile[outputFile.Length - 1] != '\\')
            {
                outputFile += "\\" + fileName;
            }   
            else
            {
                outputFile += fileName;
            }

            //open file to read and write
            FileStream outputStream = new FileStream(outputFile, FileMode.OpenOrCreate, FileAccess.Write);
            byte[] data = new byte[fileLength - 1];

            progressBar.Maximum = (int)fileLength;

            //decrypt
            for (long i = 1; i < fileLength; i++)
            {
                int tempData = Int32.Parse(cipherText[i]);
                progressBar.Value = (int)i;
                data[i-1] = (byte)rsa.decrypt(tempData);
            }
            outputStream.Write(data, 0, data.Length);

            //close output file
            outputStream.Close();

            //Announcement 
            MessageBox.Show("Decryption Successful", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void generateRSA()
        {
            tbPrimeP.Text = "17";
            tbPrimeQ.Text = "31";
            tbPublicE.Text = "7";
        }

        private void storeRSA()
        {
            string publicFile = tbPlaceStoreKey.Text + PUBLIC_KEY_FILE;
            string privateFile = tbPlaceStoreKey.Text + PRIVATE_KEY_FILE;

            string[] publicKey = new string [2];
            string[] privateKey = new string[2]; 

            decimal p = Int64.Parse(tbPrimeP.Text);
            decimal q = Int64.Parse(tbPrimeQ.Text);
            decimal e = Int64.Parse(tbPublicE.Text);
            RSA.RSAGenerate rsa = new RSA.RSAGenerate(p,q,e);
            decimal d = rsa.D;
            decimal n = rsa.N;

            publicKey[0] = e.ToString();
            publicKey[1] = privateKey[1] = n.ToString();
            privateKey[0] = d.ToString();

            System.IO.File.WriteAllLines(publicFile, publicKey);
            System.IO.File.WriteAllLines(privateFile, privateKey);
        }
    }
}

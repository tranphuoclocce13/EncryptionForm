using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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
            keyLength.SelectedIndex = 0;
            keyLengthGenAES.SelectedIndex = 0;
        }

/*********************************Handle Event*******************************************************/
/*Encrypt/Decrypt*/
        private void rbAES_CheckedChanged(object sender, EventArgs e)
        {
            enableOperation();
            if (rbAES.Checked)
                keyLength.Enabled = true;
            else
                keyLength.Enabled = false;
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
                    string outputFile = folderDialog.SelectedPath;

                    if (outputFile[outputFile.Length - 1] != '\\')
                    {
                        outputFile += "\\" + CIPHER_TEXT_FILE;
                    }
                    else
                    {
                        outputFile += CIPHER_TEXT_FILE;
                    }
                    tbOutputDirectory.Text = outputFile;
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
                string filePath = folderDialog.SelectedPath;
                if (filePath[filePath.Length - 1] != '\\')
                {
                    filePath += "\\";
                }
                tbPlaceStoreKey.Text = filePath;
            }
        }

        private void btStart_1_Click(object sender, EventArgs e)
        {
            if (isValidKey() == false) return;

            if (isValidAddress() == false) return;

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
                int keyMode = keyLength.SelectedIndex;
                String key = tbKey.Text;
                byte[] keybyte = new byte[16];
                //keybyte= (key, 16);
               // AES = new AES (keyLength.SelectedIndex)

                if (rbEncryption.Checked == true)
                {
                    encryptUsingAES();
                }
                else
                {
                    decryptUsingAES();
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
        private static byte[] ToByteArray(String HexString)
        {
            int NumberChars = HexString.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(HexString.Substring(i, 2), 16);
            }
            return bytes;
        }
/*MD5 Checksum*/

        private void rbGetMD5_CheckedChanged(object sender, EventArgs e)
        {
            tbGetMD5.Enabled = true;
            btGetMD5.Enabled = true;
            tbMD5Checksum.Enabled = true;
            btCopyMD5.Enabled = true;
    
            if (rbGetMD5.Checked)
            {
                tbCompare.Enabled = false;
            }
        }

        private void rbVerify_CheckedChanged(object sender, EventArgs e)
        {
            tbCompare.Text = string.Empty;
            tbGetMD5.Text = string.Empty;
            tbMD5Checksum.Text = string.Empty;

            if (rbVerify.Checked)
            {
                tbCompare.Enabled = true;
            }
        }

        private void btCopyMD5_Click(object sender, EventArgs e)
        {
            if (tbMD5Checksum.Text != "")
            {
                Clipboard.SetText(tbMD5Checksum.Text);
                MessageBox.Show("MD5 has been copied to clipboard", "Copy Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
        }

        private void btGetMD5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                tbGetMD5.Text  = openDialog.FileName;
            }
        }

        private void btStart_2_Click(object sender, EventArgs e)
        {
            string fileName = tbGetMD5.Text;
            string md5String = string.Empty;
            byte[] data;
            try
            {
                using (var md5 = MD5.Create())
                {
                    using (var stream = File.OpenRead(fileName))
                    {
                        data = md5.ComputeHash(stream);
                        md5String = BitConverter.ToString(data);
                        md5String = md5String.Replace("-", "");
                    }
                }
                tbMD5Checksum.Text = md5String;

                if (rbVerify.Checked)
                {
                    if (md5String == tbCompare.Text)
                    {
                        MessageBox.Show("Correct MD5", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Wrong MD5", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Cannot Create MD5 for this file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

/*Generate Key*/
        private void rbGenRSA_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGenRSA.Checked)
            {
                tbPrimeP.Enabled = true;
                tbPrimeQ.Enabled = true;
                tbPublicE.Enabled = true;
                tbRange.Enabled = true;
            }
            else
            {
                tbPrimeP.Enabled = false;
                tbPrimeQ.Enabled = false;
                tbPublicE.Enabled = false;
                tbRange.Enabled = false;
            }
            btGenerate.Enabled = true;
        }

        private void rbGenDES_CheckedChanged(object sender, EventArgs e)
        {
            //Add code here
            if (rbGenDES.Checked)
            {
                tbGenDES.Enabled = true;
            }
            else
            {
                tbGenDES.Enabled = false;
            }
            btGenerate.Enabled = true;
        }

        private void rbGenAES_CheckedChanged(object sender, EventArgs e)
        {
            //Add code here
            if (rbGenAES.Checked)
            {
                tbGenAES.Enabled = true;
                keyLengthGenAES.Enabled = true;
                tbPsw.Enabled = true;
            }
            else
            {
                tbGenAES.Enabled = false;
                keyLengthGenAES.Enabled = false;
                tbPsw.Enabled = false;
            }
            btGenerate.Enabled = true;
        }

        private void btGenerate_Click(object sender, EventArgs e)
        {
            if (rbGenRSA.Checked)
            {
                generateRSA();
            }
            if (rbGenAES.Checked)
            {
                generateAES();
                //Add code here
            }
            if (rbGenDES.Checked)
            {
                //Add code here
            }
            btStore.Enabled = true;
        }

        private void btStore_Click(object sender, EventArgs e)
        {
            if (rbGenRSA.Checked)
            {
                storeRSA();  
            }
            if (rbGenAES.Checked)
            {
                //Add code here
            }
            if (rbGenDES.Checked)
            {
                //Add code here
            }
        }

/*********************************Handle Valid Key*******************************************************/
/*Check Key is Valid before Encrypt/Decrypt*/
        private bool isValidAddress()
        {
            if (tbOutputDirectory.Text == string.Empty || tbSourceFile.Text == string.Empty)
            {
                MessageBox.Show("Directory not set", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

        }
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
            String key = tbKey.Text;
            if (keyLength.SelectedIndex == 0 && key.Length != 32 ||
                keyLength.SelectedIndex == 1 && key.Length != 48 ||
                keyLength.SelectedIndex == 2 && key.Length != 64)
                return false;
            for (int i = 0; i < key.Length; i++)
                if (key[i] < 48 || (key[i] > 57 && key[i] < 65) || (key[i] > 70 && key[i] < 97) || key[i] > 102)
                    return false;
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
            int e = Int32.Parse(key[0]);
            int n = Int32.Parse(key[1]);

            //create obj RSAEncrytion to encrypt
            RSA.RSAEncryption rsa = new RSA.RSAEncryption(e, n);

            int temp = n;
            int block = 0;

            while (temp > 200)
            {
                block += 1;
                temp /= 1000;
            }

            string inputFile = tbSourceFile.Text;
            string outputFile = tbOutputDirectory.Text;
            string fileName = getFileName(inputFile);

            //open file to read
            FileStream inputStream = new FileStream(inputFile, FileMode.Open, FileAccess.Read);
            
            int inputFileLength = (int)inputStream.Length;
            int outputFileLength = inputFileLength / block + 1; // +1 for file name line
            if (inputFileLength % block != 0) outputFileLength += 1; // +1 for redundant data

            string[] cipherText = new string[outputFileLength];
            cipherText[0] = fileName;

            progressBar.Maximum = outputFileLength;
           
            //encrypt
            temp = block;
            byte[] readData = new byte[block];
            int readSize = block;
            int blockData = 0;
            for (int i = 1; i < outputFileLength; i++)
            {
                Array.Clear(readData, 0, block);
                if (inputFileLength < readSize) readSize = inputFileLength;
                inputStream.Read(readData, 0, readSize);

                blockData = 0;
                for (int j = 0; j < block; j++)
                {
                    blockData = blockData * 1000 + readData[j];
                }

                cipherText[i] = rsa.encrypt(blockData).ToString();
                progressBar.Value = i;
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
            int d = Int32.Parse(key[0]);
            int n = Int32.Parse(key[1]);

            //create obj RSAEncrytion to encrypt
            RSA.RSADecryption rsa = new RSA.RSADecryption(d, n);

            int temp = n;
            int block = 0;

            while (temp > 200)
            {
                block += 1;
                temp /= 1000;
            }

            //read input to get fileName for output 
            string inputFile = tbSourceFile.Text;
            string[] cipherText = System.IO.File.ReadAllLines(inputFile);
            string fileName = cipherText[0];

            int intputFileLength = cipherText.Length;
            int outputFileLength = (intputFileLength - 1) * block; // subtract line filename 

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
            byte[] data = new byte[outputFileLength];

            progressBar.Maximum = intputFileLength;

            //decrypt
            int counter = 0;
            int readData = 0;
            int writeData = 0;
            temp = block;
            for (int i = 1; i < intputFileLength; i++)
            {
                readData = Int32.Parse(cipherText[i]);
                readData = rsa.decrypt(readData);

                while (readData > 0)
                {
                    temp -= 1;
                    writeData = readData % 1000;
                    if (writeData == 0) outputFileLength = counter + temp;
                    data[counter + temp] = (byte) (writeData); 
                    readData /= 1000;   
                }
                temp = block;
                counter += block;

                progressBar.Value = i;
            }
            outputStream.Write(data, 0, outputFileLength);

            //close output file
            outputStream.Close();

            //Announcement 
            MessageBox.Show("Decryption Successful", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool isPrime(int num)
        {
            if (num % 2 == 0) return false;
            if (num % 3 == 0) return false;
            
            int n = (int) Math.Sqrt(num);
            for (int i = 5; i <= n; i += 6)
            {
                if (num % i == 0 || num % (i + 2) == 0)
                    return false;
            }
                
            return true;
        }

        private void generateRSA()
        {
            try
            {
                int beginNum = 100;
                if (tbRange.Text != "")
                    beginNum = Int32.Parse(tbRange.Text);
                int endNum = (beginNum < 100) ? 200 : beginNum * 2; 

                Random random = new Random();

                int p, q;

                while (true)
                {
                    p = random.Next(beginNum, endNum);
                    if (isPrime(p)) break;
                }

                q = p + 2;
                while (true)
                {
                    if (isPrime(q)) break;
                    q += 2;
                }

                int e = 17;
                if ((p - 1) * (q - 1) > 65537) e = 65537;

            tbPrimeP.Text = p.ToString();
            tbPrimeQ.Text = q.ToString();
            tbPublicE.Text = e.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void storeRSA()
        {
            string filePath = tbPlaceStoreKey.Text;
            if (filePath == string.Empty)
            {
                MessageBox.Show("Store key fail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string publicFile = filePath + PUBLIC_KEY_FILE;
            string privateFile = filePath + PRIVATE_KEY_FILE;

            string[] publicKey = new string [2];
            string[] privateKey = new string[2]; 

            decimal p = Int64.Parse(tbPrimeP.Text);
            decimal q = Int64.Parse(tbPrimeQ.Text);
            decimal e = Int64.Parse(tbPublicE.Text);
            RSA.RSAGenerate rsa = new RSA.RSAGenerate(p,q,e);
            decimal d = rsa.D;
            decimal n = rsa.N;

            if (d == 0 || n < 256)
            {
                MessageBox.Show("Invalid key, please generate the other", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            publicKey[0] = e.ToString();
            publicKey[1] = privateKey[1] = n.ToString();
            privateKey[0] = d.ToString();

            System.IO.File.WriteAllLines(publicFile, publicKey);
            System.IO.File.WriteAllLines(privateFile, privateKey);

            MessageBox.Show("Store key Successful", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
//Implement RSA
        private void encryptUsingAES()
        {
            int keyMode = keyLength.SelectedIndex;
            String keyInStr = tbKey.Text;
            byte[] keyInByte = ToByteArray(keyInStr);

            AES Aes = new AES(keyMode, keyInByte);

            string inputFile = tbSourceFile.Text;
            string outputFile = tbOutputDirectory.Text;
            string fileName = getFileName(inputFile);

            //open file to read
            FileStream inputStream = new FileStream(inputFile, FileMode.Open, FileAccess.Read);
            int fileLength = (int)inputStream.Length;
            String[] cipherText; 
            byte[] plainTextBlock = new byte[16];
            byte[] cipherTextBlock = new byte[16];
            if ((fileLength) % 16 != 0)
                cipherText = new String[16 * ((fileLength / 16) + 1) + 2];
            else
                cipherText = new String[fileLength + 2];

            cipherText[0] = fileName; /*first line for File Name*/
            cipherText[1] = Convert.ToString(fileLength);
            progressBar.Maximum = cipherText.Length - 16;

            //encrypt
            for (int i = 2; i < cipherText.Length; i+=16)
            {
                Array.Clear(plainTextBlock, 0, plainTextBlock.Length);
                inputStream.Read(plainTextBlock, 0, 16);
                cipherTextBlock = Aes.encyptOneBLock(plainTextBlock);
                for (int j = 0; j < 16; j++)
                    cipherText[i + j] = cipherTextBlock[j].ToString();
                progressBar.Value = i;
            }
            //write to output file
            System.IO.File.WriteAllLines(outputFile, cipherText);

            //close input file
            inputStream.Close();

            //Announcement 
            MessageBox.Show("Encryption Successful", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void decryptUsingAES()
        {
            int keyMode = keyLength.SelectedIndex;
            String keyInStr = tbKey.Text;
            byte[] keyInByte = ToByteArray(keyInStr);

            AES Aes = new AES(keyMode, keyInByte);

            string inputFile = tbSourceFile.Text;
            string[] cipherText = System.IO.File.ReadAllLines(inputFile);
            byte[] plainTextBlock = new byte[16];
            byte[] cipherTextBlock = new byte[16];
            string fileName = cipherText[0];
            int fileSize = Int32.Parse(cipherText[1]);
            int fileLength = cipherText.Length;

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
            byte[] plainText = new byte[fileLength - 2];

            progressBar.Maximum = fileLength - 16;

            //decrypt
            for (int i = 2; i < fileLength; i+=16)
            {
                for (int j = 0; j < 16; j++)
                    cipherTextBlock[j] = Convert.ToByte(cipherText[i + j], 10);
                plainTextBlock = Aes.decyptOneBLock(cipherTextBlock);
                for (int j = 0; j < 16; j++)
                    plainText[i + j - 2] = plainTextBlock[j];
                progressBar.Value = i;
            }

            outputStream.Write(plainText, 0, fileSize);

            //close output file
            outputStream.Close();

            //Announcement 
            MessageBox.Show("Decryption Successful", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void generateAES()
        {
            String password = tbPsw.Text;
            if (password == "")
            {
                MessageBox.Show("Please enter password to generate key", "Empty password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int keyLength = 0;
            switch (keyLengthGenAES.SelectedIndex)
            {
                case 0: keyLength = 128; break;
                case 1: keyLength = 192; break;
                case 2: keyLength = 256; break;
                default: break;
            }
            byte[] key = genKey(password, keyLength);
            tbGenAES.Text = BitConverter.ToString(key).Replace("-","");
            tbGenDES.Text = BitConverter.ToString(key).Replace("-", "");
        }
        private byte[] genKey(string password, int keyBytes)
        {
            const int Iterations = 300;
            var keyGenerator = new Rfc2898DeriveBytes(password, Salt, Iterations);
            return keyGenerator.GetBytes(keyBytes);
        }
        private static readonly byte[] Salt = new byte[] { 10, 20, 30, 40, 50, 60, 70, 80 };
    }
}

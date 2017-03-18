using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptionForm
{
    public partial class EDForm : Form
    {
        public EDForm()
        {
            InitializeComponent();
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
                tbOutputDirectory.Text = folderDialog.SelectedPath;
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

/*Check Key is Valid before Encrypt/Decrypt*/
        private bool isValidKey(string key)
        {
            if (rbAES.Checked == true)
                if (!isKeyAES(key))
                {
                    MessageBox.Show("AES Key not Valid", "Error File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            if (rbRSA.Checked == true)
                if (!isKeyRSA(key))
                {
                    MessageBox.Show("RSA Key not Valid", "Error File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            if (rbDES.Checked == true)
                if (!isKeyDES(key))
                {
                    MessageBox.Show("DES Key not Valid", "Error File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            return true;
        }

        private bool isKeyAES(string text)
        {
            // Add Code Here
            return true;
        }

        private bool isKeyRSA(string text)
        {
            // Add Code Here
            return true;
        }

        private bool isKeyDES(string text)
        {
            // Add Code Here
            return true;
        }

        private void enableKeyInput()
        {
            if (tbKey.Enabled == false)
            {
                tbKey.Enabled = true;
                btChooseKey.Enabled = true;
            }
        }

        private void rbDES_CheckedChanged(object sender, EventArgs e)
        {
            enableKeyInput();
        }

        private void rbRSA_CheckedChanged(object sender, EventArgs e)
        {
            enableKeyInput();
        }

        private void rbAES_CheckedChanged(object sender, EventArgs e)
        {
            enableKeyInput();
        }

/*Encrypt Click*/
        private void btEncrypt_Click(object sender, EventArgs e)
        {
            string key = tbKey.Text;
            if (!isValidKey(key)) return;
        }

/*Decrypt Click*/
        private void btDecrypt_Click(object sender, EventArgs e)
        {
            string key = tbKey.Text;
            if (!isValidKey(key)) return;
        }

        private void tbKey_TextChanged(object sender, EventArgs e)
        {
            if (tbKey.Text == "")
            {
                btEncrypt.Enabled = false;
                btDecrypt.Enabled = false;
            }
            else
            {
                btEncrypt.Enabled = true;
                btDecrypt.Enabled = true;
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DES;
using AES;
using NDes;
using System.IO;
using System.Diagnostics;

namespace cs544
{
    public partial class BlockCipher : Form
    {
        public BlockCipher()
        {
            InitializeComponent();
        }
        byte[] encryptBytes;
        private void Encrypt_Click(object sender, EventArgs e)
        {
            if (DES.Checked == false && AES.Checked == false && test.Checked == false) {
                MessageBox.Show("You must choose a cipher method!", "Oops!", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            }
            else if (key.Text == null)
            {
                MessageBox.Show("You must enter the encryption key!", "Oops!", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            }
            else {
                if (plaintext.Text == null)
                {
                    MessageBox.Show("Please enter the text need to be encrypt.", "Tips", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                }
                else {
                    if (DES.Checked == true) {
                    
                    ciphertext1.Text = DEScipher.Encrypt(plaintext.Text, key.Text);
                    }else if (AES.Checked == true)
                    {
                        encryptBytes = AEScipher.AESEncrypt(plaintext.Text, key.Text);
                        ciphertext1.Text = Convert.ToBase64String(encryptBytes);
                    }
                    else if ((test.Checked == true) && (m != null)&&(int.Parse(m.Text.ToString())>=3)) {
                        string cipherresult_ndes = NDes.NDes.NDESEncrypt(plaintext.Text, key.Text, m.Text);
                        ciphertext1.Text = cipherresult_ndes;
                    }
                } 
            }
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            if (DES.Checked == false && AES.Checked == false && test.Checked == false)
            {
                MessageBox.Show("You must choose a cipher method!", "Oops!", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            }
            else if (key.Text == null)
            {
                MessageBox.Show("You must enter decryption key!", "Oops!", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            }
            else
            {
                if (ciphertext.Text == null)
                {
                    MessageBox.Show("Please enter the text need to be decrypt.", "Tips", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                }
                else
                {
                    if (DES.Checked == true)
                    {

                        plaintext1.Text = DEScipher.Decrypt(ciphertext.Text, key.Text);
                    }
                    else if (AES.Checked == true)
                    {
                        //byte[] encryptB = Encoding.UTF8.GetBytes(ciphertext1.ToString());
                        byte[] decryptBytes = AEScipher.AESDecrypt(encryptBytes, key.Text);
                        plaintext1.Text = Encoding.UTF8.GetString(decryptBytes);
                    }
                    else if ((test.Checked == true) && (m != null) && (int.Parse(m.Text.ToString()) >= 3)) {
                        string decipherresult_ndes = NDes.NDes.NDESDecrypt(ciphertext.Text, key.Text, m.Text);
                        plaintext1.Text = decipherresult_ndes;
                    }
                }
            }
        }

        private void view1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendlg = new OpenFileDialog();
            opendlg.Title = "Open Files";
            opendlg.Filter = "Text File(*.txt)|*.txt";
            //opendlg.InitialDirectory = 
            opendlg.RestoreDirectory = true;
            if (opendlg.ShowDialog() == DialogResult.OK)
            {
                find.Text = opendlg.FileName;
                System.IO.FileInfo file = new System.IO.FileInfo(find.Text);
                string str = file.Length.ToString();
                double inta = double.Parse(str)/(1024*1024);
                load.Text = inta.ToString("0.000") + "MB";
            }
        }

        private void view2_Click(object sender, EventArgs e)
        {
            SaveFileDialog savedlg = new SaveFileDialog();
            savedlg.Title = "Save as";
            savedlg.Filter = "Text File(*.txt)|*.txt";
            //savedlg.InitialDirectory = 
            savedlg.RestoreDirectory = true;
            if (savedlg.ShowDialog() == DialogResult.OK)
            {
                save.Text = savedlg.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileresult = "";
            FileStream myStream = new FileStream(find.Text, FileMode.Open, FileAccess.Read);         //打开文件，把文件读取到string变量
            StreamReader myStreamReader = new StreamReader(find.Text, System.Text.Encoding.Default);
            string fileContent;
            fileContent = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            if (find.Text.Trim() != string.Empty)
            {

                if (key.Text.Trim() != string.Empty)
                {
                    Stopwatch stopwatch = new Stopwatch();
                    TimeSpan timespan;
                    double milliseconds;
                    stopwatch.Start(); //  开始监视代码运行时间
                    if (DES.Checked == true)
                    {

                        fileresult = DEScipher.Encrypt(fileContent, key.Text);

                    }
                    else if (AES.Checked == true)
                    {
                        encryptBytes = AEScipher.AESEncrypt(fileContent, key.Text);
                        fileresult = Convert.ToBase64String(encryptBytes);
                    }
                    else if ((test.Checked==true)&&(m.Text.Trim()!=string.Empty)&&(int.Parse(m.Text)>=3))
                    {
                        fileresult = NDes.NDes.NDESEncrypt(fileContent, key.Text, m.Text);
                    }
                    stopwatch.Stop();
                    timespan = stopwatch.Elapsed;
                    milliseconds = timespan.TotalMilliseconds/1000;  //  总毫秒数
                    time.Text = milliseconds.ToString()+"sec";
                }
                else
                {
                    MessageBox.Show(this, "Please Input the Key！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(this, "Please choose the file to be encrypt！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FileStream myStreamr = new FileStream(save.Text, FileMode.Create, FileAccess.Write);       //创建一个文件，把字符串写入文件
            StreamWriter myStreamWriter = new StreamWriter(myStreamr);
            myStreamWriter.Write(fileresult);
            myStreamWriter.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fileresult = "";
            FileStream myStream = new FileStream(find.Text, FileMode.Open, FileAccess.Read);         //打开文件，把文件读取到string变量
            StreamReader myStreamReader = new StreamReader(find.Text, System.Text.Encoding.Default);
            string fileContent;
            fileContent = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            if (find.Text.Trim() != string.Empty)
            {
                if (key.Text.Trim() != string.Empty)
                {
                    if (DES.Checked == true)
                    {
                        fileresult = DEScipher.Decrypt(fileContent, key.Text);
                    }
                    else if (AES.Checked == true)
                    {
                        //byte[] encryptB = Encoding.UTF8.GetBytes(ciphertext1.ToString());
                        byte[] decryptBytes = AEScipher.AESDecrypt(encryptBytes, key.Text);
                        fileresult = Encoding.UTF8.GetString(decryptBytes);
                    }
                    else if ((test.Checked == true) && (m.Text.Trim() != string.Empty)&&(int.Parse(m.Text)>=3))
                    {
                        fileresult = NDes.NDes.NDESDecrypt(fileContent, key.Text, m.Text);
                    }
                }
                else
                {
                    MessageBox.Show(this, "Please Input the Key！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(this, "Please choose the file to be decrypt！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FileStream myStreamr = new FileStream(save.Text, FileMode.Create, FileAccess.Write);       //创建一个文件，把字符串写入文件
            StreamWriter myStreamWriter = new StreamWriter(myStreamr);
            myStreamWriter.Write(fileresult);
            myStreamWriter.Close();
        }

        /*private void button3_Click(object sender, EventArgs e)
        {
            /*string strResult = string.Empty;
           string subkey1 = NDes.NDes.leftmovekey(key.Text, 1);
            string result1 = DEScipher.Encrypt(plaintext.Text, subkey1);
            string subkey2 = NDes.NDes.rightmovekey(key.Text, 3);
            string result2 = DEScipher.Encrypt(result1, subkey2);
            string subkey3 = NDes.NDes.leftmovekey(key.Text, 1);
            string result3 = DEScipher.Encrypt(result2, subkey3);
            textBox3.Text = result3;
           string result4 = DEScipher.Decrypt(result3, subkey3);
           string result5 = DEScipher.Decrypt(result4, subkey2);
           string result6 = DEScipher.Decrypt(result5, subkey1);
            textBox2.Text = result6;
        }*/

        private void test_CheckedChanged(object sender, EventArgs e)
        {
            if(test.Checked==true)
            m.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string msgquit;
            msgquit = "Close the program?";
            DialogResult quitresult = MessageBox.Show(this, msgquit, "Tip", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (quitresult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string msgabout;
            msgabout = "CS 544 Project: \nExploring BlockCiphers" + "\n\n" + "Implemented by Ruoxi Chen, A20284330";
            DialogResult aboutresult = MessageBox.Show(this, msgabout, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

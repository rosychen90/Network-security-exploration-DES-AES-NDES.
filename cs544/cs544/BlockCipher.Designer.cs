namespace cs544
{
    partial class BlockCipher
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.test = new System.Windows.Forms.RadioButton();
            this.AES = new System.Windows.Forms.RadioButton();
            this.DES = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.key = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.plaintext1 = new System.Windows.Forms.TextBox();
            this.ciphertext1 = new System.Windows.Forms.TextBox();
            this.Decrypt = new System.Windows.Forms.Button();
            this.Encrypt = new System.Windows.Forms.Button();
            this.ciphertext = new System.Windows.Forms.TextBox();
            this.plaintext = new System.Windows.Forms.TextBox();
            this.load = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.m = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.save = new System.Windows.Forms.ComboBox();
            this.find = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.view2 = new System.Windows.Forms.Button();
            this.view1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.test);
            this.groupBox1.Controls.Add(this.AES);
            this.groupBox1.Controls.Add(this.DES);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cipher Selection";
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Location = new System.Drawing.Point(387, 20);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(53, 16);
            this.test.TabIndex = 2;
            this.test.TabStop = true;
            this.test.Text = "N-Des";
            this.test.UseVisualStyleBackColor = true;
            this.test.CheckedChanged += new System.EventHandler(this.test_CheckedChanged);
            // 
            // AES
            // 
            this.AES.AutoSize = true;
            this.AES.Location = new System.Drawing.Point(203, 20);
            this.AES.Name = "AES";
            this.AES.Size = new System.Drawing.Size(41, 16);
            this.AES.TabIndex = 1;
            this.AES.TabStop = true;
            this.AES.Text = "AES";
            this.AES.UseVisualStyleBackColor = true;
            // 
            // DES
            // 
            this.DES.AutoSize = true;
            this.DES.Location = new System.Drawing.Point(17, 20);
            this.DES.Name = "DES";
            this.DES.Size = new System.Drawing.Size(41, 16);
            this.DES.TabIndex = 0;
            this.DES.TabStop = true;
            this.DES.Text = "DES";
            this.DES.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Key:";
            // 
            // key
            // 
            this.key.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.key.Location = new System.Drawing.Point(72, 20);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(108, 21);
            this.key.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.plaintext1);
            this.groupBox2.Controls.Add(this.ciphertext1);
            this.groupBox2.Controls.Add(this.Decrypt);
            this.groupBox2.Controls.Add(this.Encrypt);
            this.groupBox2.Controls.Add(this.ciphertext);
            this.groupBox2.Controls.Add(this.plaintext);
            this.groupBox2.Location = new System.Drawing.Point(12, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 102);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TEXT";
            // 
            // plaintext1
            // 
            this.plaintext1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plaintext1.Location = new System.Drawing.Point(286, 61);
            this.plaintext1.Name = "plaintext1";
            this.plaintext1.Size = new System.Drawing.Size(151, 21);
            this.plaintext1.TabIndex = 5;
            // 
            // ciphertext1
            // 
            this.ciphertext1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ciphertext1.Location = new System.Drawing.Point(286, 18);
            this.ciphertext1.Name = "ciphertext1";
            this.ciphertext1.Size = new System.Drawing.Size(153, 21);
            this.ciphertext1.TabIndex = 4;
            // 
            // Decrypt
            // 
            this.Decrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Decrypt.Location = new System.Drawing.Point(176, 61);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(75, 23);
            this.Decrypt.TabIndex = 3;
            this.Decrypt.Text = "Decrypt->";
            this.Decrypt.UseVisualStyleBackColor = true;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // Encrypt
            // 
            this.Encrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Encrypt.Location = new System.Drawing.Point(176, 18);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(75, 23);
            this.Encrypt.TabIndex = 2;
            this.Encrypt.Text = "Encrypt->";
            this.Encrypt.UseVisualStyleBackColor = true;
            this.Encrypt.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // ciphertext
            // 
            this.ciphertext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ciphertext.Location = new System.Drawing.Point(6, 61);
            this.ciphertext.Name = "ciphertext";
            this.ciphertext.Size = new System.Drawing.Size(142, 21);
            this.ciphertext.TabIndex = 1;
            // 
            // plaintext
            // 
            this.plaintext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plaintext.Location = new System.Drawing.Point(6, 20);
            this.plaintext.Name = "plaintext";
            this.plaintext.Size = new System.Drawing.Size(142, 21);
            this.plaintext.TabIndex = 0;
            // 
            // load
            // 
            this.load.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.load.Location = new System.Drawing.Point(91, 19);
            this.load.Name = "load";
            this.load.ReadOnly = true;
            this.load.Size = new System.Drawing.Size(89, 21);
            this.load.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Load:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Time:";
            // 
            // time
            // 
            this.time.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.time.Location = new System.Drawing.Point(91, 48);
            this.time.Name = "time";
            this.time.ReadOnly = true;
            this.time.Size = new System.Drawing.Size(100, 21);
            this.time.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "Iteration Time:";
            // 
            // m
            // 
            this.m.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m.Enabled = false;
            this.m.Location = new System.Drawing.Point(124, 47);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(56, 21);
            this.m.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.load);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.time);
            this.groupBox3.Location = new System.Drawing.Point(271, 71);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 81);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "BenchMark";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.key);
            this.groupBox4.Controls.Add(this.m);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(15, 71);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 81);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "User Input";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.save);
            this.groupBox5.Controls.Add(this.find);
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.view2);
            this.groupBox5.Controls.Add(this.view1);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(12, 266);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(459, 108);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "FILE";
            // 
            // save
            // 
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.FormattingEnabled = true;
            this.save.Location = new System.Drawing.Point(103, 48);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(260, 20);
            this.save.TabIndex = 9;
            // 
            // find
            // 
            this.find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.find.FormattingEnabled = true;
            this.find.Location = new System.Drawing.Point(104, 20);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(260, 20);
            this.find.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(247, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Decryption";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(127, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Encryption";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // view2
            // 
            this.view2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view2.Location = new System.Drawing.Point(370, 46);
            this.view2.Name = "view2";
            this.view2.Size = new System.Drawing.Size(75, 23);
            this.view2.TabIndex = 5;
            this.view2.Text = "View";
            this.view2.UseVisualStyleBackColor = true;
            this.view2.Click += new System.EventHandler(this.view2_Click);
            // 
            // view1
            // 
            this.view1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view1.Location = new System.Drawing.Point(370, 18);
            this.view1.Name = "view1";
            this.view1.Size = new System.Drawing.Size(75, 23);
            this.view1.TabIndex = 4;
            this.view1.Text = "View";
            this.view1.UseVisualStyleBackColor = true;
            this.view1.Click += new System.EventHandler(this.view1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "Save As:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "Original File:";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(491, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(491, 71);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "About";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // BlockCipher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 382);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "BlockCipher";
            this.Text = "BlockCipher";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton test;
        private System.Windows.Forms.RadioButton AES;
        private System.Windows.Forms.RadioButton DES;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox key;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Decrypt;
        private System.Windows.Forms.Button Encrypt;
        private System.Windows.Forms.TextBox ciphertext;
        private System.Windows.Forms.TextBox plaintext;
        private System.Windows.Forms.TextBox load;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox m;
        private System.Windows.Forms.TextBox plaintext1;
        private System.Windows.Forms.TextBox ciphertext1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button view2;
        private System.Windows.Forms.Button view1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox save;
        private System.Windows.Forms.ComboBox find;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}


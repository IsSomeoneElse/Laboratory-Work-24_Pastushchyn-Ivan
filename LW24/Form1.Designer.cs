namespace LW24
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.firstThreadStart = new System.Windows.Forms.Button();
            this.secondThreadStart = new System.Windows.Forms.Button();
            this.thirdThreadStart = new System.Windows.Forms.Button();
            this.allThreadStart = new System.Windows.Forms.Button();
            this.firstThreadStop = new System.Windows.Forms.Button();
            this.secondThreadStop = new System.Windows.Forms.Button();
            this.thirdThreadStop = new System.Windows.Forms.Button();
            this.allThreadStop = new System.Windows.Forms.Button();
            this.randomNumberTextBox = new System.Windows.Forms.RichTextBox();
            this.plainTextBox1 = new System.Windows.Forms.RichTextBox();
            this.plainTextBox3 = new System.Windows.Forms.RichTextBox();
            this.plainTextBox2 = new System.Windows.Forms.RichTextBox();
            this.RunButton = new System.Windows.Forms.Button();
            this.encryptedTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.encryptedTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.encryptedTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 425);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.randomNumberTextBox);
            this.tabPage1.Controls.Add(this.allThreadStop);
            this.tabPage1.Controls.Add(this.thirdThreadStop);
            this.tabPage1.Controls.Add(this.secondThreadStop);
            this.tabPage1.Controls.Add(this.firstThreadStop);
            this.tabPage1.Controls.Add(this.allThreadStart);
            this.tabPage1.Controls.Add(this.thirdThreadStart);
            this.tabPage1.Controls.Add(this.secondThreadStart);
            this.tabPage1.Controls.Add(this.firstThreadStart);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 399);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Завдання 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.encryptedTextBox3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.encryptedTextBox2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.encryptedTextBox1);
            this.tabPage2.Controls.Add(this.RunButton);
            this.tabPage2.Controls.Add(this.plainTextBox2);
            this.tabPage2.Controls.Add(this.plainTextBox3);
            this.tabPage2.Controls.Add(this.plainTextBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 399);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Завдання 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 200);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(282, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 200);
            this.panel2.TabIndex = 1;
            // 
            // firstThreadStart
            // 
            this.firstThreadStart.Location = new System.Drawing.Point(6, 226);
            this.firstThreadStart.Name = "firstThreadStart";
            this.firstThreadStart.Size = new System.Drawing.Size(200, 22);
            this.firstThreadStart.TabIndex = 2;
            this.firstThreadStart.Text = "Запустити 1 поток";
            this.firstThreadStart.UseVisualStyleBackColor = true;
            this.firstThreadStart.Click += new System.EventHandler(this.firstThreadStart_Click);
            // 
            // secondThreadStart
            // 
            this.secondThreadStart.Location = new System.Drawing.Point(282, 226);
            this.secondThreadStart.Name = "secondThreadStart";
            this.secondThreadStart.Size = new System.Drawing.Size(200, 22);
            this.secondThreadStart.TabIndex = 3;
            this.secondThreadStart.Text = "Запустити 2 поток";
            this.secondThreadStart.UseVisualStyleBackColor = true;
            this.secondThreadStart.Click += new System.EventHandler(this.secondThreadStart_Click);
            // 
            // thirdThreadStart
            // 
            this.thirdThreadStart.Location = new System.Drawing.Point(561, 226);
            this.thirdThreadStart.Name = "thirdThreadStart";
            this.thirdThreadStart.Size = new System.Drawing.Size(200, 22);
            this.thirdThreadStart.TabIndex = 4;
            this.thirdThreadStart.Text = "Запустити 3 поток";
            this.thirdThreadStart.UseVisualStyleBackColor = true;
            this.thirdThreadStart.Click += new System.EventHandler(this.thirdThreadStart_Click);
            // 
            // allThreadStart
            // 
            this.allThreadStart.Location = new System.Drawing.Point(6, 324);
            this.allThreadStart.Name = "allThreadStart";
            this.allThreadStart.Size = new System.Drawing.Size(755, 22);
            this.allThreadStart.TabIndex = 5;
            this.allThreadStart.Text = "Запустити всі потоки";
            this.allThreadStart.UseVisualStyleBackColor = true;
            this.allThreadStart.Click += new System.EventHandler(this.allThreadStart_Click);
            // 
            // firstThreadStop
            // 
            this.firstThreadStop.ForeColor = System.Drawing.Color.Red;
            this.firstThreadStop.Location = new System.Drawing.Point(6, 254);
            this.firstThreadStop.Name = "firstThreadStop";
            this.firstThreadStop.Size = new System.Drawing.Size(200, 22);
            this.firstThreadStop.TabIndex = 6;
            this.firstThreadStop.Text = "Зупинити 1 поток";
            this.firstThreadStop.UseVisualStyleBackColor = true;
            this.firstThreadStop.Click += new System.EventHandler(this.firstThreadStop_Click);
            // 
            // secondThreadStop
            // 
            this.secondThreadStop.ForeColor = System.Drawing.Color.Red;
            this.secondThreadStop.Location = new System.Drawing.Point(282, 254);
            this.secondThreadStop.Name = "secondThreadStop";
            this.secondThreadStop.Size = new System.Drawing.Size(200, 22);
            this.secondThreadStop.TabIndex = 7;
            this.secondThreadStop.Text = "Зупинити 2 поток";
            this.secondThreadStop.UseVisualStyleBackColor = true;
            this.secondThreadStop.Click += new System.EventHandler(this.secondThreadStop_Click);
            // 
            // thirdThreadStop
            // 
            this.thirdThreadStop.ForeColor = System.Drawing.Color.Red;
            this.thirdThreadStop.Location = new System.Drawing.Point(561, 254);
            this.thirdThreadStop.Name = "thirdThreadStop";
            this.thirdThreadStop.Size = new System.Drawing.Size(200, 22);
            this.thirdThreadStop.TabIndex = 8;
            this.thirdThreadStop.Text = "Зупинити 3 поток";
            this.thirdThreadStop.UseVisualStyleBackColor = true;
            this.thirdThreadStop.Click += new System.EventHandler(this.thirdThreadStop_Click);
            // 
            // allThreadStop
            // 
            this.allThreadStop.ForeColor = System.Drawing.Color.Red;
            this.allThreadStop.Location = new System.Drawing.Point(6, 352);
            this.allThreadStop.Name = "allThreadStop";
            this.allThreadStop.Size = new System.Drawing.Size(755, 22);
            this.allThreadStop.TabIndex = 9;
            this.allThreadStop.Text = "Зупинити всі потоки";
            this.allThreadStop.UseVisualStyleBackColor = true;
            this.allThreadStop.Click += new System.EventHandler(this.allThreadStop_Click);
            // 
            // randomNumberTextBox
            // 
            this.randomNumberTextBox.Location = new System.Drawing.Point(561, 7);
            this.randomNumberTextBox.Name = "randomNumberTextBox";
            this.randomNumberTextBox.Size = new System.Drawing.Size(200, 199);
            this.randomNumberTextBox.TabIndex = 10;
            this.randomNumberTextBox.Text = "";
            // 
            // plainTextBox1
            // 
            this.plainTextBox1.Location = new System.Drawing.Point(6, 26);
            this.plainTextBox1.Name = "plainTextBox1";
            this.plainTextBox1.Size = new System.Drawing.Size(200, 83);
            this.plainTextBox1.TabIndex = 11;
            this.plainTextBox1.Text = "";
            // 
            // plainTextBox3
            // 
            this.plainTextBox3.Location = new System.Drawing.Point(561, 26);
            this.plainTextBox3.Name = "plainTextBox3";
            this.plainTextBox3.Size = new System.Drawing.Size(200, 83);
            this.plainTextBox3.TabIndex = 12;
            this.plainTextBox3.Text = "";
            // 
            // plainTextBox2
            // 
            this.plainTextBox2.Location = new System.Drawing.Point(280, 22);
            this.plainTextBox2.Name = "plainTextBox2";
            this.plainTextBox2.Size = new System.Drawing.Size(200, 87);
            this.plainTextBox2.TabIndex = 13;
            this.plainTextBox2.Text = "";
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(6, 358);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(755, 22);
            this.RunButton.TabIndex = 20;
            this.RunButton.Text = "Запустити всі методи";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // encryptedTextBox1
            // 
            this.encryptedTextBox1.Location = new System.Drawing.Point(6, 127);
            this.encryptedTextBox1.Name = "encryptedTextBox1";
            this.encryptedTextBox1.Size = new System.Drawing.Size(200, 78);
            this.encryptedTextBox1.TabIndex = 22;
            this.encryptedTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Введіть звичайний текст:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Зашифрований текст:";
            // 
            // encryptedTextBox2
            // 
            this.encryptedTextBox2.Location = new System.Drawing.Point(280, 127);
            this.encryptedTextBox2.Name = "encryptedTextBox2";
            this.encryptedTextBox2.Size = new System.Drawing.Size(200, 78);
            this.encryptedTextBox2.TabIndex = 25;
            this.encryptedTextBox2.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Введіть звичайний текст:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Зашифрований текст:";
            // 
            // encryptedTextBox3
            // 
            this.encryptedTextBox3.Location = new System.Drawing.Point(561, 127);
            this.encryptedTextBox3.Name = "encryptedTextBox3";
            this.encryptedTextBox3.Size = new System.Drawing.Size(200, 78);
            this.encryptedTextBox3.TabIndex = 28;
            this.encryptedTextBox3.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(558, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Введіть звичайний текст:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(558, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Зашифрований текст:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Багатопотокова програма";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button allThreadStop;
        private System.Windows.Forms.Button thirdThreadStop;
        private System.Windows.Forms.Button secondThreadStop;
        private System.Windows.Forms.Button firstThreadStop;
        private System.Windows.Forms.Button allThreadStart;
        private System.Windows.Forms.Button thirdThreadStart;
        private System.Windows.Forms.Button secondThreadStart;
        private System.Windows.Forms.Button firstThreadStart;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox randomNumberTextBox;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.RichTextBox plainTextBox2;
        private System.Windows.Forms.RichTextBox plainTextBox3;
        private System.Windows.Forms.RichTextBox plainTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox encryptedTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox encryptedTextBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox encryptedTextBox2;
    }
}


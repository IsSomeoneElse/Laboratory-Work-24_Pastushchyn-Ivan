using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Security.Policy;

namespace LW24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            thread1 = new Thread(new ThreadStart(DrawRectangle));
            thread2 = new Thread(new ThreadStart(DrawEllipse));
            thread3 = new Thread(new ThreadStart(RandomNumber));
        }

        Thread thread1;
        Thread thread2;
        Thread thread3;

        private void DrawRectangle()
        {
            try
            {
                Random rnd = new Random();
                Graphics g = panel1.CreateGraphics();
                while (true)
                {
                    Thread.Sleep(4);
                    g.DrawRectangle(Pens.Pink, 0, 0, rnd.Next(this.Width),
                    rnd.Next(this.Height));
                }
            }
            catch (Exception ex) { }
        }

        private void DrawEllipse()
        {
            try
            {
                Random rnd = new Random();
                Graphics g = panel2.CreateGraphics();
                while (true)
                {
                    Thread.Sleep(4);
                    g.DrawEllipse(Pens.Yellow, 0, 0, rnd.Next(this.Width),
                   rnd.Next(this.Height));
                }
            }
            catch (Exception ex) { }
        }

        private void RandomNumber()
        {
            try
            {
                Random rnd = new Random();
                Parallel.For(0, 500, i =>
                {
                    randomNumberTextBox.Invoke((MethodInvoker)delegate ()
                    {
                        randomNumberTextBox.Text += rnd.Next().ToString();
                    });
                });
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void firstThreadStart_Click(object sender, EventArgs e)
        {
            thread1.Start();
        }

        private void secondThreadStart_Click(object sender, EventArgs e)
        {
            thread2.Start();
        }

        private void thirdThreadStart_Click(object sender, EventArgs e)
        {
            thread3.Start();
        }

        private void allThreadStart_Click(object sender, EventArgs e)
        {
            thread1.Start();
            thread2.Start();
            thread3.Start();
        }

        private void firstThreadStop_Click(object sender, EventArgs e)
        {
            thread1.Suspend();
        }

        private void secondThreadStop_Click(object sender, EventArgs e)
        {
            thread2.Suspend();
        }

        private void thirdThreadStop_Click(object sender, EventArgs e)
        {
            if (thread3.ThreadState == ThreadState.Running)
            {
                thread3.Suspend();
            }
        }

        private void allThreadStop_Click(object sender, EventArgs e)
        {
            thread1.Suspend();
            thread2.Suspend();
            if (thread3.ThreadState == ThreadState.Running)
            {
                thread3.Suspend();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            thread1.Abort();
            thread2.Abort();
            thread3.Abort();
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            thread1.Abort();
            thread2.Abort();
            thread3.Abort();
        }

        private async void RunButton_Click(object sender, EventArgs e)
        {
            await RunCryptoMethodsAsync();
            MessageBox.Show("Всі методи криптографії виконані.", "Завершено", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async Task RunCryptoMethodsAsync()
        {
            string inputText1 = plainTextBox1.Text;
            string inputText2 = plainTextBox2.Text;
            string inputText3 = plainTextBox3.Text;

            await Task.WhenAll(
                Task.Run(async () =>
                {
                    await Task.Delay(1000);
                    string encryptedText = EncryptCRAB(inputText1);
                    encryptedTextBox1.Invoke((MethodInvoker)(() => encryptedTextBox1.Text = encryptedText));
                }),
                Task.Run(async () =>
                {
                    await Task.Delay(1500);
                    string hashedText = HashRIPEMD(inputText2);
                    encryptedTextBox2.Invoke((MethodInvoker)(() => encryptedTextBox2.Text = hashedText));
                }),
                Task.Run(async () =>
                {
                    await Task.Delay(2000);
                    string encryptedText2 = EncryptMaurer(inputText3);
                    encryptedTextBox3.Invoke((MethodInvoker)(() => encryptedTextBox3.Text = encryptedText2));
                })
            );
        }

        private string EncryptCRAB(string plainText)
        {
            StringBuilder encryptedText = new StringBuilder();

            foreach (char c in plainText)
            {
                char encryptedChar = (char)(c + 1);
                encryptedText.Append(encryptedChar);
            }

            return encryptedText.ToString();
        }

        private string HashRIPEMD(string plainText)
        {
            using (var hasher = new RIPEMD160Managed())
            {
                byte[] plaintextBytes = Encoding.UTF8.GetBytes(plainText);
                byte[] hashBytes = hasher.ComputeHash(plaintextBytes);
                return BitConverter.ToString(hashBytes).Replace("-", string.Empty);
            }
        }

        private string EncryptMaurer(string plainText)
        {
            StringBuilder encryptedText2 = new StringBuilder();

            foreach (char c in plainText)
            {
                char encryptedChar = (char)(c + 2);
                encryptedText2.Append(encryptedChar);
            }

            return encryptedText2.ToString();
        }
    }
}
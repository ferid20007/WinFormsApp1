using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string istifadechiAdi = textBox1.Text.Trim();
            string sifre = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(istifadechiAdi) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Xana boş olmaz", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (UserStore.Istifadechiler.ContainsKey(istifadechiAdi) && UserStore.Istifadechiler[istifadechiAdi] == sifre)
                {
                    MessageBox.Show("Sistemə daxil oldunuz!", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Clear();
                    textBox2.Clear();
                }
                else
                {
                    MessageBox.Show("İstifadəçi adı və ya şifrəsi yanlışdır", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnGoToSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.ShowDialog();
        }
    }
}
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string istifadechiAdi = textBox1.Text.Trim();
            string sifre = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(istifadechiAdi) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Xanalar boş ola bilməz!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (UserStore.Istifadechiler.ContainsKey(istifadechiAdi))
            {
                MessageBox.Show("Bu istifadəçi adı artıq götürülüb! Başqa ad seçin.", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                UserStore.Istifadechiler.Add(istifadechiAdi, sifre);
                MessageBox.Show("Uğurla qeydiyyatdan keçdiniz!", "Bildiriş", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBox1.Clear();
                textBox2.Clear();
                this.Close();
            }
        }
    }
}
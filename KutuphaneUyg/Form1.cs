using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneUyg
{
    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();

        string adminNickname = "root";
        string adminPassword = "password";
        public Form1()
        {
            InitializeComponent();
        }

        private void giris_Click(object sender, EventArgs e)
        {
            string nickname = kadi.Text;
            string password = parola.Text;

            if (nickname == adminNickname && password == adminPassword) {
                MessageBox.Show("Giriş başarılı.");
                this.Hide();
                form2.Show();
            } else
            {
                MessageBox.Show("Kullanıcı adı veya parola hatalı.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            form2.Show();
        }
    }
}

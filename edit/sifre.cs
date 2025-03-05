using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace edit
{
    public partial class sifre : Form
    {
        public sifre()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kulanıcıadı = textBox1.Text;
            string sifre = textBox2.Text;

            if (kulanıcıadı == "" || sifre == "")
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz.", "Program");
            }
            else
            {
                if (kulanıcıadı == "mami" && sifre == "2121")
                {
                    MessageBox.Show("Giriş Başarılı");
                }
                else
                {
                    MessageBox.Show("Hatalı Giriş");
                }
            }
        }
    }
}

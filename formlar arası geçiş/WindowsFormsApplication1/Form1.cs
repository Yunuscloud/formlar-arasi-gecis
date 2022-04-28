using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullanici = textBox1.Text;
            string sifre = textBox2.Text;
            Form2 fr2 = new Form2();
            if (kullanici == "yunus" && sifre == "1")
            {
                this.Hide();
                fr2.Show();
                
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalıdır");
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState==CheckState.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else if (checkBox1.CheckState==CheckState.Unchecked)
            {
             textBox2.UseSystemPasswordChar = true;
            }
        }
    }
}

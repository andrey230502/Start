using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Start
{
    public partial class Form1 : Form
    {
        int count = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string login, str;
            string pass;
            login = textBox_Login.Text;
            pass = textBox1.Text;
            if (login == "Ilya")
            {
                
                if (pass == "123456")
                {
                    str = "Привіт " + login;
                    label2.BackColor = Color.Green;
                    label3.BackColor = Color.Green;
                    MessageBox.Show(str, "Назва вікна", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    count--;
                    str = "Невірний пароль або логін. У вас залишилось " + count + " спроб";
                    label2.BackColor = Color.Red;
                    label3.BackColor = Color.Red;

                    if (count == 0)
                    {
                        button1.Enabled = false;
                    }
                    MessageBox.Show(str, "Назва вікна", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }
            else if(login != "Ilya")
            {
                str = "Невірний пароль або логін.";
                label2.BackColor = Color.Red;
                label3.BackColor = Color.Red;
                MessageBox.Show(str, "Назва вікна", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

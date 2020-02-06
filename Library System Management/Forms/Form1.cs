using Library_System_Management.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_System_Management
{
    public partial class Form1 : Form
    {
        string id="administrator", pass="admin";
        public Form1()
        {
            
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != pass&&textBox1.Text !=id)
            {
                MessageBox.Show("Please correct your username or password..", "Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Select();
            }
            else
            {
                using (Form2 fd = new Form2())
                {
                    fd.user = textBox1.Text;
                    fd.ShowDialog();
                    Application.Exit();
                }
            }
        }

        private void checkBox_save_password_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = checkBox_save_password.Checked ? '\0' : '*';
        }
    }
}

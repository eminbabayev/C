using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Check_TextChanged (object sender,EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "emin_babayev99@mail.ru" && textBox3.Text != 12345.ToString())
            {
                label4.Text = "Yalnis parol ve ya emil daxcil etmisniz";
                label4.BackColor = Color.Red;
            }
            else
            {
                Form2 frm = new Form2();
                frm.Show();
                this.Hide();
                MessageBox.Show("Xos qelmisiniz");
                
            }
        }
    }
}

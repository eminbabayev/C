using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddSearch
{
    public partial class Form1 : Form
    {
        List<DataGridView> dt = new List<DataGridView>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                lbl.Text = "Duzgun daxil et";
                lbl.ForeColor = Color.Blue;

            }
            else
            {
                DateTime date = dateTimePicker1.Value;
                Grid.Rows.Add(textBox1.Text, dateTimePicker1.Text, textBox2.Text);
                textBox1.Text = "";
                textBox2.Text = "";
                dateTimePicker1.Value = DateTime.Now;
            }

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Grid.Rows.Count; i++)
            {
                if (Grid.Rows[i].Visible)
                {
                    for (int j = 0; j < Grid.Rows[i].Cells.Count; j++)
                    {
                        MessageBox.Show(Grid.Rows[i].Cells[j].Value.ToString());
                    }
                }

            }

        }
        private void txt_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Grid.Rows.Count; i++)
            {
                for (int j = 0; j < Grid.Rows[i].Cells.Count; j++)
                {
                    if (Grid.Rows[i].Cells[j].Value.ToString().Contains(textBox3.Text))
                    {
                        Grid.Rows[i].Visible = true;
                        break;


                    }
                    else
                    {
                        Grid.Rows[i].Visible = false;
                    }
                }
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _09._05._18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FillStudents();
        }
        private void FillStudents()
        {
            DtgStudents.Rows.Clear();
            SqlConnection con = new SqlConnection(@"Server = AZCNGRM\SQLEXPRESS; Database = School; Integrated Security = SSPI;");
            con.Open();
            string query = "SELECT * FROM Students";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();
            //MessageBox.Show(reader.HasRows.ToString());

            while (reader.Read())
            {
                DtgStudents.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));

            }

            con.Close();
            
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            LblError.Text = "";
            string Name = TxtName.Text;
            string Surname = TxtSurname.Text;
            string Phone = TxtPhone.Text;

            if(Name == String.Empty || Surname == String.Empty || Phone == String.Empty)
            {
                LblError.Text = "Bosluq daxil etmeyin";
                return;
            }

            SqlConnection con = new SqlConnection(@"Server = AZCNGRM\SQLEXPRESS; Database = School; Integrated Security = SSPI;");
            con.Open();
            string query = "INSERT INTO Students([Name],[Surname],[Phone]) VALUES('" + Name + "', '" + Surname + "', '" + Phone + "')";

            SqlCommand command = new SqlCommand(query, con);
            int affRow = command.ExecuteNonQuery();
            con.Close();

            FillStudents();
            TxtName.Text = "";
            TxtSurname.Text = "";
            TxtPhone.Text = "";


        }
    }
}

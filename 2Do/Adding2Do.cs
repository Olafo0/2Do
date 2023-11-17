using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2Do
{
    public partial class Adding2Do : Form
    {

        // string connectionString = "Data Source=LC21205XX\\SQLEXPRESS;Initial Catalog=ToDoListDB;User ID =sa;Password=sa2023;"; School
        string connectionString = "Data Source=DESKTOP-DNB9KRF;Initial Catalog=2DoDB;Integrated Security=True;";
        SqlConnection cnn;
        SqlCommand cmd;



        public Adding2Do()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(DescriptionTB.Text);
        }

        private void AddBTN_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TitleTB.Text) && String.IsNullOrEmpty(DescriptionTB.Text))
            {

            }

            else
            {
                int PriorityNumber;

                if (PriorityCB.Text == "High")
                {
                    PriorityNumber = 1;
                }
                else if (PriorityCB.Text == "Medium")
                {
                    PriorityNumber = 2;
                }
                else
                {
                    PriorityNumber = 3;
                }
                

                DateTime CurrentDate = DateTime.Now;
                string formatedDate = CurrentDate.ToString("yyyy-MM-dd");
                string Query = $"INSERT INTO tbl_2DoList(ToDoTitle,ToDoDesc,Done,DateCreated,PriorityTask) VALUES('{TitleTB.Text}','{DescriptionTB.Text}',{0},'{formatedDate}',{PriorityNumber})";
                try
                {
                    using (cnn = new SqlConnection(connectionString))
                    {
                        cnn.Open();
                        cmd = new SqlCommand(Query, cnn);
                        int rows = cmd.ExecuteNonQuery();
                    }
                    cmd.Dispose();
                    cnn.Close();
                    TitleTB.Text = "";
                    DescriptionTB.Text = "";
                    PriorityCB.SelectedItem = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Adding2Do_Load(object sender, EventArgs e)
        {

        }
    }
}

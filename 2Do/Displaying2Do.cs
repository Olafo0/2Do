using Microsoft.VisualBasic;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2Do
{
    public partial class Displaying2Do : Form
    {
        List<Tasks> CurrentTasks = new List<Tasks>();


        string connectionString = "Data Source=#;Initial Catalog=#;User ID =sa;Password=sa2023;";
        SqlConnection cnn;
        SqlCommand command;

        public Displaying2Do()
        {
            InitializeComponent();
        }
        private void Displaying2Do_Load(object sender, EventArgs e)
        {
            try
            {
                // We make a query
                string Query = "SELECT * FROM _ToDoList";
                // We connect to the DB
                cnn = new SqlConnection(connectionString);
                // We open the database
                cnn.Open();
                // We make the command
                command = new SqlCommand(Query, cnn);
                // We execute the command
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int ToDoID = int.Parse(reader["ToDoID"].ToString());
                        string ToDoTitle = reader["ToDoTitle"].ToString();
                        string ToDoDesc = reader["ToDoDesc"].ToString();
                        bool Done = bool.Parse(reader["Done"].ToString());
                        DateTime? DateCreated = DateTime.Parse(reader["DateCreated"].ToString()).Date;
                        DateTime? DateDone = null;


                        Tasks CreateTask = new Tasks(ToDoID, ToDoTitle, ToDoDesc, Done, DateCreated, DateDone);
                        CurrentTasks.Add(CreateTask);
                    }
                    command.Dispose();
                    cnn.Close();
                }
                foreach (var task in CurrentTasks)
                {
                    TaskOutputter.AppendText($"- - - - - - - - - - - - - - - - - - - - - - - - - - -\n\n ID :{task.ToDoID} \n Title : {task.ToDoTitle} \n ################## \n Descripition : {task.ToDoDesc} \n##################\n Status : {task.Done} \n Date Created : {task.DateCreated} \n Date Done : {task.DateDone} \n\n");
                }
                StatusTB.Text = CurrentTasks.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void dataGridView2Do_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void ClearBTN_Click(object sender, EventArgs e)
        {
            TaskOutputter.Clear();
            foreach (var task in CurrentTasks)
            {
                TaskOutputter.AppendText($"- - - - - - - - - - - - - - - - - - - - - - - - - - -\n\n ID :{task.ToDoID} \n Title : {task.ToDoTitle} \n ################## \n Descripition : {task.ToDoDesc} \n##################\n Status : {task.Done} \n Date Created : {task.DateCreated} \n Date Done : {task.DateDone} \n\n");
            }
        }

        private void FindByIDBTN_Click(object sender, EventArgs e)
        {
            try
            {


                int inputBoxResponse = int.Parse(Interaction.InputBox("Enter in the Tasks ID", "Filter", "", 300, 100));

                foreach (var task in CurrentTasks)
                {
                    if (task.ToDoID == inputBoxResponse)
                    {
                        TaskOutputter.Clear();
                        TaskOutputter.AppendText($"- - - - - - - - - - - - - - - - - - - - - - - - - - -\n\n ID :{task.ToDoID} \n Title : {task.ToDoTitle} \n ################# \n Descripition : {task.ToDoDesc} \n#################n Status : {task.Done} \n Date Created : {task.DateCreated} \n Date Done : {task.DateDone} \n\n");
                    }
                    else { }


                }
            }
            catch (Exception ex) { }
        }
        private void FindByTitleBTN_Click(object sender, EventArgs e)
        {

            string? inputBoxResponse = Interaction.InputBox("Enter the Task Title", "Filter", "", 300, 100);

            if (string.IsNullOrEmpty(inputBoxResponse))
            {
                MessageBox.Show("You've haven't entered anything", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    var foundTasks = CurrentTasks.Where(x => x.ToDoTitle.Contains(inputBoxResponse)).ToList();

                    foreach (var task in foundTasks)
                    {
                        TaskOutputter.Clear();
                        TaskOutputter.AppendText($"- - - - - - - - - - - - - - - - - - - - - - - - - - -\n\n ID :{task.ToDoID} \n Title : {task.ToDoTitle} \n ################# \n Descripition : {task.ToDoDesc} \n#################n Status : {task.Done} \n Date Created : {task.DateCreated} \n Date Done : {task.DateDone} \n\n");
                    }
                }
                catch (Exception ex) { }
            }
        }

        private void RemoveBTN_Click(object sender, EventArgs e)
        {
            string inputBoxResponse = Interaction.InputBox("Enter the Tasks ID to remove it", "Remove task", "", 300, 100);


            if (string.IsNullOrEmpty(inputBoxResponse)) 
            {
                MessageBox.Show("You've haven't entered anything", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int IDToRemove = int.Parse(inputBoxResponse);
                string Query = $"DELETE FROM _ToDoList WHERE ToDoID={IDToRemove}";
                try
                {
                    using (cnn = new SqlConnection(connectionString))
                    {
                        cnn.Open();
                        command = new SqlCommand(Query, cnn);
                        command.ExecuteNonQuery();
                    }
                    command.Dispose();
                    cnn.Close();

                    var foundTask = CurrentTasks.Single(x => x.ToDoID == IDToRemove);
                    CurrentTasks.Remove(foundTask);

                    foreach (var task in CurrentTasks)
                    {
                        TaskOutputter.Clear();
                        TaskOutputter.AppendText($"- - - - - - - - - - - - - - - - - - - - - - - - - - -\n\n ID :{task.ToDoID} \n Title : {task.ToDoTitle} \n ################# \n Descripition : {task.ToDoDesc} \n#################n Status : {task.Done} \n Date Created : {task.DateCreated} \n Date Done : {task.DateDone} \n\n");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

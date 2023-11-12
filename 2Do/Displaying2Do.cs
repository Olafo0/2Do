﻿using Microsoft.VisualBasic;
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


        string connectionString = "Data Source=DESKTOP-DNB9KRF;Initial Catalog=2DoDB;Integrated Security=True;";
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
                string Query = "SELECT * FROM tbl_2DoList";
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
            try
            {
                int inputBoxResponse = int.Parse(Interaction.InputBox("Enter the Task Title", "Filter", "", 300, 100));
            }
            catch (Exception ex) { }
        }
    }
}

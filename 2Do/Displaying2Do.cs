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
        string PriorityOutputter;

        //  string connectionString = "Data Source=LC21205XX\\SQLEXPRESS;Initial Catalog=ToDoListDB;User ID =sa;Password=sa2023;"; string
        string connectionString = "Data Source=DESKTOP-DNB9KRF;Initial Catalog=2DoDB;Integrated Security=True;";
        SqlConnection cnn;
        SqlCommand command;

        public Displaying2Do()
        {
            InitializeComponent();
        }

        public void TaskOutputterMethod()
        {
            foreach (var task in CurrentTasks)
            {

                switch (task.Priority)
                {
                    case 1:
                        PriorityOutputter = "High";
                        break;
                    case 2:
                        PriorityOutputter = "Medium";
                        break;
                    case 3:
                        PriorityOutputter = "Low";
                        break;
                }

                TaskOutputter.AppendText($"- - - - - - - - - - - - - - - - - - - - - - - - - - -\n\n ID :{task.ToDoID} \n Priority :{PriorityOutputter} \n Title : {task.ToDoTitle} \n ################## \n Descripition : {task.ToDoDesc} \n##################\n Complete? : {task.Done} \n Date Created : {task.DateCreated} \n Date Done : {task.DateDone} \n\n");
            }
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
                        DateTime? DateDone;
                        int Priority = int.Parse(reader["PriorityTask"].ToString());

                        string tempDateDone = reader["DateDone"].ToString();
                        if (String.IsNullOrEmpty(tempDateDone))
                        {
                            DateDone = null;
                        }
                        else
                        {
                            DateDone = DateTime.Parse(reader["DateDone"].ToString()).Date;
                        }


                        Tasks CreateTask = new Tasks(ToDoID, ToDoTitle, ToDoDesc, Done, DateCreated, DateDone, Priority);
                        CurrentTasks.Add(CreateTask);
                    }
                    command.Dispose();
                    cnn.Close();
                    CurrentTasks = CurrentTasks.OrderBy(x => x.Priority).ToList();

                }
                foreach (var task in CurrentTasks)
                {

                    switch (task.Priority)
                    {
                        case 1:
                            PriorityOutputter = "High";
                            break;
                        case 2:
                            PriorityOutputter = "Medium";
                            break;
                        case 3:
                            PriorityOutputter = "Low";
                            break;
                    }

                    TaskOutputter.AppendText($"- - - - - - - - - - - - - - - - - - - - - - - - - - -\n\n ID :{task.ToDoID} \n Priority :{PriorityOutputter} \n Title : {task.ToDoTitle} \n ################## \n Descripition : {task.ToDoDesc} \n##################\n Complete? : {task.Done} \n Date Created : {task.DateCreated} \n Date Done : {task.DateDone} \n\n");
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
            TaskOutputterMethod();
        }

        private void FindByIDBTN_Click(object sender, EventArgs e)
        {
            try
            {

                int inputBoxResponse = int.Parse(Interaction.InputBox("Enter in the Tasks ID", "Filter", "", 250, 100));


                foreach (var task in CurrentTasks)
                {

                    if (task.ToDoID == inputBoxResponse)
                    {
                        switch (task.Priority)
                        {
                            case 1:
                                PriorityOutputter = "High";
                                break;
                            case 2:
                                PriorityOutputter = "Medium";
                                break;
                            case 3:
                                PriorityOutputter = "Low";
                                break;
                        }
                        TaskOutputter.Clear();
                        TaskOutputter.AppendText($"- - - - - - - - - - - - - - - - - - - - - - - - - - -\n\n ID :{task.ToDoID} \n Priority :{PriorityOutputter} \n Title : {task.ToDoTitle} \n ################## \n Descripition : {task.ToDoDesc} \n##################\n Complete? : {task.Done} \n Date Created : {task.DateCreated} \n Date Done : {task.DateDone} \n\n");
                        break;
                    }
                    else
                    {
                        TaskOutputter.AppendText(" * * * The ID you have provided didn't have a corrosponding Task.\n * * * Please press clear.");
                    }
                }
            }
            catch (Exception ex) { }
        }
        private void FindByTitleBTN_Click(object sender, EventArgs e)
        {

            string? inputBoxResponse = Interaction.InputBox("Enter the Task Title", "Filter", "", 250, 100);

            if (string.IsNullOrEmpty(inputBoxResponse))
            {
                MessageBox.Show("You've haven't entered anything", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    var foundTasks = CurrentTasks.Where(x => x.ToDoTitle.Contains(inputBoxResponse)).ToList();

                    TaskOutputter.Clear();
                    foreach (var task in foundTasks)
                    {
                        switch (task.Priority)
                        {
                            case 1:
                                PriorityOutputter = "High";
                                break;
                            case 2:
                                PriorityOutputter = "Medium";
                                break;
                            case 3:
                                PriorityOutputter = "Low";
                                break;
                        }
                        TaskOutputter.AppendText($"- - - - - - - - - - - - - - - - - - - - - - - - - - -\n\n ID :{task.ToDoID} \n Priority :{PriorityOutputter} \n Title : {task.ToDoTitle} \n ################## \n Descripition : {task.ToDoDesc} \n##################\n Complete? : {task.Done} \n Date Created : {task.DateCreated} \n Date Done : {task.DateDone} \n\n");
                    }
                }
                catch (Exception ex) { }
            }
        }
        private void FindByPriorityBTN_Click(object sender, EventArgs e)
        {
            string? inputBoxResponse = Interaction.InputBox("Please enter the corresponding number : \n 1 - High priortiy \n 2 - Medium priortiy \n 3 - Low priortiy", "Filter", "", 250, 100);

            TaskOutputter.Clear();
            switch (int.Parse(inputBoxResponse))
            {

                // High priority
                case 1:
                    foreach (var task in CurrentTasks)
                    {
                        if (task.Priority == 1)
                        {
                            TaskOutputter.AppendText($"- - - - - - - - - - - - - - - - - - - - - - - - - - -\n\n ID :{task.ToDoID} \n Priority :{"High"} \n Title : {task.ToDoTitle} \n ################## \n Descripition : {task.ToDoDesc} \n##################\n Complete? : {task.Done} \n Date Created : {task.DateCreated} \n Date Done : {task.DateDone} \n\n");
                        }
                    }
                    break;
                // Medium priority
                case 2:
                    foreach (var task in CurrentTasks)
                    {
                        if (task.Priority == 2)
                        {
                            TaskOutputter.AppendText($"- - - - - - - - - - - - - - - - - - - - - - - - - - -\n\n ID :{task.ToDoID} \n Priority :{"Medium"} \n Title : {task.ToDoTitle} \n ################## \n Descripition : {task.ToDoDesc} \n##################\n Complete? : {task.Done} \n Date Created : {task.DateCreated} \n Date Done : {task.DateDone} \n\n");
                        }
                    }
                    break;
                // Low priority
                case 3:
                    foreach (var task in CurrentTasks)
                    {
                        if (task.Priority == 3)
                        {

                            TaskOutputter.AppendText($"- - - - - - - - - - - - - - - - - - - - - - - - - - -\n\n ID :{task.ToDoID} \n Priority :{"Low"} \n Title : {task.ToDoTitle} \n ################## \n Descripition : {task.ToDoDesc} \n##################\n Complete? : {task.Done} \n Date Created : {task.DateCreated} \n Date Done : {task.DateDone} \n\n");
                        }
                    }
                    break;
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
                string Query = $"DELETE FROM tbl_2DoList WHERE ToDoID={IDToRemove}";
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

                    TaskOutputter.Clear();
                    TaskOutputterMethod();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MarkCompleteBTN_Click(object sender, EventArgs e)
        {
            DateTime CurrentDate = DateTime.Now;
            string formatedDate = CurrentDate.ToString("yyyy-MM-dd");


            string inputBoxResponse = Interaction.InputBox("Enter the Tasks ID you want to mark complete", "Complete task", "", 300, 100);

            if (String.IsNullOrEmpty(inputBoxResponse))
            {

            }
            else
            {
                int IDToComplete = int.Parse(inputBoxResponse);
                string Query = $"UPDATE tbl_2DoList SET Done = {1}, DateDone = '{formatedDate}' WHERE ToDoID = {IDToComplete}";

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

                    var foundTask = CurrentTasks.Single(x => x.ToDoID == IDToComplete);
                    foundTask.Done = true;
                    foundTask.DateDone = DateTime.Now;

                    TaskOutputter.Clear();
                    TaskOutputterMethod();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ChnPriorityBTN_Click(object sender, EventArgs e)
        {
            int inputBoxResponseID = int.Parse(Interaction.InputBox("Enter the Task ID in which you want to change the priortiy", "Task ID", "", 300, 100));
            int inputBoxResponsePriority = int.Parse(Interaction.InputBox("To what Priority do you want to change this task to :  \n 1 - High priortiy \n 2 - Medium priortiy \n 3 - Low priortiy", "Change Priority", "", 300, 100));
            try
            {
                using (cnn = new SqlConnection(connectionString))
                {
                    cnn.Open();
                    string Query = $"UPDATE tbl_2DoList SET PriorityTask = {inputBoxResponsePriority} WHERE ToDoID = {inputBoxResponseID}";
                    command = new SqlCommand(Query, cnn);
                    command.ExecuteNonQuery();
                }
                command.Dispose();
                cnn.Close();

                foreach (var task in CurrentTasks)
                {
                    if (task.ToDoID == inputBoxResponseID)
                    {
                        task.Priority = inputBoxResponsePriority;
                    }
                }
                TaskOutputter.Clear();
                TaskOutputterMethod();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

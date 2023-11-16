using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Do
{
    public class Tasks
    {
        public int? ToDoID { get; set; }
        public string? ToDoTitle { get; set; }
        public string? ToDoDesc { get; set; }
        public bool Done { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateDone { get; set; }
        public int Priority { get; set; }

        public Tasks(int toDoID, string? toDoTitle, string? toDoDesc, bool done, DateTime? dateCreated, DateTime? dateDone, int priority)
        {
            this.ToDoID = toDoID;
            this.ToDoTitle = toDoTitle;
            this.ToDoDesc = toDoDesc;
            this.Done = done;
            this.DateCreated = dateCreated;
            this.DateDone = dateDone;
            this.Priority = priority;
        }
    }
}

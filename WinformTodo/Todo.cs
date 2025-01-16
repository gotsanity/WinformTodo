using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformTodo
{
    public class Todo
    {
        public static int ObjectCounter = 0;
        public int Id { get; set; }
        public string TaskDescription { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsDone { get; set; }

        public Todo(string description, DateTime date, bool doneState)
        {
            ObjectCounter++;
            Id = ObjectCounter;
            TaskDescription = description;
            DueDate = date;
            IsDone = doneState;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookLogic
{
    public class Task
    {
        //Data members
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public Task(string i_Name, DateTime i_Date)
        {
            Description = i_Name;
            Date = i_Date;
        }
    }
}


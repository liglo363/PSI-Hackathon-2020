using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace App.DataModel
{
    public class Assignment
    {
        public string Name { get; set; }
        public DateTime DueDate { get; set; }
        public bool Completed { get; set; }
    }

    public class AssignmentManager
    {

        static AssignmentManager()
        {
            AssignmentCollection = new ObservableCollection<Assignment>();
            //AssignmentCollection.Add(new Assignment { Name = "MyAssignment One", DueDate = DateTime.Today });
            //AssignmentCollection.Add(new Assignment { Name = "MyAssignment Two", DueDate = DateTime.Today });
        }
        public static ObservableCollection<Assignment> AssignmentCollection { get; set; }
    }
}

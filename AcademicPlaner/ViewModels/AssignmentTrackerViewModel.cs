using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using AcademicPlaner.Models;
using System.ComponentModel;
using System.Diagnostics;


namespace AcademicPlaner.ViewModels
{
    public class AssignmentTrackerViewModel
    {
        public ObservableCollection<AssignmentTracker> Assignments { get; set; }
        public ObservableCollection<Subject> Subjects { get; set; }
        private const int pusteWierszeStart = 8;

        public AssignmentTrackerViewModel(ObservableCollection<Subject> subjects)
        {
            Subjects=subjects;
            Assignments = new ObservableCollection<AssignmentTracker>();
            for (int i = 0; i < pusteWierszeStart; i++)
            {
                AddNewAssignment();
            }
        }

        public void AddNewAssignment()
        {
            var assignment = new AssignmentTracker();
            Assignments.Add(assignment);
        }


        public void RemoveAssignment(AssignmentTracker assignment)
        {
            Assignments.Remove(assignment);
        }

    }
}

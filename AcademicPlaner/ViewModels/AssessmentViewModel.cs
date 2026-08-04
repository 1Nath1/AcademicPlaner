using AcademicPlaner.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AcademicPlaner.ViewModels
{
    public class AssessmentViewModel
    {
        public ObservableCollection<Assessment> Assessments { get; set; }
        public ObservableCollection<Subject> Subjects { get; set; } = new ObservableCollection<Subject>();
        private const int pusteWierszeStart = 8;

        public List<string> AssessmentTypes { get; } = new List<string>
    {
        "Egzamin",
        "Kolokwium",
        "Projekt",
        "Prezentacja",
        "Zaliczenie ustne",
        "Zaliczenie pisemne"
    };

        public AssessmentViewModel(ObservableCollection<Subject> subjects)
        {
            Subjects = subjects;
            Assessments = new ObservableCollection<Assessment>();  
            
            for (int i = 0; i < pusteWierszeStart; i++)
            {
                AddNewAssessment();
            }

        }


        public void AddNewAssessment()
        {
            var assessment = new Assessment();
            Assessments.Add(assessment);
        }

        public void RemoveAssessment(Assessment assessment)
        {
            Assessments.Remove(assessment);
        }

    }
}

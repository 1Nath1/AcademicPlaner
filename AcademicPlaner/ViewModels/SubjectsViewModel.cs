using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using AcademicPlaner.Models;

namespace AcademicPlaner.ViewModels
{
    public class SubjectsViewModel
    {
        public ObservableCollection<Subject> Subjects { get; set; }

        private const int pusteWierszeStart = 9;


        public SubjectsViewModel()
        {
            Subjects = new ObservableCollection<Subject> { };

            for (int i = 0; i < pusteWierszeStart; i++)
            {
                Subjects.Add(new Subject());
            }
        }

    }
}

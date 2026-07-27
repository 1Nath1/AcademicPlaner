using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using AcademicPlaner.Models;
using System.ComponentModel;
using System.Diagnostics;
namespace AcademicPlaner.ViewModels
{
    public class SubjectsViewModel
    {
        public ObservableCollection<Subject> Subjects { get; set; }

        private const int pusteWierszeStart = 8;


        public SubjectsViewModel()
        {
            Subjects = new ObservableCollection<Subject> ();

            for (int i = 0; i < pusteWierszeStart; i++)
            {
                AddNewSubject();
            }
        }

        public void AddNewSubject()
        {
            var subject = new Subject();
           
            Subjects.Add(subject);
        }

        public void RemoveSubject(Subject subject)
        {
           
            Subjects.Remove(subject);
        }   



        /*private void Subject_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            

            if (e.PropertyName != nameof(Subject.Nazwa))
                return;

            if (sender is not Subject subject)
                return;

            bool jestOstatnim = Subjects[Subjects.Count - 1] == subject;
            bool maNazwe = !string.IsNullOrWhiteSpace(subject.Nazwa);

            

            if (maNazwe && jestOstatnim)
            {
                AddNewSubject();
            }
        }*/

    }
}

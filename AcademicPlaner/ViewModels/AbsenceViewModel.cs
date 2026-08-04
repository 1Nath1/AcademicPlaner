using AcademicPlaner.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace AcademicPlaner.ViewModels
{
    public class AbsenceViewModel :INotifyPropertyChanged 
    {
        public ObservableCollection<Absence> Absences { get; set; }
        private readonly ObservableCollection<Subject> subjects;

        private bool showNoSubjectsMessage;
        public bool ShowNoSubjectsMessage
        {
            get => showNoSubjectsMessage;
            set { showNoSubjectsMessage = value; OnPropertyChanged(); }
        }



        public AbsenceViewModel(ObservableCollection<Subject> subjects)
        {
            this.subjects = subjects;
            Absences = new ObservableCollection<Absence>();

            subjects.CollectionChanged += Subjects_CollectionChanged;

            foreach (var s in subjects)
            {
                s.PropertyChanged += Subject_PropertyChanged;
            }

            RebuildAbsences();

        }

        private void Subjects_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
                foreach (Subject s in e.NewItems)
                    s.PropertyChanged += Subject_PropertyChanged;

            if (e.OldItems != null)
                foreach (Subject s in e.OldItems)
                    s.PropertyChanged -= Subject_PropertyChanged;

            RebuildAbsences();
        }

        private void Subject_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            // reaguj tylko na zmianę nazwy - to ona decyduje, czy wiersz ma istnieć
            if (e.PropertyName == nameof(Subject.Nazwa))
                RebuildAbsences();
        }



        private void RebuildAbsences()
        {
            var validSubjects = subjects
                .Where(s => !string.IsNullOrWhiteSpace(s.Nazwa))
            .ToList(); 


            for (int i = Absences.Count-1; i >= 0; i--)
            {
                var absence = Absences[i];
                if (!validSubjects.Contains(Absences[i].Subject))
                {
                    Absences.RemoveAt(i);
                }
            }


            for(int i = 0; i < validSubjects.Count; i++)
            {
                var s = validSubjects[i];



                if(!Absences.Any(a => a.Subject == s))
                {
                    Absences.Insert(Math.Min(i, Absences.Count), new Absence{Subject = s, AbsenceCount = 0});
                }
            }

            ShowNoSubjectsMessage = Absences.Count == 0;
            
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));



    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace AcademicPlaner.Models
{
    public class AssignmentTracker : INotifyPropertyChanged
    {
        public string SubjectDisplayName => Subject?.Nazwa ?? "Wybierz przedmiot";
        private string assignmentName;
        public string AssignmentName
        {
            get => assignmentName;
            set
            {
                assignmentName = value; OnPropertyChanged();
            }
        }

        private Subject subject;
        public Subject Subject
        {
            get => subject;
            set
            {
                subject = value; OnPropertyChanged(); OnPropertyChanged(nameof(SubjectDisplayName));
            }
        }

        private DateTime dueDate = DateTime.Today;
        public DateTime DueDate
        {
            get => dueDate;
            set
            {
                dueDate = value; OnPropertyChanged();
            }
        }

        private bool isCompleted;
        public bool IsCompleted
        {
            get => isCompleted;
            set
            {
                isCompleted = value; OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}

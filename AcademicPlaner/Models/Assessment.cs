using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace AcademicPlaner.Models
{
    public class Assessment :INotifyPropertyChanged
    {
        public string SubjectDisplayName => Subject?.Nazwa ?? "Wybierz przedmiot";
        public string AssessmentDisplayName => AssessmentType ?? "Rodzaj zaliczenia";
        private Subject subject;
        public Subject Subject { get { return subject; } set { subject = value; OnPropertyChanged(); OnPropertyChanged(nameof(SubjectDisplayName)); } }


        private string assessmentType;
        public string AssessmentType { get { return assessmentType; } set { assessmentType = value; OnPropertyChanged(); OnPropertyChanged(nameof(AssessmentDisplayName)); } }


        private string? roomNumber;
        public string RoomNumber { get { return roomNumber; } set { roomNumber = value; OnPropertyChanged(); } }


        private string? buildingNumber;
        public string? BuildingNumber { get { return buildingNumber; } set { buildingNumber = value; OnPropertyChanged(); } }


        private DateTime date = DateTime.Now;
        public DateTime Date { get { return date; } set { date = value; OnPropertyChanged(); } }

        private bool? isPasssed;
        public bool? IsPassed { get { return isPasssed; } set { isPasssed = value; OnPropertyChanged(); } }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}

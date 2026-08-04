using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace AcademicPlaner.Models
{
    public class Assessment :INotifyPropertyChanged
    {

        private Subject subject;
        public Subject Subject { get { return subject; } set { subject = value; OnPropertyChanged(); } }


        private string assessmentType;
        public string AssessmentType { get { return assessmentType; } set { assessmentType = value; OnPropertyChanged(); } }


        private string? roomNumber;
        public string RoomNumber { get { return roomNumber; } set { roomNumber = value; OnPropertyChanged(); } }


        private string? buildingNumber;
        public string? BuildingNumber { get { return buildingNumber; } set { buildingNumber = value; OnPropertyChanged(); } }


        private DateTime? date;
        public DateTime? Date { get { return date; } set { date = value; OnPropertyChanged(); } }

        private bool? isPasssed;
        public bool? IsPassed { get { return isPasssed; } set { isPasssed = value; OnPropertyChanged(); } }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}

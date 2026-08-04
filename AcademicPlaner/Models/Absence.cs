using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace AcademicPlaner.Models
{
    public class Absence:INotifyPropertyChanged
    {

        private Subject subject;
        public Subject Subject { get => subject; set { subject = value; OnPropertyChanged(); } }

        private DateTime date;
        public DateTime Date { get => date; set { date = value; OnPropertyChanged(); } }

        private int absenceCount;
        public int AbsenceCount { get => absenceCount; set { absenceCount = value; OnPropertyChanged(); } }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName=null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



    }
}

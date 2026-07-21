using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace AcademicPlaner.Models
{
    public class Subject : INotifyPropertyChanged
    {
        private string nazwa;
        public string Nazwa
            {
                get => nazwa; 

                set 
                {  
                    nazwa = value; OnPropertyChanged(); 
                }     
            }

        private int? ects;
        public int? Ects
            {
            get => ects;

            set
            {
                ects = value; OnPropertyChanged();
            }
        }

        private string sala;
        public string Sala
        {
            get => sala;

            set
            {
                sala = value; OnPropertyChanged();
            }
        }

        private int? maxNb;
        public int? MaxNb
        {
            get => maxNb;

            set
            {
                maxNb = value; OnPropertyChanged();
            }
        }

        private int? aktNb;
        public int? AktNb
        {
            get => aktNb;

            set
            {
                aktNb = value; OnPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}

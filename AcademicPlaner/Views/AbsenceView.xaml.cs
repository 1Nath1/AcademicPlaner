using AcademicPlaner.Models;
using AcademicPlaner.ViewModels;
using System.Collections.Specialized;
using System.Security.Cryptography.X509Certificates;

namespace AcademicPlaner.Views;

public partial class AbsenceView : ContentView
{
	public AbsenceView()
	{
		InitializeComponent();

        BindingContext = new AbsenceViewModel(SharedData.SubjectsViewModel.Subjects);

		
    }
}
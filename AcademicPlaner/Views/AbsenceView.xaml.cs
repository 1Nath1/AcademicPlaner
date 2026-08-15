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

    private void OnNumericEntryTextChanged(object sender, TextChangedEventArgs e)
    {
        if (string.IsNullOrEmpty(e.NewTextValue))
            return;

        // sprawdzamy czy kazdy znak w nowym tekscie jest cyfra
        bool wszystkoScyfr = e.NewTextValue.All(char.IsDigit);

        if (!wszystkoScyfr)
        {
            var entry = sender as Entry;
            entry.Text = e.OldTextValue; // jezeli nie jest cyfra to wracamy do starej wartosci
        }
    }
}
using AcademicPlaner.ViewModels;
using System.Linq;
using AcademicPlaner.Models;
namespace AcademicPlaner.Views;

public partial class SubjectsView : ContentView
{
    private void OnAddSubjectClicked(object sender, EventArgs e)
    {


        if (BindingContext is not ViewModels.SubjectsViewModel viewModel) return;

        viewModel.AddNewSubject();
    }
    private void OnDeleteSubjectClicked(object sender, EventArgs e)
    {
        if (sender is not ImageButton button) return;
        if (button.BindingContext is not Subject subject) return;

        var viewModel = (ViewModels.SubjectsViewModel)BindingContext;
        viewModel.RemoveSubject(subject);
    }
    


    public SubjectsView()
	{
		InitializeComponent();
		BindingContext = SharedData.SubjectsViewModel;
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


    private void OnMaxNbCompleted(object sender, EventArgs e)
    {
        if (sender is not Entry entry)
            return;

        if(entry.BindingContext is not Subject subject)
            return;

        if(BindingContext is not SubjectsViewModel viewModel)
            return; 
        
        int currentIndex = viewModel.Subjects.IndexOf(subject);

        if(currentIndex<0) 
            return;

        bool isLastRow = currentIndex == viewModel.Subjects.Count - 1;


        if(isLastRow)
        viewModel.AddNewSubject();
    }
}
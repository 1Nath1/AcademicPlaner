using AcademicPlaner.ViewModels;
namespace AcademicPlaner.Views;

public partial class SubjectsView : ContentView
{
	public SubjectsView()
	{
		InitializeComponent();
		BindingContext = new SubjectsViewModel();
    }
}
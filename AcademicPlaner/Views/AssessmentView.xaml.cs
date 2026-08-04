using AcademicPlaner.ViewModels;
using AcademicPlaner.Models;
using System.Linq;

namespace AcademicPlaner.Views;

public partial class AssessmentView : ContentView
{
    private Assessment currentlyEditingAssessment;
   
    public AssessmentView()
	{
		InitializeComponent();
		BindingContext = new AssessmentViewModel(SharedData.SubjectsViewModel.Subjects);

	}

    private void OnTypePickerTapped(object sender, EventArgs e)
    {

        if (BindingContext is not AssessmentViewModel viewModel) return;
        if (sender is not Grid grid) return;
        if (grid.BindingContext is not Assessment assessment) return;

        currentlyEditingAssessment = assessment;

        TypesPickerList.ItemsSource = viewModel.AssessmentTypes;
        TypePickerOverlay.IsVisible = true;

    }


    private void OnDeleteAssessmentClicked(object sender, EventArgs e)
    {

        if (sender is not ImageButton button) return;
        if (button.BindingContext is not Assessment assessment) return;

        var viewModel = (ViewModels.AssessmentViewModel)BindingContext;
        viewModel.RemoveAssessment(assessment);

    }
    private void OnAddAssessmentClicked(object sender, EventArgs e)
    {

        if (BindingContext is not ViewModels.AssessmentViewModel viewModel) return;

        viewModel.AddNewAssessment();
    }

    private void OnTypeSelected(object sender, SelectionChangedEventArgs e)
    {

        if (e.CurrentSelection.FirstOrDefault() is not string selectedType) return;
        if (currentlyEditingAssessment == null) return;

        currentlyEditingAssessment.AssessmentType = selectedType;

        TypePickerOverlay.IsVisible = false;
        currentlyEditingAssessment = null;

        // Odznacz zaznaczenie w liście, żeby przy kolejnym otwarciu nic nie było podświetlone
        TypesPickerList.SelectedItem = null;

    }

    private void OnTypeOverlayBackgroundTapped(object sender, EventArgs e)
    {

        TypePickerOverlay.IsVisible = false;
        currentlyEditingAssessment = null;

    }

    private void OnSubjectPickerTapped(object sender, EventArgs e)
    {

        if (BindingContext is not AssessmentViewModel viewModel) return;
        if (sender is not Grid grid) return;
        if (grid.BindingContext is not Assessment assessment) return;

        currentlyEditingAssessment = assessment;

        SubjectsPickerList.ItemsSource = viewModel.Subjects;
        SubjectPickerOverlay.IsVisible = true;

    }

    private void OnSubjectSelected(object sender, SelectionChangedEventArgs e)
    {

        if (e.CurrentSelection.FirstOrDefault() is not Subject selectedSubject) return;
        if (currentlyEditingAssessment == null) return;

        currentlyEditingAssessment.Subject = selectedSubject;

        SubjectPickerOverlay.IsVisible = false;
        currentlyEditingAssessment = null;

        // Odznacz zaznaczenie w liście, żeby przy kolejnym otwarciu nic nie było podświetlone
        SubjectsPickerList.SelectedItem = null;

    }

    private void OnOverlayBackgroundTapped(object sender, EventArgs e)
    {

        SubjectPickerOverlay.IsVisible = false;
        currentlyEditingAssessment = null;

    }
}
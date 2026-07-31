using AcademicPlaner.Models;
using AcademicPlaner.ViewModels;

namespace AcademicPlaner.Views;

public partial class AssignmentTrackerView : ContentView
{
    private AssignmentTracker currentlyEditingAssignment;
    public AssignmentTrackerView()
    {
        InitializeComponent();
        BindingContext = new AssignmentTrackerViewModel(SharedData.SubjectsViewModel.Subjects);

    }

    private void OnAddAssignmentClicked(object sender, EventArgs e)
    {
        if (BindingContext is not ViewModels.AssignmentTrackerViewModel viewModel) return;

        viewModel.AddNewAssignment();
    }

    private void OnDeleteAssignmentClicked(object sender, EventArgs e)
    {
        if (sender is not ImageButton button) return;
        if (button.BindingContext is not AssignmentTracker assigment) return;

        var viewModel = (ViewModels.AssignmentTrackerViewModel)BindingContext;
        viewModel.RemoveAssignment(assigment);
    }

    private void OnSubjectPickerTapped(object sender, EventArgs e)
    {
        if (BindingContext is not AssignmentTrackerViewModel viewModel) return;
        if (sender is not Grid grid) return;
        if (grid.BindingContext is not AssignmentTracker assignment) return;

        currentlyEditingAssignment = assignment;

        SubjectsPickerList.ItemsSource = viewModel.Subjects;
        SubjectPickerOverlay.IsVisible = true;
    }

    private void OnSubjectSelected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is not Subject selectedSubject) return;
        if (currentlyEditingAssignment == null) return;

        currentlyEditingAssignment.Subject = selectedSubject;

        SubjectPickerOverlay.IsVisible = false;
        currentlyEditingAssignment = null;

        // Odznacz zaznaczenie w liście, żeby przy kolejnym otwarciu nic nie było podświetlone
        SubjectsPickerList.SelectedItem = null;
    }

    private void OnOverlayBackgroundTapped(object sender, EventArgs e)
    {
        SubjectPickerOverlay.IsVisible = false;
        currentlyEditingAssignment = null;
    }

}

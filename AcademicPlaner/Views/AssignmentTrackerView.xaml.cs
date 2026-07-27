using AcademicPlaner.Models;
using AcademicPlaner.ViewModels;

namespace AcademicPlaner.Views;

public partial class AssignmentTrackerView : ContentView
{
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
}

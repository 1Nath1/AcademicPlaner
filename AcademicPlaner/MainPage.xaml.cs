namespace AcademicPlaner
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();

        
        }
        private void OnHomeClicked(object sender, EventArgs e)
        {
            MainContentArea.Content = new Views.HomeView();
        }
        private void OnCalendarClicked(object sender, EventArgs e)
        {
            MainContentArea.Content = new Views.CalendarView();
        }

        private void OnAssignmentTrackerClicked(object sender, EventArgs e)
        {
            MainContentArea.Content = new Views.AssignmentTrackerView();
        }

        private void OnAbsenceClicked(object sender, EventArgs e)
        {
            MainContentArea.Content = new Views.AbsenceView();
        }

        private void OnWWeeklyScheduleClicked(object sender, EventArgs e)
        {
            MainContentArea.Content = new Views.WeeklyScheduleView();
        }

        private void OnAssessmentsClicked(object sender, EventArgs e)
        {
            MainContentArea.Content = new Views.AssessmentView();
        }

        private void OnSubjectsClicked(object sender, EventArgs e)
        {
            MainContentArea.Content = new Views.SubjectsView();
        }
    }

}

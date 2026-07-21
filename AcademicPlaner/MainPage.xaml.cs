namespace AcademicPlaner
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();

           


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

        private void OnExamsClicked(object sender, EventArgs e)
        {
            MainContentArea.Content = new Views.ExamsView();
        }

        private void OnSubjectsClicked(object sender, EventArgs e)
        {
            MainContentArea.Content = new Views.SubjectsView();
        }
    }

}

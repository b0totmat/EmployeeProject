using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace EmployeeProject.Desktop.ViewModels
{
    public partial class MainWindowVM : ObservableObject
    {
        public ControlPanelVM ControlPanelVM { get; set; }
        public EmployeeManagementVM ManagementVM { get; set; }

        public MainWindowVM()
        {
            ControlPanelVM = new ControlPanelVM();
            ManagementVM = new EmployeeManagementVM();
        }
    }
}

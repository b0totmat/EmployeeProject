using CommunityToolkit.Mvvm.ComponentModel;
using EmployeeProject.Repos;

namespace EmployeeProject.Desktop.ViewModels
{
    public partial class ControlPanelVM : ObservableObject
    {
        private readonly EmployeeRepo _repo;

        [ObservableProperty]
        private int _numberOfEmployees;
        [ObservableProperty]
        private int _numberOfEmployeesWithSalary;
        [ObservableProperty]
        private int _numberOfEmployeesWithoutSalary;
        [ObservableProperty]
        private double _averagePayment;

        public ControlPanelVM()
        {
            _repo = new EmployeeRepo();
            UpdateView();
        }

        private void UpdateView()
        {
            NumberOfEmployees = _repo.GetNumberOfEmployees();
            NumberOfEmployeesWithSalary = _repo.GetNumberOfEmployeesWithPayment();
            NumberOfEmployeesWithoutSalary = _repo.GetNumberOfEmployeesWithoutPayment();
            AveragePayment = _repo.GetAverageSalary();
        }
    }
}

using BlazorDemo.Common.Web.Repository;
using BlazorDemo.Common.Web.ViewModels;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace BlazorDemo.Web.Pages
{
    public partial class Index : ComponentBase
    {
        [Inject] private IMockEmployeeRepository employeeRepository { get; set; }

        private List<EmployeeViewModel> employees { get; set; }
        private EmployeeViewModel selectedEmployee { get; set; }

        private bool ApiCallIsRunning { get; set; }

        private bool DisplayEmployeeDetailsModal { get; set; }

        private bool DisplayAddEmployeeModal { get; set; }

        protected override async Task OnInitializedAsync()
        {
            this.ApiCallIsRunning = true;
            this.StateHasChanged();

            var employeeResponse = await this.employeeRepository.GetEmployees();

            if (employeeResponse.Success)
            {
                this.employees = employeeResponse.Result;
            }

            this.ApiCallIsRunning = false;
            this.StateHasChanged();
        }

        private void EmployeeClicked(EmployeeViewModel selectedEmployee)
        {
            this.DisplayEmployeeDetailsModal = true;
            this.selectedEmployee = selectedEmployee;

            this.StateHasChanged();
        }

        private void OpenAddEmployeeModal()
        {
            this.DisplayAddEmployeeModal = true;
            this.StateHasChanged();
        }

        private void AddEmployee(EmployeeViewModel newEmployee)
        {
            this.employees.Add(newEmployee);
            this.DisplayAddEmployeeModal = false;
            this.StateHasChanged();
        }
    }
}

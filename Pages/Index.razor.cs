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

        private bool DisplayEmployeeModal { get; set; }

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
            this.DisplayEmployeeModal = true;
            this.selectedEmployee = selectedEmployee;

            this.StateHasChanged();
        }
    }
}

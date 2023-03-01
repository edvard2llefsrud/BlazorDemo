using BlazorDemo.Common.Web.ViewModels;
using Microsoft.AspNetCore.Components;

namespace BlazorDemo.Web.Pages.Components
{
    public partial class AddEmployeeModal
    {
        [Parameter]
        public EventCallback<EmployeeViewModel> AddEmployeeCallback { get; set; }

        private EmployeeViewModel newEmployee { get; set; } = new();

        private async Task AddEmployee()
        {
            await this.AddEmployeeCallback.InvokeAsync(newEmployee);
        }
    }
}

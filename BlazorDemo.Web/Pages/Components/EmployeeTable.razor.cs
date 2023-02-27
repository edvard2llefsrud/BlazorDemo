using BlazorDemo.Common.Web.ViewModels;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace BlazorDemo.Web.Pages.Components
{
    public partial class EmployeeTable : ComponentBase
    {
        [Parameter] public List<EmployeeViewModel> Employees { get; set; }

        [Parameter] public EventCallback<EmployeeViewModel> SelectedEmployeeCallback { get; set; }

        private async Task SelectEmployee(TableRowClickEventArgs<EmployeeViewModel> selectedEmployee)
        {
            await this.SelectedEmployeeCallback.InvokeAsync(selectedEmployee.Item);
        }
    }
}

using BlazorDemo.Common.Web.ViewModels;
using Microsoft.AspNetCore.Components;

namespace BlazorDemo.Web.Pages.Components
{
    public partial class EmployeeDetailsModal : ComponentBase
    {
        [Parameter] public EmployeeViewModel SelectedEmployee { get; set; }
    }
}

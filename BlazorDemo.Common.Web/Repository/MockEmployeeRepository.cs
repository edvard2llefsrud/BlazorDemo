using BlazorDemo.Common.Web.ApiAccess;
using BlazorDemo.Common.Web.ViewModels;

namespace BlazorDemo.Common.Web.Repository;

public class MockEmployeeRepository : IMockEmployeeRepository
{
    private List<EmployeeViewModel> employees;

    public MockEmployeeRepository()
    {
        this.employees = new List<EmployeeViewModel>()
        {
            new()
            {
                FirstName = "Øyvind",
                LastName = "Sannerhaugen",
                Office = "Oslo",
                Title = "Senior Developer",
                EmployeeRating = 4,
                PreferedUiFramework = UiFramework.Blazor
            },
            new()
            {
                FirstName = "Borger",
                LastName = "Storholt",
                Office = "Oslo",
                Title = "Senior Developer",
                EmployeeRating = 5,
                PreferedUiFramework = UiFramework.React
            },
            new()
            {
                FirstName = "Edvard",
                LastName = "Tollefsrud",
                Office = "Oslo",
                Title = "Junior Developer",
                EmployeeRating = 2,
                PreferedUiFramework = UiFramework.Blazor
            }
        };
    }

    public async Task<ApiResult<List<EmployeeViewModel>>> GetEmployees()
    {
        await Task.Delay(5000);

        return new ApiResult<List<EmployeeViewModel>>(ApiMethodType.Get)
        {
            Result = employees
        };
    }


}
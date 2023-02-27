using BlazorDemo.Common.Web.ApiAccess;
using BlazorDemo.Common.Web.ViewModels;

namespace BlazorDemo.Common.Web.Repository;

public interface IMockEmployeeRepository
{
    Task<ApiResult<List<EmployeeViewModel>>> GetEmployees();
}
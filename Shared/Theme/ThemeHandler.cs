using BlazorDemo.Web.Shared.Theme.Triona;
using MudBlazor;

namespace BlazorDemo.Web.Shared.Theme;

public class ThemeHandler : IThemeHandler
{
    public MudTheme GetTheme()
    {
        return TrionaColors.GetTrionaTheme();
    }
}
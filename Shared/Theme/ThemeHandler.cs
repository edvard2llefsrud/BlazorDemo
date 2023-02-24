using BlazorDemo.Shared.Theme.Triona;
using MudBlazor;

namespace BlazorDemo.Shared.Theme;

public class ThemeHandler : IThemeHandler
{
    public MudTheme GetTheme()
    {
        return TrionaColors.GetTrionaLightModeTheme();
    }
}
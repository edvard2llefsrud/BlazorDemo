using BlazorDemo.Web.Shared.Theme;
using Microsoft.AspNetCore.Components;

namespace BlazorDemo.Web.Shared
{
    public partial class MainLayout 
    {
        [Inject] private IThemeHandler themeHandler { get; set; }

        bool open = false;

        void ToggleDrawer()
        {
            open = !open;
        }
    }
}

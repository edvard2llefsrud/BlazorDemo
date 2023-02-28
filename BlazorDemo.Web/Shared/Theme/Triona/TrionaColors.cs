using System.Drawing;
using MudBlazor;
using MudBlazor.Utilities;
using Color = System.Drawing.Color;

namespace BlazorDemo.Web.Shared.Theme.Triona;

public static class TrionaColors
{
    public static readonly Color TrionaRed         = ColorTranslator.FromHtml("#C62107");
    public static readonly Color Gray100           = ColorTranslator.FromHtml("#4D4D4D");
    public static readonly Color Gray80            = ColorTranslator.FromHtml("#717171");
    public static readonly Color Gray60            = ColorTranslator.FromHtml("#949494");
    public static readonly Color Gray40            = ColorTranslator.FromHtml("#B8B8B8");
    public static readonly Color Gray20            = ColorTranslator.FromHtml("#DBDBDB");
    public static readonly Color Gray10            = ColorTranslator.FromHtml("#EDEDED");
    public static readonly Color Gray5             = ColorTranslator.FromHtml("#F6F6F6");
    public static readonly Color Primary           = ColorTranslator.FromHtml("#65C8E6");
    public static readonly Color PrimaryVariant1   = ColorTranslator.FromHtml("#2286A4");
    public static readonly Color PrimaryVariant2   = ColorTranslator.FromHtml("#EBE7EB");
    public static readonly Color Secondary         = ColorTranslator.FromHtml("#DFD5BB");
    public static readonly Color SecondaryVariant1 = ColorTranslator.FromHtml("#A69F8B");
    public static readonly Color SecondaryVariant2 = ColorTranslator.FromHtml("#FCFAF3");
    public static readonly Color Background        = ColorTranslator.FromHtml("#FFFFFF");
    public static readonly Color Surface           = ColorTranslator.FromHtml("#FFFFFF");
    public static readonly Color TrionaErrorRed    = ColorTranslator.FromHtml("#C62107");
    public static readonly Color OnPrimary         = ColorTranslator.FromHtml("#FFFFFF");
    public static readonly Color OnSecondary       = ColorTranslator.FromHtml("#000000");
    public static readonly Color OnBackground      = ColorTranslator.FromHtml("#000000");
    public static readonly Color OnSurface         = ColorTranslator.FromHtml("#000000");
    public static readonly Color OnError           = ColorTranslator.FromHtml("#FFFFFF");
    public static readonly Color Success           = ColorTranslator.FromHtml("#0A9333");

    public static MudColor ToMudColor(Color c)
    {
        return new MudColor(c.R, c.G, c.B, c.A);
    }

    public static MudTheme GetTrionaTheme()
    {
        return new MudTheme()
        {
            Typography = new Typography() {Default = new Default() {FontFamily = new[] {"Roboto"}}},
            Palette = new Palette()
            {
                AppbarBackground      = ToMudColor(TrionaRed),
                AppbarText            = ToMudColor(OnPrimary),
                Primary               = ToMudColor(Primary),
                PrimaryContrastText   = ToMudColor(OnPrimary),
                Secondary             = ToMudColor(Secondary),
                SecondaryContrastText = ToMudColor(OnPrimary),
                Tertiary              = ToMudColor(SecondaryVariant1),
                TertiaryContrastText  = ToMudColor(OnSecondary),
                Info                  = ToMudColor(SecondaryVariant1),
                InfoContrastText      = ToMudColor(OnPrimary),
                Success               = ToMudColor(Gray80),

            },
            PaletteDark = new PaletteDark() {Primary = Colors.Blue.Lighten1},
            LayoutProperties = new LayoutProperties() {DrawerWidthLeft = "260px", DrawerWidthRight = "300px"}
        };
    }


}
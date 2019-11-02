using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace Wallpaper_Generator.Classes
{

    // z neta

    public sealed class SetWallpaper
    {
        SetWallpaper() { }

        const int SPI_SETDESKWALLPAPER = 20;
        const int SPIF_UPDATEINIFILE = 0x01;
        const int SPIF_SENDWININICHANGE = 0x02;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        public enum Style : int
        {
            //Center,
            //Tile,
            //Stretch,
            //Span,
            //Fit,
            Fill
        }

        public static void Set(Style style, string path)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);

            key.SetValue(@"WallpaperStyle", 10.ToString());
            key.SetValue(@"TileWallpaper", 0.ToString());

            SystemParametersInfo(SPI_SETDESKWALLPAPER,
                0,
                path,
                SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);

            //if (style == Style.Fill)
            //{
            //    key.SetValue(@"WallpaperStyle", 10.ToString());
            //    key.SetValue(@"TileWallpaper", 0.ToString());
            //}
            //if (style == Style.Fit)
            //{
            //    key.SetValue(@"WallpaperStyle", 6.ToString());
            //    key.SetValue(@"TileWallpaper", 0.ToString());
            //}
            //if (style == Style.Span)
            //{
            //    key.SetValue(@"WallpaperStyle", 22.ToString());
            //    key.SetValue(@"TileWallpaper", 0.ToString());
            //}
            //if (style == Style.Stretch)
            //{
            //    key.SetValue(@"WallpaperStyle", 2.ToString());
            //    key.SetValue(@"TileWallpaper", 0.ToString());
            //}
            //if (style == Style.Tile)
            //{
            //    key.SetValue(@"WallpaperStyle", 0.ToString());
            //    key.SetValue(@"TileWallpaper", 1.ToString());
            //}
            //if (style == Style.Center)
            //{
            //    key.SetValue(@"WallpaperStyle", 0.ToString());
            //    key.SetValue(@"TileWallpaper", 0.ToString());
            //}


        }
    }
}

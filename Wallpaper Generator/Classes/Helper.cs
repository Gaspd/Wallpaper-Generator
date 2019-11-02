using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallpaper_Generator.Classes
{
    public static class Helper
    {
        public static int ItemToInt(string Item)
        {
            int Time = Trim.StringToInt(Item);
            if (Item.Contains("sec"))
            {
                return Convert.ToInt32(TimeSpan.FromSeconds(Time).TotalMilliseconds);
            }
            else
            {
                return Convert.ToInt32(TimeSpan.FromMinutes(Time).TotalMilliseconds);
            }
        }

        public class Trim
        {
            public static int StringToInt(string Item)
            {
                return int.Parse(string.Concat(Item.Where(c => char.IsDigit(c)).ToArray()));
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_kfu_2
{
    public class TouchScroll
    {
        public static Dictionary<int,Image> img = new Dictionary<int,Image>();
        private static int i = 0;

        public static int Addd(Image image)
        {
            img.Add(i, image);
            
            return i;
            i++;
        }
    }
}

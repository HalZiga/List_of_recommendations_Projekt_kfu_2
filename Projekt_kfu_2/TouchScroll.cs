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
        private Point mouseDownPoint;
        private FlowLayoutPanel parentPanel;
        public TouchScroll(FlowLayoutPanel panel)
        {
            this.parentPanel = panel;
            AssignEvent(panel);
        }
        private void AssignEvent(Control control)
        {
            control.MouseDown += MouseDown;
            control.MouseMove += MouseMove;

            foreach(Control child in control.Controls) 
            {
                AssignEvent(child);
            }
        }

        private void MouseMove(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MouseDown(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}

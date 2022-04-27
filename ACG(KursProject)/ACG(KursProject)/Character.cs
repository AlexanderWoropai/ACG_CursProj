using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ACG_KursProject_
{
    class Character
    {
        protected PointF[] coordinates;
        public Character(PointF center) { }
        public virtual PointF[] GetCoordinates() 
        {
            return null;
        }
        public virtual PointF GetCoordinates(int index)
        {
            return new PointF();
        }
        public virtual void ChangeCoordinates(int index, PointF coordinates) { }
        public virtual void Paint(PaintEventArgs e) { }
        public virtual void PaintBorders(PaintEventArgs e) { }
    }
}

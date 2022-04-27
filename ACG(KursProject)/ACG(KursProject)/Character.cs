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
        protected PointF[] borderCoordinates;
        public Character(PointF center) { }
        public virtual PointF[] GetCoordinates() 
        {
            return null;
        }
        public virtual PointF[] GetBorders()
        {
            return null;
        }
        public virtual void ChangeCoordinates(PointF[] coordinates) { }
        public virtual void Paint(PaintEventArgs e) { }
        public virtual void PaintBorders(PaintEventArgs e) { }
    }
}

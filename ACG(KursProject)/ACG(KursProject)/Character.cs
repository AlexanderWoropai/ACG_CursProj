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
        public PointF[] GetCoordinates()
        {
            return coordinates;
        }
        public PointF GetCoordinates(int index)
        {
            return coordinates[index];
        }
        public void ChangeCoordinates(int index, PointF coordinates)
        {
            this.coordinates[index] = coordinates;
        }
        public virtual void Paint(PaintEventArgs e) { }
        public virtual void PaintBorders(PaintEventArgs e) { }
    }
}

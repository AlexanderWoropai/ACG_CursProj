using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ACG_KursProject_
{
    class Pentagon : Character
    {
        public Pentagon(PointF center) : base(center)
        {
            coordinates = new PointF[5];
            coordinates[0] = new PointF(center.X, center.Y-10);
            coordinates[1] = new PointF(center.X - 10, center.Y);
            coordinates[2] = new PointF(center.X - 5, center.Y+10);
            coordinates[3] = new PointF(center.X + 5, center.Y+10);
            coordinates[4] = new PointF(center.X + 10, center.Y);
        }
        public override void Paint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            var Coordinates = GetCoordinates();
            g.DrawPolygon(new Pen(Color.Black), Coordinates);
        }
    }
}

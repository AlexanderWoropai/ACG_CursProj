using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ACG_KursProject_
{
    class Triangle : Character
    {
        public Triangle(PointF center) : base(center)
        {
            coordinates = new PointF[3];
            coordinates[0] = new PointF(center.X, center.Y - 10);
            coordinates[1] = new PointF(center.X - 10, center.Y + 10);
            coordinates[2] = new PointF(center.X + 10, center.Y + 10);
        }
        public override void Paint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            var Coordinates = GetCoordinates();
            g.DrawPolygon(new Pen(Color.Black), Coordinates);
        }
    }
}

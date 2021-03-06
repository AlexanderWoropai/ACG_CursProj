using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ACG_KursProject_
{
    class Rectangle : Character
    {
        public Rectangle(PointF center) : base(center)
        {
            coordinates = new PointF[2];
            coordinates[0] = new PointF(center.X - 10, center.Y - 10);
            coordinates[1] = new PointF(center.X + 10, center.Y + 10);
            this.center = center;
        }
        public override void Paint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            var Coordinates = GetCoordinates();
            g.DrawRectangles(new Pen(Color.Black), new RectangleF[] { new RectangleF(Coordinates[0].X, Coordinates[0].Y, Math.Abs(Coordinates[0].X - Coordinates[1].X), Math.Abs(Coordinates[0].Y - Coordinates[1].Y)) });
        }
        public override void PaintBorders(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            var Coordinates = GetCoordinates();
            g.DrawPolygon(new Pen(Color.Red), Coordinates);
        }
    }
}

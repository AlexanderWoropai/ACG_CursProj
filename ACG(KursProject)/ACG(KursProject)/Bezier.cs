using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ACG_KursProject_
{
    class Bezier : Character
    {
        public Bezier(PointF center) : base(center)
        {
            coordinates = new PointF[4];
            coordinates[0] = new PointF(center.X - 20, center.Y + 10);
            coordinates[1] = new PointF(center.X - 10, center.Y);
            coordinates[2] = new PointF(center.X + 10, center.Y);
            coordinates[3] = new PointF(center.X + 20, center.Y + 10);
        }
        public override void Paint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            var Coordinates = GetCoordinates();
            g.DrawBezier(new Pen(Color.Black), Coordinates[0], Coordinates[1], Coordinates[2], Coordinates[3]);
        }
        public override void PaintBorders(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            var borderCoordinates = GetCoordinates();
            g.DrawPolygon(new Pen(Color.Red), borderCoordinates);
        }
    }
}

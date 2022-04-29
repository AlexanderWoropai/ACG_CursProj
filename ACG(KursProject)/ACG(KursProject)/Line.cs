using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ACG_KursProject_
{
    class Line : Character
    {
        public Line(PointF center) : base(center) 
        {
            coordinates = new PointF[2];
            coordinates[0] = new PointF(center.X - 10, center.Y);
            coordinates[1] = new PointF(center.X + 10, center.Y);
            this.center = center;
        }
        public override void Paint(PaintEventArgs e) 
        {
            Graphics g = e.Graphics;
            var Coordinates = GetCoordinates();
            g.DrawLine(new Pen(Color.Black), Coordinates[0], Coordinates[1]);
        }
    }
}

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
        }
        public override PointF[] GetCoordinates()
        {
            return coordinates;
        }
        public override PointF GetCoordinates(int index)
        {
            return coordinates[index];
        }
        public override void ChangeCoordinates(int index, PointF coordinates)
        {
            this.coordinates[index] = coordinates;
        }
        public override void Paint(PaintEventArgs e) 
        {
            var pen = new Pen(Color.Black);
            pen.Width = 2;
            Graphics g = e.Graphics;
            var Coordinates = GetCoordinates();
            g.DrawLine(pen, Coordinates[0], Coordinates[1]);
        }
        public override void PaintBorders(PaintEventArgs e)
        {
            var pen = new Pen(Color.Red);
            pen.Width = 1;
            Graphics g = e.Graphics;
            var borderCoordinates = GetCoordinates();
            g.DrawPolygon(pen, borderCoordinates);
        }
    }
}

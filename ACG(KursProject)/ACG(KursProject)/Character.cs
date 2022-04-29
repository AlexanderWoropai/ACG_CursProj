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
        protected PointF center;
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
        public PointF GetCenter() 
        {
            return center;
        }
        public void ChangeCoordinates(int index, PointF newCoordinates)
        {
            this.coordinates[index] = newCoordinates;
            float sumX = 0;
            float sumY = 0;
            for (int i = 0; i < coordinates.Length; i++) 
            {
                sumX += coordinates[i].X;
                sumY += coordinates[i].Y;
            }
            this.center = new PointF(sumX / coordinates.Length, sumY / coordinates.Length);
        }
        public void MoveAllCoordinatesTo(PointF destination) 
        {
            var difX = center.X - destination.X;
            var difY = center.Y - destination.Y;
            for (int i = 0; i < coordinates.Length; i++) 
            {
                coordinates[i].X -= difX;
                coordinates[i].Y -= difY;
            }
            this.center = destination;
        }
        public virtual void Paint(PaintEventArgs e) { }
        public virtual void PaintBorders(PaintEventArgs e) { }
    }
}

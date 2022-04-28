using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ACG_KursProject_
{
    class CharacterFactory
    {
        public Character Create(string type, PointF center) 
        {
            if (type == "Line") return new Line(center);
            if (type == "Ellipse") return new Ellipse(center);
            if (type == "Bezier") return new Bezier(center);
            if (type == "Rectangle") return new Rectangle(center);
            if (type == "Triangle") return new Triangle(center);
            if (type == "Pentagon") return new Pentagon(center);
            if (type == "Hexagon") return new Hexagon(center);
            return null;
        }
    }
}

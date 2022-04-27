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
            return null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea
{
    public class Circle : IFigure//Circle class.
    {
        public int R { get; set; }//The radius property.
        public Circle(int r)//Constructor
        {
            R = r;
        }
        public Circle() { }//The default constructor.
        public double GetArea()//The method of finding the area of the circle.
        {
            return 3.14 * R * R;
        }
    }
}

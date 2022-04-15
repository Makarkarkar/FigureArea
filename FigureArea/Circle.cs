using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea
{
    public class Circle : IFigure//Класс круга.
    {
        public int R { get; set; }//Свойство радиуса.
        public Circle(int r)//Конструктор.
        {
            R = r;
        }
        public Circle() { }//Конструктор по умолчанию.
        public double GetArea()//Метод нахождения площади круга.
        {
            return 3.14 * R * R;
        }
    }
}

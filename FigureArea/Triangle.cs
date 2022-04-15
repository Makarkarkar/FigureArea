namespace FigureArea
{
    public class Triangle : IFigure //Класс треугольника.
    {
        public Triangle() {  }//Конструктор по умолчанию.
        public int A { get; set; }//Свойство стороны А.
        public int B { get; set; }//Свойство стороны В.
        public int C { get; set; }//Свойство стороны С.

        public Triangle(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;    
        }
       
        public double GetArea()//Метод нахождения площади треугольника, возвращает значения с точностью в два знака после запятой.
        {
            double p = (A + B + C)/2;
            return Math.Round(Math.Sqrt(p * (p - A) * (p - B) * (p - C)),2);
        }
        public bool RightTriangle()//Булевый проверки на равнобедренность.
        {
            int sqA = A*A;
            int sqB = B*B;
            int sqC = C*C;
            if (sqA == (sqB + sqC) ||
                sqB == (sqA + sqC) ||
                sqC == (sqA + sqB))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
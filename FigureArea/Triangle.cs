namespace FigureArea
{
    public class Triangle : IFigure //Triangle class.
    {
        public Triangle() {  }//The default constructor.
        public int A { get; set; }//Property of side A.
        public int B { get; set; }//Property of side B.
        public int C { get; set; }//Property of side C.

        public Triangle(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;    
        }
       
        public double GetArea()//The method of finding the area of a triangle, returns values with an accuracy of two decimal places.
        {
            double p = (A + B + C)/2;
            return Math.Round(Math.Sqrt(p * (p - A) * (p - B) * (p - C)),2);
        }
        public bool RightTriangle()//Boolean checks for squareness.
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
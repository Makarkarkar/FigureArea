using FigureArea;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FigureAreaTest
{
    [TestClass]
    public class UnitTest
    {
  
        Triangle triangle1 = new Triangle(4, 5, 3);
        Triangle triangle2 = new Triangle(7, 6, 3);
        Triangle triangle3 = new Triangle(5, 12, 13);
        Circle circle1 = new Circle(5);

        [TestMethod]
        public void GetAreaTestFrstTriagle()//Тестовый метод для проверки правильности нахождения площади.
        {
            double expectationTriangle1 = 6;//Ожидаемая площадь.
            double resultTriangle1 = triangle1.GetArea();//Фактическая площадь.
            Assert.AreEqual(expectationTriangle1, resultTriangle1, "Ожидаемая площадь первого треугольника не равна фактической");//Если ожидания не совпали с действительностью, выведется исключение.
        }
        [TestMethod]
        public void GetAreaTestSecondTriagle() 
        { 
            double expectationTriangle2 = 8.94;
            double resultTriangle2 = triangle2.GetArea();
            Assert.AreEqual(expectationTriangle2, resultTriangle2, "Ожидаемая площадь второго треугольника не равна фактической");
        }
        [TestMethod]
        public void GetAreaTestThirdTriagle()//Неверный
        {
            double expectationTriangle3 = 301;
            double resultTriangle3 = triangle3.GetArea();
            Assert.AreEqual(expectationTriangle3, resultTriangle3, "Ожидаемая площадь третьего треугольника не равна фактической"); 
        }
        [TestMethod]
        public void GetAreaTestCircle() 
        {
            double expectationCircle1 = 78.5;
            double resultCircle1 = circle1.GetArea();
            Assert.AreEqual(expectationCircle1, resultCircle1, "Ожидаемая площадь первого круга не равна фактической"); 
        }
     
        [TestMethod]
        public void RightFirstTriangleTest()//Тестовый метод для проверки прямоугольности треугольника.
        {
            Assert.IsTrue(triangle1.RightTriangle(), "Треугольник не равнобедренный");//Если треугольник не прямоугольный, выведется исключение.
        }
        [TestMethod]
        public void RightSecondTriangleTest()//Неверный
        {
            Assert.IsTrue(triangle2.RightTriangle(), "Треугольник не равнобедренный");
        }
        [TestMethod]
        public void RightThirdTriangleTest()
        {
            Assert.IsTrue(triangle3.RightTriangle(), "Треугольник не равнобедренный");
        }
}
}
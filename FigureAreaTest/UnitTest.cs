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
        public void GetAreaTestFrstTriangle()//A test method for verifying the correctness of finding the area.
        {
            double expectationTriangle1 = 6;//Expected area.
            double resultTriangle1 = triangle1.GetArea();//The actual area.

            Assert.AreEqual(expectationTriangle1, resultTriangle1, "The expected area of the first triangle is not equal to the actual");//If the expectations do not match the reality, an exception will be thrown.
        }
        [TestMethod]
        public void GetAreaTestSecondTriangle() 
        { 
            double expectationTriangle2 = 8.94;
            double resultTriangle2 = triangle2.GetArea();
            Assert.AreEqual(expectationTriangle2, resultTriangle2, "The expected area of the second triangle is not equal to the actual");
        }
        [TestMethod]
        public void GetAreaTestThirdTriangle()//Incorrect.
        {
            double expectationTriangle3 = 301;
            double resultTriangle3 = triangle3.GetArea();
            Assert.AreEqual(expectationTriangle3, resultTriangle3, "The expected area of the third triangle is not equal to the actual"); 
        }
        [TestMethod]
        public void GetAreaTestCircle() 
        {
            double expectationCircle1 = 78.5;
            double resultCircle1 = circle1.GetArea();
            Assert.AreEqual(expectationCircle1, resultCircle1, "The expected area of the first circle is not equal to the actual"); 
        }
     
        [TestMethod]
        public void RightFirstTriangleTest()//A test method for checking the squareness of a triangle.
        {
            Assert.IsTrue(triangle1.RightTriangle(), "The triangle is not rectangular.");//Åñëè òðåóãîëüíèê íå ïðÿìîóãîëüíûé, âûâåäåòñÿ èñêëþ÷åíèå.
        }
        [TestMethod]
        public void RightSecondTriangleTest()//Incorrect.
        {
            Assert.IsTrue(triangle2.RightTriangle(), "The triangle is not rectangular.");
        }
        [TestMethod]
        public void RightThirdTriangleTest()
        {
            Assert.IsTrue(triangle3.RightTriangle(), "The triangle is not rectangular.");
        }
}
}

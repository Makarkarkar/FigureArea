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
        public void GetAreaTestFrstTriagle()//�������� ����� ��� �������� ������������ ���������� �������.
        {
            double expectationTriangle1 = 6;//��������� �������.
            double resultTriangle1 = triangle1.GetArea();//����������� �������.
            Assert.AreEqual(expectationTriangle1, resultTriangle1, "��������� ������� ������� ������������ �� ����� �����������");//���� �������� �� ������� � �����������������, ��������� ����������.
        }
        [TestMethod]
        public void GetAreaTestSecondTriagle() 
        { 
            double expectationTriangle2 = 8.94;
            double resultTriangle2 = triangle2.GetArea();
            Assert.AreEqual(expectationTriangle2, resultTriangle2, "��������� ������� ������� ������������ �� ����� �����������");
        }
        [TestMethod]
        public void GetAreaTestThirdTriagle()//��������
        {
            double expectationTriangle3 = 301;
            double resultTriangle3 = triangle3.GetArea();
            Assert.AreEqual(expectationTriangle3, resultTriangle3, "��������� ������� �������� ������������ �� ����� �����������"); 
        }
        [TestMethod]
        public void GetAreaTestCircle() 
        {
            double expectationCircle1 = 78.5;
            double resultCircle1 = circle1.GetArea();
            Assert.AreEqual(expectationCircle1, resultCircle1, "��������� ������� ������� ����� �� ����� �����������"); 
        }
     
        [TestMethod]
        public void RightFirstTriangleTest()//�������� ����� ��� �������� ��������������� ������������.
        {
            Assert.IsTrue(triangle1.RightTriangle(), "����������� �� ��������������");//���� ����������� �� �������������, ��������� ����������.
        }
        [TestMethod]
        public void RightSecondTriangleTest()//��������
        {
            Assert.IsTrue(triangle2.RightTriangle(), "����������� �� ��������������");
        }
        [TestMethod]
        public void RightThirdTriangleTest()
        {
            Assert.IsTrue(triangle3.RightTriangle(), "����������� �� ��������������");
        }
}
}
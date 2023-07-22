using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AreaLib;

namespace AreaLibTest
{
    [TestClass]
    public class UnitTestAreaLib
    {
        /// <summary>
        /// Вычисление площади круга с корректными значениями.
        /// </summary>
        [TestMethod]
        public void TestCorrectCalculateAreaCircle()
        {
            Figure figure = new Figure(5);
            Assert.AreEqual(78.5398163397448, figure.GetArea(), 0.0001);
        }
        /// <summary>
        /// Вычисление площади круга с некорректными значениями.
        /// </summary>
        [TestMethod]
        public void TestInCorrectCalculateAreaCircle()
        {
            Figure figure = new Figure(-5);
            Assert.ThrowsException<ArgumentException> (() => figure.GetArea());
        }
        /// <summary>
        /// Вычисление площади прямоугольного треугольника с корректными значениями.
        /// </summary>
        [TestMethod]
        public void TestCorrectCalculateAreaRectangularTriangle()
        {
            Figure figure = new Figure(8, 8, 8);
            Assert.AreEqual(27.712812921102, figure.GetArea(), 0.0001);
        }
        /// <summary>
        /// Вычисление площади прямоугольного треугольника с некорректными значениями.
        /// </summary>
        [TestMethod]
        public void TestInCorrectCalculateAreaRectangularTriangle()
        {
            Figure figure = new Figure(-8, 8, 8);
            Assert.ThrowsException<ArgumentException>(() => figure.GetArea());
        }
        /// <summary>
        /// Вычисление площади непрямоугольного треугольника с корректными значениями.
        /// </summary>
        [TestMethod]
        public void TestCorrectCalculateAreaTriangle()
        {
            Figure figure = new Figure(4, 3, 6);
            Assert.AreEqual(5.33268225192539, figure.GetArea(), 0.0001);
        }
        /// <summary>
        /// Вычисление площади треугольника, которого не существует.
        /// </summary>
        [TestMethod]
        public void TestInCorrectCalculateAreaNotExistsTriangle()
        {
            Figure figure = new Figure(4, 1, 6);
            Assert.ThrowsException<ArgumentException>(() => figure.GetArea());
        }
        /// <summary>
        /// Вычисление площади квадрата с корректными значениями.
        /// </summary>
        [TestMethod]
        public void TestCorrectCalculateAreaSquare()
        {
            Figure figure = new Figure(4, 4);
            Assert.AreEqual(16, figure.GetArea());
        }
        /// <summary>
        /// Вычисление площади квадрата с некорректными значениями.
        /// </summary>
        [TestMethod]
        public void TestInCorrectCalculateAreaSquare()
        {
            Figure figure = new Figure(-8, 4);
            Assert.ThrowsException<ArgumentException>(() => figure.GetArea());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorldNomadsGroup;
using WorldNomadsGroup.Controllers;

namespace WorldNomadsGroup.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void TestFibFunction()
        {
            var controller = new HomeController();
            var result = new List<int>();
            result.Add(1);
            result.Add(1);
            result.Add(2);
            result.Add(3);
            result.Add(5);
            result.Add(8);
            result.Add(13);
            CollectionAssert.AreEqual(result, controller.Fibonacci(13));
        }
        [TestMethod]
        public void TestBigFib()
        {
            var controller = new HomeController();
            var result = new List<int>();
            result.Add(1);
            result.Add(1);
            result.Add(2);
            result.Add(3);
            result.Add(5);
            result.Add(8);
            result.Add(13);
            result.Add(21);
            result.Add(34);
            result.Add(55);
            result.Add(89);
            result.Add(144);
            result.Add(233);
            result.Add(377);
            result.Add(610);
            result.Add(987);
            result.Add(1597);
            result.Add(2584);
            result.Add(4181);
            result.Add(6765);
            result.Add(10946);
            result.Add(17711);
            result.Add(28657);
            result.Add(46368);
            result.Add(75025);
            result.Add(121393);
            result.Add(196418);
            result.Add(317811);
            CollectionAssert.AreEqual(result, controller.Fibonacci(317812));
        }
        [TestMethod]
        public void Count()
        {
            var controller = new HomeController();
            var result = new List<int>();  
            result.Add(1);
            result.Add(2);
            result.Add(3);
            result.Add(4);
            result.Add(5);
            result.Add(6);
            result.Add(7);
            result.Add(8);
            result.Add(9);
            result.Add(10);
            result.Add(11);
            result.Add(12);
            result.Add(13);
            result.Add(14);
            result.Add(15);
            result.Add(16);
            result.Add(17);
            result.Add(18);
            CollectionAssert.AreEqual(result, controller.ReturnAllNumbers(18));
        }
        [TestMethod]
        public void Even()
        {
            var controller = new HomeController();
            var result = new List<int>();
            result.Add(2);
            result.Add(4);
            result.Add(6);
            result.Add(8);
            result.Add(10);
            result.Add(12);
            result.Add(14);
            result.Add(16);
            result.Add(18);
            result.Add(20);
            result.Add(22);
            result.Add(24);
            result.Add(26);
            result.Add(28);
            result.Add(30);
            result.Add(32);
            result.Add(34);
            result.Add(36);
            CollectionAssert.AreEqual(result, controller.ReturnEvenNumbers(37));
        }
        [TestMethod]
        public void Odd()
        {
            var controller = new HomeController();
            var result = new List<int>();
            result.Add(1);
            result.Add(3);
            result.Add(5);
            result.Add(7);
            result.Add(9);
            result.Add(11);
            result.Add(13);
            result.Add(15);
            result.Add(17);
            result.Add(19);
            result.Add(21);
            result.Add(23);
            result.Add(25);
            result.Add(27);
            result.Add(29);
            result.Add(31);
            result.Add(33);
            result.Add(35);
            result.Add(37);
            CollectionAssert.AreEqual(result, controller.ReturnOddNumbers(38));
        }
        [TestMethod]
        public void ComplexSeries()
        {
            var controller = new HomeController();
            var result = new List<string>();
            result.Add("1");                
            result.Add("2");
            result.Add("C");
            result.Add("4");
            result.Add("E");
            result.Add("C");
            result.Add("7");
            result.Add("8");
            result.Add("C");
            result.Add("E");
            result.Add("11");
            result.Add("C");
            result.Add("13");
            result.Add("14");
            result.Add("Z");
            result.Add("16");
            result.Add("17");
            result.Add("C");
            result.Add("19");
            result.Add("E");
            result.Add("C");
            result.Add("22");
            result.Add("23");
            result.Add("C");
            result.Add("E");
            result.Add("26");
            result.Add("C");
            result.Add("28");
            result.Add("29");
            result.Add("Z");
            result.Add("31");
            result.Add("32");
            result.Add("C");
            result.Add("34");
            result.Add("E");
            result.Add("C");
            result.Add("37");
            result.Add("38");
            result.Add("C");
            result.Add("E");
            CollectionAssert.AreEqual(result, controller.ReturnComplexSequence(40));
        }
    }
}                  

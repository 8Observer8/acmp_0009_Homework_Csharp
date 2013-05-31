using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using acmp_0009_Homework_Csharp;

namespace UnitTestHomework
{
    [TestClass]
    public class UnitTestHomework
    {
        [TestMethod]
        public void TestHomework()
        {
            List<int> inputArr = new List<int>();
            inputArr.Add(-7);
            inputArr.Add(5);
            inputArr.Add(-1);
            inputArr.Add(3);
            inputArr.Add(9);

            int sum = 0;
            int product = 0;
            int expectedSum = 17;
            int expectedProduct = -15;

            Homework h = new Homework();
            h.homework(ref inputArr, ref sum, ref product);

            Assert.AreEqual(expectedSum, sum);
            Assert.AreEqual(expectedProduct, sum);
        }

        [TestMethod]
        public void TestHomework_01()
        {
            List<int> inputArr = new List<int>();
            inputArr.Add(3);
            inputArr.Add(14);
            inputArr.Add(-9);
            inputArr.Add(4);
            inputArr.Add(-5);
            inputArr.Add(1);
            inputArr.Add(12);
            inputArr.Add(-4);

            int sum = 0;
            int product = 0;
            int expectedSum = 26;
            int expectedProduct = 180;

            Homework h = new Homework();
            h.homework(ref inputArr, ref sum, ref product);

            Assert.AreEqual(expectedSum, sum);
            Assert.AreEqual(expectedProduct, sum);
        }

        [TestMethod]
        public void TestHomework_02()
        {
            List<int> inputArr = new List<int>();
            inputArr.Add(-5);
            inputArr.Add(1);
            inputArr.Add(2);
            inputArr.Add(3);
            inputArr.Add(4);
            inputArr.Add(5);
            inputArr.Add(6);
            inputArr.Add(7);
            inputArr.Add(8);
            inputArr.Add(-3);

            int sum = 0;
            int product = 0;
            int expectedSum = 36;
            int expectedProduct = 5040;

            Homework h = new Homework();
            h.homework(ref inputArr, ref sum, ref product);

            Assert.AreEqual(expectedSum, sum);
            Assert.AreEqual(expectedProduct, sum);
        }

        [TestMethod]
        public void TestHomework_AllTheSame()
        {
            List<int> inputArr = new List<int>();
            inputArr.Add(7);
            inputArr.Add(7);
            inputArr.Add(7);
            inputArr.Add(7);
            inputArr.Add(7);
            inputArr.Add(7);
            inputArr.Add(7);
            inputArr.Add(7);

            int sum = 0;
            int product = 0;
            int expectedSum = 17;
            int expectedProduct = 0;

            Homework h = new Homework();
            h.homework(ref inputArr, ref sum, ref product);

            Assert.AreEqual(expectedSum, sum);
            Assert.AreEqual(expectedProduct, sum);
        }

        [TestMethod]
        public void TestHomework_MinAfterMax()
        {
            List<int> inputArr = new List<int>();
            inputArr.Add(9);
            inputArr.Add(5);
            inputArr.Add(-1);
            inputArr.Add(3);
            inputArr.Add(-7);

            int sum = 0;
            int product = 0;
            int expectedSum = 17;
            int expectedProduct = -15;

            Homework h = new Homework();
            h.homework(ref inputArr, ref sum, ref product);

            Assert.AreEqual(expectedSum, sum);
            Assert.AreEqual(expectedProduct, sum);
        }

        [TestMethod]
        public void TestHomework_MinAndMaxAreLocatedNear()
        {
            List<int> inputArr = new List<int>();
            inputArr.Add(5);
            inputArr.Add(-1);
            inputArr.Add(3);
            inputArr.Add(-7);
            inputArr.Add(9);

            int sum = 0;
            int product = 0;
            int expectedSum = 17;
            int expectedProduct = 0;

            Homework h = new Homework();
            h.homework(ref inputArr, ref sum, ref product);

            Assert.AreEqual(expectedSum, sum);
            Assert.AreEqual(expectedProduct, sum);
        }

        [TestMethod]
        public void TestHomework_MinIsAfterAndNearOfMax()
        {
            List<int> inputArr = new List<int>();
            inputArr.Add(5);
            inputArr.Add(-1);
            inputArr.Add(3);
            inputArr.Add(9);
            inputArr.Add(-7);

            int sum = 0;
            int product = 0;
            int expectedSum = 17;
            int expectedProduct = -15;

            Homework h = new Homework();
            h.homework(ref inputArr, ref sum, ref product);

            Assert.AreEqual(expectedSum, sum);
            Assert.AreEqual(expectedProduct, sum);
        }

        [TestMethod]
        public void TestHomework()
        {
            List<int> inputArr = new List<int>();
            inputArr.Add(101);
            inputArr.Add(5);
            inputArr.Add(-1);
            inputArr.Add(3);
            inputArr.Add(9);

            int sum = 0;
            int product = 0;

            Homework h = new Homework();
            h.homework(ref inputArr, ref sum, ref product);

            
        }
    }
}

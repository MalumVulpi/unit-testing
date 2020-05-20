using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyIntLibrary.Test
{
    [TestClass]
    public class MyIntTest
    {
        [TestMethod]
        public void add_20and30_50returnned()
        {
            // arrange
            MyInt x = new MyInt(20);
            MyInt y = new MyInt(30);
            int expected = 50;

            // act
            MyInt actual = x.add(y);

            // assert
            Assert.AreEqual(expected, Int32.Parse(actual.number.ToString()));
        }

        [TestMethod]
        public void add_5and5_10returnnedByte()
        {
            // arrange
            MyInt x = new MyInt(0b101);
            MyInt y = new MyInt(0b101);
            int expected = 10;

            // act
            MyInt actual = x.add(y);

            // assert
            Assert.AreEqual(expected, Int32.Parse(actual.number.ToString()));
        }

        [TestMethod]
        public void subtract_50and40_10returnned()
        {
            // arrange
            MyInt x = new MyInt(50);
            MyInt y = new MyInt(40);
            int expected = 10;

            // act
            MyInt actual = x.subtract(y);

            // assert
            Assert.AreEqual(expected, Int32.Parse(actual.number.ToString()));
        }

        [TestMethod]
        public void multiply_5and5_25returnned()
        {
            // arrange
            MyInt x = new MyInt(5);
            MyInt y = new MyInt(5);
            int expected = 25;

            // act
            MyInt actual = x.multiply(y);

            // assert
            Assert.AreEqual(expected, Int32.Parse(actual.number.ToString()));
        }

        [TestMethod]
        public void divide_10and5_2returnned()
        {
            // arrange
            MyInt x = new MyInt(10);
            MyInt y = new MyInt(5);
            int expected = 2;

            // act
            MyInt actual = x.divide(y);

            // assert
            Assert.AreEqual(expected, Int32.Parse(actual.number.ToString()));
        }

        [TestMethod]
        public void max_10and2_5returnned()
        {
            // arrange
            MyInt x = new MyInt(10);
            MyInt y = new MyInt(2);
            int expected = 10;

            // act
            MyInt actual = x.max(y);

            // assert
            Assert.AreEqual(expected, Int32.Parse(actual.number.ToString()));
        }

        [TestMethod]
        public void min_25and5_2returnned()
        {
            // arrange
            MyInt x = new MyInt(25);
            MyInt y = new MyInt(5);
            int expected = 5;

            // act
            MyInt actual = x.min(y);

            // assert
            Assert.AreEqual(expected, Int32.Parse(actual.number.ToString()));
        }

        [TestMethod]
        public void abs_4return()
        {
            // arrange
            MyInt x = new MyInt(-4);
            int expected = 4;

            // act
            MyInt actual = x.abs();

            // assert
            Assert.AreEqual(expected, Int32.Parse(actual.number.ToString()));
        }

        [TestMethod]
        public void CompareTo_1and1_true_returned()
        {
            // arrange
            MyInt x = new MyInt(1);
            MyInt y = new MyInt(1);
            Boolean expected = true;

            // act
            MyInt actual = x.compareTo(y);

            // assert
            Assert.AreEqual(expected, Convert.ToBoolean(actual.number.ToString()));
        }

        [TestMethod]
        public void gcd_9and3_3returned()
        {
            // arrange
            MyInt x = new MyInt(9);
            MyInt y = new MyInt(3);
            int expected = 3;

            // act
            MyInt actual = x.gcd(y);

            // assert
            Assert.AreEqual(expected, Int32.Parse(actual.number.ToString()));
        }
    }
}

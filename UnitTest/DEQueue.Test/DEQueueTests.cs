using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DEQueue.Test
{
    [TestClass()]
    public class DEQueueTests
    {
        [TestMethod()]
        public void pushBackTest_MarkAndAlisa_AlisaReturn()
        {
            // arrange
            DEQueue<string> queue = new DEQueue<string>();
            string expected = "Alisa";

            // act
            queue.pushFront("Mark");
            queue.pushFront("Azat");
            queue.pushBack("Alisa");

            // assert
            Assert.AreEqual(expected, queue.back);
        }

        [TestMethod()]
        public void pushFrontTest_MarkAndAlisa_AlisaReturn()
        {
            // arrange
            DEQueue<string> queue = new DEQueue<string>();
            string expected = "Alisa";

            // act
            queue.pushBack("Mark");
            queue.pushBack("Azat");
            queue.pushFront("Alisa");

            // assert
            Assert.AreEqual(expected, queue.front);
        }

        [TestMethod()]
        public void popFrontTest_MarkAndAlisa_AlisaReturn()
        {
            // arrange
            DEQueue<string> queue = new DEQueue<string>();
            string expected = "Alisa";

            // act
            queue.pushBack("Mark");
            queue.pushFront("Alisa");
            queue.pushFront("Kate");
            queue.popFront();

            // assert
            Assert.AreEqual(expected, queue.front);
        }

        [TestMethod()]
        public void popBackTest_MarkAndAlisa_MarkReturn()
        {
            // arrange
            DEQueue<string> queue = new DEQueue<string>();
            string expected = "Mark";

            // act
            queue.pushBack("Mark");
            queue.pushBack("Alisa");
            queue.pushFront("Kate");
            queue.popBack();

            // assert
            Assert.AreEqual(expected, queue.back);
        }

        [TestMethod()]
        public void ClearTes_MarkAndAlisa_MarkReturnt()
        {
            // arrange
            DEQueue<string> queue = new DEQueue<string>();
            string expected = "Mark";

            // act
            queue.pushBack("Alisa");
            queue.pushBack("Azat");
            queue.Clear();

            queue.pushBack("Mark");

            // assert
            Assert.AreEqual(expected, queue.back);
        }

    }
}

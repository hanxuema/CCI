using Microsoft.VisualStudio.TestTools.UnitTesting;
using CCI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCI.Tests
{
    [TestClass()]
    public class LinkedListTests
    {
        [TestMethod()]
        public void AddFirstTest()
        {
            var linkedList = new LinkedList<int>();
            linkedList.AddFirst(1);
            Assert.AreEqual(linkedList.Head.Value, 1);
            Assert.AreEqual(linkedList.Head.Next, null);

            Assert.AreEqual(linkedList.Tail, linkedList.Head);
            Assert.AreEqual(linkedList.Count, 1);

            linkedList.AddFirst(2);
            Assert.AreEqual(linkedList.Head.Value, 2);
            Assert.AreEqual(linkedList.Head.Next.Value, 1);

            Assert.AreEqual(linkedList.Tail.Value, 1);
            Assert.AreEqual(linkedList.Count, 2);

        }

        [TestMethod()]
        public void AddLastTest()
        {
            var linkedList = new LinkedList<int>();
            linkedList.AddLast(1);
            Assert.AreEqual(linkedList.Head.Value, 1);
            Assert.AreEqual(linkedList.Head.Next, null);

            Assert.AreEqual(linkedList.Tail, linkedList.Head);
            Assert.AreEqual(linkedList.Count, 1);

            linkedList.AddLast(2);
            Assert.AreEqual(linkedList.Head.Value, 1);
            Assert.AreEqual(linkedList.Head.Next.Value, 2);

            Assert.AreEqual(linkedList.Tail.Value, 2);
            Assert.AreEqual(linkedList.Count, 2);

        }

        [TestMethod()]
        public void RemoveFirstTest()
        {
            var linkedList = new LinkedList<int>();
            linkedList.Add(1);
            Assert.AreEqual(linkedList.Count, 1);
            linkedList.Add(2);
            Assert.AreEqual(linkedList.Count, 2);
            linkedList.RemoveFirst();
            Assert.AreEqual(linkedList.Count, 1);
        }

        [TestMethod()]
        public void RemoveLastTest()
        {

        }

        [TestMethod()]
        public void PrintListTest()
        {

        }

        [TestMethod()]
        public void AddTest()
        {

        }

        [TestMethod()]
        public void ClearTest()
        {
            var linkedList = new LinkedList<int>();
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Clear();
            Assert.AreEqual(linkedList.Count, 0);

        }

        [TestMethod()]
        public void ContainsTest()
        {

        }

        [TestMethod()]
        public void CopyToTest()
        {
        
        }

        [TestMethod()]
        public void RemoveTest()
        {

        }

        [TestMethod()]
        public void GetEnumeratorTest()
        {

        }
    }
}
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
    public class QueueTests
    {
        [TestMethod()]
        public void AddTest()
        {
            var q = new Queue<int>();
            Assert.IsTrue(q.isEmpty());

            q.Add(1);
            Assert.IsFalse(q.isEmpty());
        }

        [TestMethod()]
        public void RemoveTest()
        {

        }

        [TestMethod()]
        public void PeekTest()
        {
            var q = new Queue<int>();
            Exception expectedExcetpion = null;
            try
            {
                q.Peek();
            }
            catch (Exception ex)
            {
                expectedExcetpion = ex;
            }

            // Assert
            Assert.IsNotNull(expectedExcetpion);

            q.Add(1);
            Assert.AreEqual(q.Peek().data, 1);
        }

        [TestMethod()]
        public void isEmptyTest()
        {
            var q = new Queue<int>();
            Assert.IsTrue(q.isEmpty());

            q.Add(1);
            Assert.IsFalse(q.isEmpty());
        }
    }
}
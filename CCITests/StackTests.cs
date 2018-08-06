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
    public class StackTests
    {
        [TestMethod()]
        public void PopShouldThrowExceptionIfStackIsEmpty()
        {
            var s = new Stack<int>();
            Exception expectedExcetpion = null;
            try
            {
                s.Pop();
            }
            catch (Exception ex)
            {
                expectedExcetpion = ex;
            }

            // Assert
            Assert.IsNotNull(expectedExcetpion);
        }

        [TestMethod()]
        public void PopShouldRemoveTopItemAnd()
        {
            var s = new Stack<int>();
            for (int i = 0; i < 100; i++)
            {
                s.Push(i); 
            }
            for (int i = 99; i >=0; i--)
            {
                var item = s.Pop(); 
                Assert.AreEqual(item, i);
            }
        }

        [TestMethod()]
        public void PushShouldAddItemToStack()
        {
            var s = new Stack<int>();
            Assert.AreEqual(s.IsEmpty(), true);
            s.Push(1);
            Assert.AreEqual(s.IsEmpty(), false);
        }

        [TestMethod()]
        public void PeekTest()
        {
            var s = new Stack<int>();
            for (int i = 0; i < 100; i++)
            {
                s.Push(i);
            }
            for (int i = 99; i >= 0; i--)
            {
                var item = s.Peek();
                Assert.AreEqual(item, 99);
            }
        }

        [TestMethod()]
        public void IsEmptyShoudReturnTrueIfTheStackIsEmpty()
        {
            var s = new Stack<int>();
            Assert.IsTrue(s.IsEmpty());
        }
        [TestMethod()]
        public void IsEmptyShoudReturnFalseIfTheStackIsNotEmpty()
        {
            var s = new Stack<int>();
            s.Push(1);
            Assert.IsFalse(s.IsEmpty());
        }
    }
}
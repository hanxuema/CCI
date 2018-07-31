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
    public class ProgramTests
    {
        [TestMethod()]
        public void CICISShouldReturnFalseIfStringIsAAA()
        {
            var result = Program.CheckUniqueCharactersInString("AAA");

            Assert.IsFalse(result);
        }
        [TestMethod()]
        public void CICISShouldReturnFalseIfStringIsABA()
        {
            var result = Program.CheckUniqueCharactersInString("ABA");

            Assert.IsFalse(result);
        }
        [TestMethod()]
        public void CICISShouldReturnTrueIfStringIsABC()
        {
            var result = Program.CheckUniqueCharactersInString("ABC");

            Assert.IsTrue(result);
        }
        [TestMethod()]
        public void CICISShouldReturnTrueIfStringIsABCDEFGHIJK()
        {
            var result = Program.CheckUniqueCharactersInString("ABCDEFGHIJK");

            Assert.IsTrue(result);
        }
        [TestMethod()]
        public void CICISShouldReturnFalseIfStringIsABCDEFGHIJKA()
        {
            var result = Program.CheckUniqueCharactersInString("ABCDEFGHIJKA");

            Assert.IsFalse(result);
        }
        [TestMethod()]
        public void CICISShouldReturnTrueIfStringIsABCDEFgHIJK()
        {
            var result = Program.CheckUniqueCharactersInString("ABCDEFgHIJK");

            Assert.IsTrue(result);
        }
        [TestMethod()]
        public void CICISShouldReturnFalseIfStringIsABCDEFGHIJKa()
        {
            var result = Program.CheckUniqueCharactersInString("ABCDEFGHIJKa");

            Assert.IsFalse(result);
        }
    }
}
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

        [TestMethod()]
        public void CheckPermutationShouldReturnTrueIfFirstisABCAndSecondIsCBA()
        {
            var result = Program.CheckPermutation("ABC", "CBA");

            Assert.IsTrue(result);
        }
        [TestMethod()]
        public void CheckPermutationShouldReturnTrueIfFirstisABCDAndSecondIsDCBA()
        {
            var result = Program.CheckPermutation("ABCD", "DCBA");

            Assert.IsTrue(result);
        }
        [TestMethod()]
        public void CheckPermutationShouldReturnTrueIfFirstisABCDEAndSecondIsDCBA()
        {
            var result = Program.CheckPermutation("ABCDE", "DCBA");

            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void URLify()
        {
            var result = Program.URLify("Mr John Smith    ");
            Assert.AreEqual(result, "Mr%20John%20Smith%20");
            result = Program.URLify("Mr John    Smith    ");
            Assert.AreEqual(result, "Mr%20John%20Smith%20");
            result = Program.URLify("Mr    John   Smith    ");
            Assert.AreEqual(result, "Mr%20John%20Smith%20");
            result = Program.URLify("Mr   John    Smith       ");
            Assert.AreEqual(result, "Mr%20John%20Smith%20");
        }

        [TestMethod()]
        public void checkIfOneCharacterReplaceTestshouldReturnTrue()
        {
            var result = Program.checkIfOneCharacterReplace("pale", "bale");
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void checkIfOneCharacterReplaceTestshouldReturnFalse()
        {
            var result = Program.checkIfOneCharacterReplace("pale", "bake");
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void checkIfOnecharacterRemovedShouldReturnTrue()
        {
            var result = Program.checkIfOnecharacterRemoved("pale", "pales");
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void checkIfOnecharacterRemovedShouldReturnTrueIfPaleAndPaele()
        {
            var result = Program.checkIfOnecharacterRemoved("pale", "paele");
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void OneAwayReturnTruepaleple()
        {
            var result = Program.OneAway("pale", "ple");
            Assert.AreEqual(result, true);
        }
        [TestMethod()]
        public void OneAwayReturnTruepalespale()
        {
            var result = Program.OneAway("pales", "pale");
            Assert.AreEqual(result, true);
        }
        [TestMethod()]
        public void OneAwayReturnTruepalebale()
        {
            var result = Program.OneAway("pale", "bale");
            Assert.AreEqual(result, true);
        }
        [TestMethod()]
        public void OneAwayReturnTruepalebake()
        {
            var result = Program.OneAway("pale", "bake");
            Assert.AreEqual(result, false);
        }

        [TestMethod()]
        public void StringCompressionTest()
        {
            var result = Program.StringCompression("aabcccccaaa");
            Assert.AreEqual(result, "a2b1c5a3");

            result = Program.StringCompression("aaabBcccccaaa");
            Assert.AreEqual(result, "a3b1B1c5a3");
        }

        [TestMethod()]
        public void shirtString()
        {
            var result = Program.shirtString("ABCDE", 1);
            Assert.AreEqual(result, "BCDEA");

            result = Program.shirtString("BCDEA", 1);
            Assert.AreEqual(result, "CDEAB");
        }

        [TestMethod()]
        public void stringRotation()
        {
            var result = Program.stringRotation("waterbottle", "erbottlewat");
            Assert.AreEqual(result, true);

            result = Program.stringRotation("waterbottle", "rbottlewate");
            Assert.AreEqual(result, true);

            result = Program.stringRotation("waterbottle", "bottlewater");
            Assert.AreEqual(result, true);

            result = Program.stringRotation("waterbottle", "ottlewaterb");

            Assert.AreEqual(result, true);
            result = Program.stringRotation("waterbottle", "ttlewaterbo");
            Assert.AreEqual(result, true);
        }

        [TestMethod()]
        public void removeDuplicateFromLinkedListTest()
        {
            LinkedListNode<int> node = new LinkedListNode<int>(5);
          
        }
    }
}
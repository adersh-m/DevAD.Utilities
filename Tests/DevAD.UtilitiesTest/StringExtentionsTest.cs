using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DevAD.Utilities;

namespace DevAD.UtilitiesTest
{
    [TestClass]
    public class StringExtentionsTest
    {
        [TestMethod]
        public void ToFileSizeTestValid_Byte()
        {
            //-- Arrange
            long actual = 1;
            var expected = "1 byte";

            //-- Act
            var result = actual.ToFileSize();

            //-- Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void ToFileSizeTestValid_Bytes()
        {
            //-- Arrange
            long actual = 100;
            var expected = "100 bytes";

            //-- Act
            var result = actual.ToFileSize();

            //-- Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToFileSizeTestValid_KB()
        {
            //-- Arrange
            long actual = 2048;
            var expected = "2 KB";

            //-- Act
            var result = actual.ToFileSize();

            //-- Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void InsertSpacesValid()
        {
            //-- Arrange
            string actual = "SolomanMarcus";
            var expected = "Soloman Marcus";

            //-- Act
            var result = actual.InsertSpaces();

            //-- Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void InsertSpacesSameString()
        {
            //-- Arrange
            string actual = "Soloman Marcus";
            var expected = "Soloman Marcus";

            //-- Act
            var result = actual.InsertSpaces();

            //-- Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void InsertSpacesDoubleSpace()
        {
            //-- Arrange
            string actual = "Soloman  Marcus";
            var expected = "Soloman  Marcus";

            //-- Act
            var result = actual.InsertSpaces();

            //-- Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void InsertSpacesStringWithOneWord()
        {
            //-- Arrange
            string actual = "Soloman";
            var expected = "Soloman";

            //-- Act
            var result = actual.InsertSpaces();

            //-- Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void RemoveLastCharacterTest()
        {
            //-- Arrange
            string actual = "HelloWorld";
            var expected = "HelloWorl";

            //-- Act
            var result = actual.RemoveLastCharacter();

            //-- Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void RemoveLastNCharactersTest()
        {
            //-- Arrange
            string actual = "HelloWorld";
            var expected = "HelloWo";

            //-- Act
            var result = actual.RemoveLast(3);

            //-- Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void RemoveFirstCharactersTest()
        {
            //-- Arrange
            string actual = "HelloWorld";
            var expected = "elloWorld";

            //-- Act
            var result = actual.RemoveFirstCharacter();

            //-- Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void RemoveFirstNCharactersTest()
        {
            //-- Arrange
            string actual = "HelloWorld";
            var expected = "loWorld";

            //-- Act
            var result = actual.RemoveFirst(3);

            //-- Assert
            Assert.AreEqual(expected, result);
        }
    }
}

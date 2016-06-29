using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringToIntConverter.Tests
{
    [TestClass]
    public class StringExtensionsTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConvertToInt_StringIsEmpty_ThrowsException()
        {
            "".ConvertToInt();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConvertToInt_StringIsInvalidInStart_ThrowsException()
        {
            "asd1313".ConvertToInt();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConvertToInt_StringIsInvalidInEnd_ThrowsException()
        {
            "123123asdsad".ConvertToInt();
        }

        [TestMethod]
        public void ConvertToInt_123_Returns123()
        {
            Assert.AreEqual("123".ConvertToInt(), 123);
        }

        [TestMethod]
        public void ConvertToInt_45_Returns45()
        {
            Assert.AreEqual("45".ConvertToInt(), 45);
        }
    }
}

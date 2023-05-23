using LibraryDuplicateEncoder;
namespace Solution
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class Kata1Test
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("(((", Kata1.DuplicateEncode("din"));
            Assert.AreEqual("()()()", Kata1.DuplicateEncode("recede"));
            Assert.AreEqual(")())())", Kata1.DuplicateEncode("Success"), "should ignore case");
            Assert.AreEqual("))((", Kata1.DuplicateEncode("(( @"));
        }
        [Test]
        public void BasicTests121()
        {
            Assert.AreEqual("(((", Kata1.DuplicateEncode("di("));
        }
        [Test]
        public void BasicTests1214()
        {
            Assert.AreEqual(")))))(", Kata1.DuplicateEncode("dddddn"));
        }
        [Test]
        public void OurTest()
        {
            string textFile = @"C:\Users\user\Desktop\test.txt";
            string text = File.ReadAllText(textFile);
            string Filetext = @"C:\Users\user\Desktop\result.txt";
            string result = File.ReadAllText(Filetext);
            Assert.AreEqual(result, Kata1.DuplicateEncode(text));
        }
    }
}
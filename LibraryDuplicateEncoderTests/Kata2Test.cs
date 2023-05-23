using LibraryDuplicateEncoder;
namespace Solution
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class Kata2Test
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("(((", Kata2.DuplicateEncode("din"));
            Assert.AreEqual("()()()", Kata2.DuplicateEncode("recede"));
            Assert.AreEqual(")())())", Kata2.DuplicateEncode("Success"), "should ignore case");
            Assert.AreEqual("))((", Kata2.DuplicateEncode("(( @"));
        }
        [Test]
        public void BasicTests121()
        {
            Assert.AreEqual("(((", Kata2.DuplicateEncode("di("));
        }
        [Test]
        public void BasicTests1214()
        {
            Assert.AreEqual(")))))(", Kata2.DuplicateEncode("dddddn"));
        }
        [Test]
        public void OurTest()
        {
            string textFile = @"C:\Users\user\Desktop\test.txt";
            string text = File.ReadAllText(textFile);
            string Filetext = @"C:\Users\user\Desktop\result.txt";
            string result = File.ReadAllText(Filetext);
            Assert.AreEqual(result, Kata2.DuplicateEncode(text));
        }
    }
}
namespace Solution
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class KataTest
    {
        [Test]
        public void EmptyTest()
        {
            Assert.AreEqual("", Kata.UniqueInOrder(""));
        }
        [Test]
        public void Test1()
        {
            Assert.AreEqual("ABCDAB", Kata.UniqueInOrder("AAAABBBCCDAABBB"));
        }
        [Test]
        public void Test2() 
        { 
            Assert.AreEqual(new int[] { 1,2,3}, Kata.UniqueInOrder(new int[] {1, 2, 2, 3, 3}));
        }
    }
}
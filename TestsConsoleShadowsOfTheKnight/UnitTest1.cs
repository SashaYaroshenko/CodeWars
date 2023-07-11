//using ConsoleShadowsOfTheKnight;
using LibraryShadowsOfTheKnight;
namespace TestsConsoleShadowsOfTheKnight
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [Description("01 A lot of jumps")]
        [Order(1)]
        [Timeout(2000)]
        public void Test1()
        {
            //Arrange
            string[] readLine =
            {
                "4 8",
                "40",
                "2 3",
                "DR",
                "D",
                "D"
            };
            string[] expectedResult =
            {
                "3 5",
                "3 6",
                "3 7"
            };


            var output = new StringWriter();
            Console.SetOut(output);

            var input = new StringReader(String.Join(Environment.NewLine, readLine));
            Console.SetIn(input);

            //Act
            var obj = new Player();

            //Assert

            var res = output.GetStringBuilder().ToString();
            var result = res.ToString().Split(Environment.NewLine, StringSplitOptions.TrimEntries);
            Assert.AreEqual(expectedResult.Length, result.Length);

            for(int i=0; i<expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], result[i]);
            }

            
        }
    }
}
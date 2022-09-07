using CodingProblem;

namespace TestProject1
{
    [TestClass]
    public class ReverseStringTest
    {
        [TestMethod]
        public void TestIsLetter()
        {
            Assert.IsTrue(CodingProblem.Program.IsLetter('a'));
            Assert.IsFalse(CodingProblem.Program.IsLetter('1'));
            Assert.IsFalse(CodingProblem.Program.IsLetter('!'));
            Assert.IsTrue(CodingProblem.Program.IsLetter('Z'));
        }

        [TestMethod]
        public void TestReverseString()
        {
            Assert.AreEqual("asdf", Program.ReverseString("fdsa"));
            Assert.AreEqual("olleH, dlroW!", Program.ReverseString("Hello, World!"));
            Assert.AreEqual("HTIWgnirts reppU esaC", Program.ReverseString("stringWITH Upper Case"));
            Assert.AreEqual("HTIWgnirts    ynam!! !! ... SSECAPS!!!!  () :*", Program.ReverseString("stringWITH    many!! !! ... SPACESS!!!!  () :*"));
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TopCoder.Problems.Lexer
{
    [TestClass]
    public class LexerTest
    {
        [TestMethod]
        public void TestTokenize()
        {
            string[] tokens = new[] {"AbCd", "dEfG", "GhIj"};
            string input = "abCdEfGhIjAbCdEfGhIj";
            Lexer lexer = new Lexer();
            string[] consumed = lexer.tokenize(tokens, input);
            string[] expectedConsumed = new[] {"dEfG", "AbCd", "GhIj"};
            CollectionAssert.AreEqual(expectedConsumed, consumed);
        }
    }
}

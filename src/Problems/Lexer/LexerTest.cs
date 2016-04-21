using NUnit.Framework;

namespace TopCoder.Problems.Lexer
{
	[TestFixture ()]
    public class LexerTest
    {
		[Test ()]
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

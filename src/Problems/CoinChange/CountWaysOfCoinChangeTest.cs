using System;
using NUnit.Framework;
namespace Topcoder
{
	[TestFixture()]
	public class CoinChangeTest
	{
		private CoinChange cc = new CoinChange();

		[Test]
		[TestCase(new int[]{1, 2, 3}, 4, ExpectedResult=4, TestName="CoinChangeTest1")]
		[TestCase(new int[]{2, 5, 3, 6}, 10, ExpectedResult=5, TestName="CoinChangeTest2")]
		[TestCase(new int[]{41, 34, 46, 9, 37, 32, 42, 21, 7, 13, 1, 24, 3, 43, 2, 23, 8, 45, 19, 30, 29, 18, 35, 11}, 250, 
			ExpectedResult=15685693751, TestName="CoinChangeTest3")]
		public long CountWaysOfCoinChangeTest (int[] coins, int sum)
		{
			return cc.CountWaysOfChange (coins, sum);
		}
	}
}


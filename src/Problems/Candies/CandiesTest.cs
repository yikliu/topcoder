using System;
using NUnit.Framework;
namespace Topcoder
{
	[TestFixture]
	public class CandiesTest
	{
		private Candies c = new Candies();

		[TestCase(new int[] {1,2,2}, ExpectedResult = 4, TestName = "CandiesTest1")]
		[TestCase(new int[] {9, 2, 3, 4, 4, 4, 2, 1, 3, 4}, ExpectedResult=20, TestName="CandiesTest2")]			
		public int MinSumTest (int[] array)
		{
			return c.MinCandies (array);
		}
	}
}


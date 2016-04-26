using System;
using NUnit.Framework;
namespace Topcoder
{
	[TestFixture()]
	public class StockMaxTest
	{
		private StockMax sm = new StockMax();

		[TestCase(new int[] {1, 2, 100}, ExpectedResult=197, TestName="StockMaxTest1")]
		[TestCase(new int[] {1, 3, 1, 2}, ExpectedResult=3, TestName="StockMaxTest2")]
		[TestCase(new int[] {5, 3, 2}, ExpectedResult=0, TestName="StockMaxTest3")]
		public long GetMaxValue (int[] prices)
		{
			return sm.MaxValue (prices);
		}
	}
}


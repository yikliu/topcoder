using System;
using NUnit.Framework;
namespace Topcoder
{
	[TestFixture()]
	public class StockMaxTest
	{
		private StockMax sm = new StockMax();

		public long GetMaxValue (int[] prices)
		{
			return sm.MaxValue (prices);
		}
	}
}


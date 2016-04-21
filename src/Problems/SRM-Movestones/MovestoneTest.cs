using NUnit.Framework;

namespace Topcoder
{
	[TestFixture()]
	public class MovestoneTest
	{
		[Test()]
		public void GetTest ()
		{
			int[] a = new[] { 1, 2, 3 };
			int[] b = new[] { 3, 2, 1 };

			MoveStones ms = new MoveStones ();

			long steps = ms.get (a, b);

			Assert.AreEqual (2, steps);

			int[] a2 = new[] {1, 0, 1, 1, 0};
			int[] b2 = new[] {0, 3, 0, 0, 0};

			Assert.AreEqual (4, ms.get (a2, b2));
		}
	}
}


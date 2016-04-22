using System;
using NUnit.Framework;

namespace Topcoder
{
	[TestFixture()]
	public class ABBACanObtainTest
	{
		[Test()]
		public void CanObtainTest ()
		{
			var possible = "Possible";
			var impossible = "Impossible";
			ABBA ab = new ABBA ();
			Assert.AreEqual(possible, ab.canObtain("B", "ABBA"));

			Assert.AreEqual(possible, ab.canObtain("BBBBABABBBBBBA","BBBBABABBABBBBBBABABBBBBBBBABAABBBAA"));

			Assert.AreEqual (impossible, ab.canObtain ("A", "BB"));
		}
	}
}


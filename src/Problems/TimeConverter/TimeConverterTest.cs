using System;
using NUnit.Framework;

namespace Topcoder
{
	[TestFixture()]
	public class TimeConverterTest
	{
		[Test()]
		public  void ConverterTest ()
		{
			TimeConverter tc = new TimeConverter ();
			string time1 = "07:05:45PM";
			Assert.AreEqual ("19:05:45", tc.Convert (time1));

			string time2 = "12:00:00AM";
			Assert.AreEqual ("00:00:00", tc.Convert (time2));

			string time3 = "12:00:00PM";
			Assert.AreEqual ("12:00:00", tc.Convert (time3));
		}
	}
}


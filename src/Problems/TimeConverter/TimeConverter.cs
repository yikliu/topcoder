//Given a time in AM/PM format, convert it to military (2424-hour) time.
//
//Note: Midnight is 12:00:00AM12:00:00AM on a 1212-hour clock, and 00:00:0000:00:00 on a 2424-hour clock. Noon is 12:00:00PM12:00:00PM on a 1212-hour clock, and 12:00:0012:00:00 on a 2424-hour clock.
//
//Input Format
//
//A single string containing a time in 1212-hour clock format (i.e.: hh:mm:ssAMhh:mm:ssAM or hh:mm:ssPMhh:mm:ssPM), where 01≤hh≤1201≤hh≤12.
//
//Output Format
//
//Convert and print the given time in 2424-hour format, where 00≤hh≤2300≤hh≤23.
//
//Sample Input
//
//07:05:45PM
//Sample Output
//
//19:05:45

using System;
using NUnit.Framework;

namespace Topcoder
{
	public class TimeConverter
	{
		[TestCase("07:05:45PM", ExpectedResult="19:05:45", TestName="TimeConverterTest1")]
		[TestCase("12:00:00AM", ExpectedResult="00:00:00", TestName="TimeConverterTest2")]
		[TestCase("12:00:00PM", ExpectedResult="12:00:00", TestName="TimeConverterTest2")]
		public string Convert (string time)
		{
			bool IsPM = time.Contains("PM");
			int h = 0;
			string hours = time.Substring(0,2);
			if (IsPM) {
				if (time.StartsWith ("0")) {
					h = Int32.Parse (time.Substring (1, 1));
				} else {
					h = Int32.Parse (time.Substring (0, 2));
				}

				h = h == 12 ? h : h + 12;

				hours = h.ToString ();
			} else {
				if (time.StartsWith ("12")) {
					hours = "00";
				}
			}
			return hours + time.Remove (time.Length - 2).Substring (2);
		}
	}
}


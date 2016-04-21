using System;

namespace Topcoder
{
	public class TimeConverter
	{
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


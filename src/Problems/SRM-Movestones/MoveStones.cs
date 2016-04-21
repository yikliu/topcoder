using System;

namespace Topcoder
{
	public class MoveStones
	{
		public long get(int[] a, int[] b)
		{	
			int sz = a.Length;
			long sa = 0, sb = 0;
			for (int i = 0; i < sz; i++) 
			{
				sa += a [i];
				sb += b [i];
			}

			if (sa != sb)
				return -1;

			long[] c = new long[sz + 1];
			c [0] = 0;
			for (int i = 0; i < sz; i++) {
				c [i + 1] = c [i] + a [i] - b [i]; 
			}

			Array.Sort (c, 1, sz);
			long x = c [(sz + 1) / 2];
			long ans = 0;
			for (int i = 1; i <= sz; i++) {
				ans += Math.Abs (c [i] - x);
			}

			return ans;
		}
	}
}


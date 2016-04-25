using System;
using System.Collections.Generic;

namespace Topcoder
{
	public class Candies
	{
		public int MinCandies (int[] ratings)
		{
			int sz = ratings.Length;
			List<int> max = new List<int> ();
			List<int> min = new List<int> ();
			int[] candies = new int[sz];
			int prevDiff = 0;
			for (int i = 0; i < sz - 1; i++) {
				int diff = ratings [i + 1] - ratings [i];
				if (i == 0) {
					if (diff >= 0) {
						min.Add (0);
						candies [0] = 1;
					} else {
						max.Add (0);
					}
				} else if (i == sz - 2) {
					if (diff > 0) {
						max.Add (sz - 1);
					} else {
						min.Add (sz - 1);
						candies [sz - 1] = 1;
					}
				} else {
					if (diff >= 0 && prevDiff <= 0) {
						min.Add (i);
						candies [i] = 1;
					} else if (diff <=0 && prevDiff > 0 ){
						max.Add (i);
					}
				}
				prevDiff = diff;
			}

			int j = 0;
			int t = 0;
			int m = 0;
			int n = 0;
			int minSum = 0;
			int distance = 0;
			int leftSpan = 0;
			int rightSpan = 0;
			for (; j < max.Count; j++) {
				if (max [j] > min [t]) {
					if (t + 1 <= min.Count) {
						leftSpan = max [j] = min [t];
						rightSpan = min [t + 1] - max [j];

						if (leftSpan >= rightSpan) {
							for (m = min [t] + 1; m <= max [j]; m++) {
								candies [m] = max [j] - m + 1;
							}
							for (n = min [t + 1] - 1; n >= max [j] + 1; n--) {
								candies [n] = min [t + 1] - n + 1;
							}
						} else if (leftSpan < rightSpan) {
							for (n = min [t + 1] - 1; n >= max [j]; n--) {
								candies [n] = min [t + 1] - n + 1;
							}
							for (m = min [t] + 1; m < max [j] - 1; m++) {
								candies [m] = max [j] - m + 1;
							}
						} 
					} else {
						for (m = min [t] + 1; m <= max [j]; m++) {
							candies [m] = max [j] - m + 1;
						}
					}
				} else {
					for (n = min [t] - 1; n >= max [j]; n--) {
						candies [n] = min [t] - n + 1;
					}
				}
				t++;
			}

			for (int i = 0; i < candies.Length; i++) {
				minSum += candies [i];

			}
			return minSum;
		}
	}
}


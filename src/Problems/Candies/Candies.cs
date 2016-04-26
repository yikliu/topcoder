using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Topcoder
{
	public class Candies
	{
		[TestCase(new int[] {1,2,2}, ExpectedResult = 4, TestName = "CandiesTest1")]
		[TestCase(new int[] {9, 2, 3, 4, 4, 4, 2, 1, 3, 4}, ExpectedResult=20, TestName="CandiesTest2")]			
		public int MinCandies (int[] ratings)
		{
			int sz = ratings.Length;

			int[] left = new int[sz];
			int[] right = new int[sz];
			left [0] = 1;
			for (int i = 1; i < sz; i++) {
				left [i] = ratings [i] > ratings [i - 1] ? left [i - 1] + 1 : 1;
			}
			right [sz - 1] = 1;
			for (int j = sz - 2; j >= 0; j--) {
				right [j] = ratings [j] > ratings [j + 1] ? right [j + 1] + 1 : 1; 
			}

			int sum = 0; 
			for (int i = 0; i < sz; i++) {
				sum += Math.Max (left [i], right [i]);
			}

			return sum;
		}
	}
}


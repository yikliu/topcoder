//Alice is a kindergarden teacher. She wants to give some candies to the children in her class.  All the children sit in a line ( their positions are fixed), and each  of them has a rating score according to his or her performance in the class.  Alice wants to give at least 1 candy to each child. If two children sit next to each other, then the one with the higher rating must get more candies. Alice wants to save money, so she needs to minimize the total number of candies given to the children.
//
//Input Format
//
//The first line of the input is an integer N, the number of children in Alice's class. Each of the following N lines contains an integer that indicates the rating of each child.
//
//1 <= N <= 105 
//1 <= ratingi <= 105
//
//Output Format
//
//Output a single line containing the minimum number of candies Alice must buy.
//
//Sample Input
//
//3  
//1  
//2  
//2
//Sample Output
//
//4
//Explanation
//
//Here 1, 2, 2 is the rating. Note that when two children have equal rating, they are allowed to have different number of candies. Hence optimal distribution will be 1, 2, 1.

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


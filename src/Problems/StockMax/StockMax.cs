/*
 * Your algorithms have become so good at predicting the market that you now know what the share price of Wooden Orange Toothpicks Inc. (WOT) will be for the next N days.

Each day, you can either buy one share of WOT, sell any number of shares of WOT that you own, or not make any transaction at all. What is the maximum profit you can obtain with an optimum trading strategy?

Input

The first line contains the number of test cases T. T test cases follow:

The first line of each test case contains a number N. The next line contains N integers, denoting the predicted price of WOT shares for the next N days.

Output

Output T lines, containing the maximum profit which can be obtained for the corresponding test case.

Constraints

1 <= T <= 10 
1 <= N <= 50000

All share prices are between 1 and 100000

Sample Input

3
3
5 3 2
3
1 2 100
4
1 3 1 2
Sample Output

0
197
3
Explanation

For the first case, you cannot obtain any profit because the share price never rises. 
For the second case, you can buy one share on the first two days, and sell both of them on the third day. 
For the third case, you can buy one share on day 1, sell one on day 2, buy one share on day 3, and sell one share on day 4.
 **/
using System;
using NUnit.Framework;

namespace Topcoder
{
	public class StockMax
	{
		[TestCase(new int[] {1, 2, 100}, ExpectedResult=197, TestName="StockMaxTest1")]
		[TestCase(new int[] {1, 3, 1, 2}, ExpectedResult=3, TestName="StockMaxTest2")]
		[TestCase(new int[] {5, 3, 2}, ExpectedResult=0, TestName="StockMaxTest3")]
		public long MaxValue (int[] prices)
		{
			long maxValue = 0;
			int maxPrice = Int32.MinValue;
			for (int j = prices.Length - 1; j >= 0; j--) {
				if (prices [j] > maxPrice) {
					maxPrice = prices [j];
				} else {
					maxValue += maxPrice - prices [j];
				}
			}

			return maxValue;
		}
	}
}


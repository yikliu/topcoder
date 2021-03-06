﻿//Problem Statement
//There are n piles of stones arranged around a circle. The piles are numbered 0 through n-1, in order. In other words: For each valid i, piles i and i+1 are adjacent. Piles 0 and n-1 are also adjacent.
//
//You are given two s a and b, each with n elements. For each i, a[i] is the current number of stones in pile i, and b[i] is the desired number of stones for this pile. You want to move some stones to create the desired configuration. In each step you can take any single stone from any pile and move the stone to any adjacent pile. Find and return the smallest number of steps needed to create the desired configuration, or -1 if the desired distribution of stones cannot be reached.
//
//	Definition
//	Class: MoveStones
//	Method: get
//	Parameters: int[], int[]
//	Returns: long
//	Method signature: long get(int[] a, int[] b)
//	(be sure your method is public)
//	Limits
//	Time limit (s): 2.000
//	Memory limit (MB): 256
//	Notes
//- At any moment during the game some piles may be empty. Empty piles still remain in place. For example, if pile 5 is empty, you are not allowed to move a stone from pile 4 directly to pile 6 in a single step. Instead, you must place the stone onto the empty pile 5 first.
//	Constraints
//	- n will be between 1 and 1000, inclusive.
//	- a will have exactly n elements.
//	- b will have exactly n elements.
//	- Each element of a and b will be between 0 and 10^9, inclusive.
//	Examples
//	0)
//{12}
//{12}
//Returns: 0
//The desired configuration is the same as the initial configuration. No steps are needed.
//1)
//{10}
//{9}
//Returns: -1
//We cannot add or remove stones, we can only move them around the circle.
//2)
//{0, 5}
//{5, 0}
//Returns: 5
//3)
//{1, 2, 3}
//{3, 1, 2}
//Returns: 2
//Move one stone from pile 1 to pile 0 and another stone from pile 2 to pile 0.
//4)
//{1, 0, 1, 1, 0}
//{0, 3, 0, 0, 0}
//Returns: 4
//5)
//{1000000000, 0, 0, 0, 0, 0}
//{0, 0, 0, 1000000000, 0, 0}
//Returns: 3000000000
//Watch out for integer overflow.
//	This problem statement is the exclusive and proprietary property of TopCoder, Inc. Any unauthorized use or reproduction of this information without the prior written consent of TopCoder, Inc. is strictly prohibited. (c)2003, TopCoder, Inc. All rights reserved.

using System;
using NUnit.Framework;

namespace Topcoder
{
	public class MoveStones
	{
		[TestCase(new int[]{1, 2, 3}, new int[]{3, 2, 1}, ExpectedResult=2, TestName="MoveStonesTest1")]
		[TestCase(new int[]{1, 0, 1, 1, 0}, new int[]{0, 3, 0, 0, 0}, ExpectedResult=4, TestName="MoveStonesTest2")]
		public long MinSteps(int[] a, int[] b)
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


//A subsequence is a sequence that can be derived from another sequence by deleting some elements without changing the order of the remaining elements. Longest common subsequence (LCS) of 2 sequences is a subsequence, with maximal length, which is common to both the sequences. 
//
//Given two sequence of integers, A=[a1,a2,…,an]A=[a1,a2,…,an] and B=[b1,b2,…,bm]B=[b1,b2,…,bm], find any one longest common subsequence.
//
//In case multiple solutions exist, print any of them. It is guaranteed that at least one non-empty common subsequence will exist.
//
//Recommended References
//
//This Youtube video tutorial explains the problem and its solution quite well.
//
//
//Input Format
//
//First line contains two space separated integers, nn and mm, where nn is the size of sequence AA, while mm is size of sequence BB. In next line there are nn space separated integers representing sequence AA, and in third line there are mm space separated integers representing sequence BB.
//
//	n m
//	A1 A2 … An 
//	B1 B2 … Bm  
//	Constraints
//
//	1≤n≤1001≤n≤100 
//	1≤m≤1001≤m≤100 
//	0≤ai<1000,where i∈[1,n]0≤ai<1000,where i∈[1,n] 
//	0≤bj<1000,where j∈[1,m]0≤bj<1000,where j∈[1,m]
//
//	Output Format
//
//	Print the longest common subsequence and each element should be separated by at least one white-space. In case of multiple answers, print any one of them.
//
//	Sample Input
//
//	5 6
//	1 2 3 4 1
//	3 4 1 2 1 3
//	Sample Output
//
//	1 2 3
//	Explanation
//
//	There is no common subsequence with length larger than 3. And "1 2 3", "1 2 1", "3 4 1" are all correct answers
using System;
using System.Collections.Generic;
using NUnit.Framework;
namespace Topcoder
{
	public class LCS
	{
		private string formateKey(int i, int j)
		{
			return string.Format ("{0}{1}", i, j); 
		}

		[TestCase(new int[]{1,2,3,4,1}, new int[]{3,4,1,2,1,3}, ExpectedResult="1 2 3")]
		public string FindLCS(int[] str1, int[] str2)
		{
			int n = str1.Length;
			int m = str2.Length;
			Dictionary<string, string> lcs = new Dictionary<string, string> ();
			for (int i = 0; i <= n; i++) {
				for (int j = 0; j <= m; j++) {
					if (i == 0 || j == 0) {
						lcs [formateKey(i,j)] = string.Empty;
						continue;
					}

					if (str1 [i-1] == str2 [j-1]) {
						lcs [formateKey(i,j)] = lcs [formateKey(i-1,j-1)] + str1[i-1] + " ";
					} else {
						var s1 = lcs [formateKey (i - 1, j)];
						var s2 = lcs [formateKey (i, j - 1)];
						lcs [formateKey (i, j)] = s1.Length >= s2.Length ? s1 : s2;
					}
				}
			}

			//return seq.ToArray ();
			return lcs[formateKey(n,m)].Trim();
		}
	}
}


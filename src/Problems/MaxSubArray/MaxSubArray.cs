/**
 * Given an array A={a1,a2,…,aN}A={a1,a2,…,aN} of NN elements, findByDivideConquer the maximum possible sum of a

Contiguous subarray
Non-contiguous (not necessarily contiguous) subarray.
Empty subarrays/subsequences should not be considered.

Input Format

First line of the input has an integer TT. TT cases follow. 
Each test case begins with an integer NN. In the next line, NN integers follow representing the elements of array AA.

Constraints:

1≤T≤101≤T≤10
1≤N≤1051≤N≤105
−104≤ai≤104−104≤ai≤104
The subarray and subsequences you consider should have at least one element.

Output Format

Two, space separated, integers denoting the maximum contiguous and non-contiguous subarray. At least one integer should be selected and put into the subarrays (this may be required in cases where all elements are negative).

Sample Input

2 
4 
1 2 3 4
6
2 -1 2 3 4 -5
Sample Output

10 10
10 11
Explanation

In the first case: 
The max sum for both contiguous and non-contiguous elements is the sum of ALL the elements (as they are all positive).

In the second case: 
[2 -1 2 3 4] --> This forms the contiguous sub-array with the maximum sum. 
For the max sum of a not-necessarily-contiguous group of elements, simply add all the positive elements.
 */

using System;

namespace Topcoder
{
    class MaxSubArray
    {
        private int max (int i, int j){
			return i > j ? i : j;
		}

		private int max (int i, int j, int m){
			return max (i, max (j, m));
		}

		private int FindMaxCrossMid(int[] array, int mid, int start, int end){
			int a1 = 0;
			int maxA1 = Int32.MinValue;
			int i = mid;
			for (; i >= start; i--)
			{
				a1 += array[i];
				if (a1 > maxA1)
				{
					maxA1 = a1;
				}                
			}

			int a2 = 0;
			int maxA2 = Int32.MinValue;

			int j = mid + 1;
			for (; j <= end; j++)
			{
				a2 += array[j];
				if (a2 > maxA2)
				{
					maxA2 = a2;
				}               
			}

			return maxA1 + maxA2;

		}

        //Solve by divide and conquer
        public int FindByDivideConquer(int[] array, int start, int end)
        {
            if (start == end)
            {
                return array[start];
            }

            int mid = (start + end)/2;
            int s1 = FindByDivideConquer(array, start, mid);
            int s2 = FindByDivideConquer(array, mid + 1, end);
			int cross = FindMaxCrossMid (array, mid, start, end);
			string message = string.Format ("{0}:{1}:{2}, {3}, {4}, {5}", start, mid, end, s1, s2, cross);
			return max(s1, s2, cross );

        }

        //Solve by DP
        public int FindByDP(int[] array)
        {
            int sz = array.Length;
            int sum = 0;
            int max_sub = Int32.MinValue;
            int min_sum_prior = 0;

            int sub_sum = 0;
            for (int i = 0; i < sz; i++)
            {
                sum += array[i];

                sub_sum = sum - min_sum_prior;

                if (sub_sum > max_sub)
                {
                    max_sub = sub_sum;
                }

                if (sum < min_sum_prior)
                {
                    min_sum_prior = sum;
                }
            }
            return max_sub;
        }

        public int FindNonContiguousSum(int[] array)
        {
            int max = Int32.MinValue;
            bool allNegative = true;
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    allNegative = false;
                    sum += array[i];
                }
                else
                {
                    if (array[i] > max)
                    {
                        max = array[i];
                    }
                }
            }

            return allNegative ? max : sum;
        }
    }
}

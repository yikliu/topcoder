/**
 * Given an array A={a1,a2,…,aN}A={a1,a2,…,aN} of NN elements, find the maximum possible sum of a

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

namespace Topcoder.Problems.MaxSubArray
{
    class MaxSubArray
    {
        //Divide and Conqure
        // NlogN time
        public int FindByDC(int sz, int[] array)
        {
            var res = find(array, 0, sz - 1);
            Console.WriteLine(res[0] + " " + res[1]);
            return res[2];
        }

        private int[] find(int[] array, int start, int end)
        {
            if (start == end)
            {
                return new int[]{start, end, array[start]};
            }

            int mid = (start + end)/2;
            int[] res1 = find(array, start, mid);
            int[] res2 = find(array, mid + 1, end);

            //conqueur 
            int a1 = 0;
            int maxA1 = Int32.MinValue;
            int i = mid;
            int last_i = mid;
            for (; i >= start; i--)
            {
                a1 += array[i];
                if (a1 >= maxA1)
                {
                    maxA1 = a1;
                    last_i = i;
                }                
            }

            int a2 = 0;
            int maxA2 = Int32.MinValue;
            int j = mid + 1;
            int last_j = j;
            
            for (; j <= end; j++)
            {
                a2 += array[j];
                if (a2 > maxA2)
                {
                    maxA2 = a2;
                    last_j = j;
                }               
            }

            int A = maxA1 + maxA2;

            int s1 = res1[2];
            int s2 = res2[2];

            if (s1 > s2)
            {
                if (s1 > A)
                {
                    return res1;
                }
                else
                {
                    return new[] {last_i, last_j, A};
                }
            }
            else
            {
                if (s2 > A)
                {
                    return res2;
                }
                else
                {
                    return new[] {last_i, last_j, A};
                }
            }

        }
    }
}

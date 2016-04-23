using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Topcoder
{
    [TestFixture()]
    class MaxSubArrayTest
    {
        private MaxSubArray msa = new MaxSubArray();

        [TestCase(new int[] { 2, -1, 2, 3, 4, -5 }, 0, 5, ExpectedResult = 10, TestName="MaxSubArrayTest1")]
        [TestCase(new int[] { 1 }, 0, 0, ExpectedResult = 1, TestName = "MaxSubArrayTest1")]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, 0, 4, ExpectedResult = -1, TestName = "MaxSubArrayTest3")]
        [TestCase(new int[] { 1, -1, -1, -1, -1, 5 }, 0, 5, ExpectedResult = 5, TestName = "MaxSubArrayTest4")]
        [TestCase(new int[] { -10 }, 0, 0, ExpectedResult = -10, TestName = "MaxSubArrayTest5")]
        [TestCase(new int[] { -100 , -1 }, 0, 1, ExpectedResult = -1, TestName = "MaxSubArrayTest6")]
        public int MaxSubArrayContiguousDivideConquerTest(int[] array, int start, int end)
        {
            return msa.FindByDivideConquer(array, start, end);
        }

        [TestCase(new int[] { 2, -1, 2, 3, 4, -5 }, ExpectedResult = 11, TestName = "MaxSubArrayNonContiguousTest1")]
        [TestCase(new int[] { 1 },  ExpectedResult = 1, TestName = "MaxSubArrayNonContiguousTest2")]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, ExpectedResult = -1, TestName = "MaxSubArrayNonContiguousTest3")]
        [TestCase(new int[] { 1, -1, -1, -1, -1, 5 }, ExpectedResult = 6, TestName = "MaxSubArrayNonContiguousTest4")]
        [TestCase(new int[] { -10 }, ExpectedResult = -10, TestName = "MaxSubArrayNonContiguousTest5")]
        [TestCase(new int[] { -100,-1 }, ExpectedResult = -1, TestName = "MaxSubArrayNonContiguousTest6")]
        public int MaxSubArrayNonContiguousTest(int[] array)
        {
            return msa.FindNonContiguousSum(array);
        }
    }
}

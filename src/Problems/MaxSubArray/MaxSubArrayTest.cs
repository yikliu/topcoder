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
        [Test()]
        public void TestGetByDC()
        {
            MaxSubArray msa = new MaxSubArray();
            int sum = msa.find(new[] {2, -1, 2, 3, 4, -5}, 0, 5);
            Assert.AreEqual(10, sum);

			int sum2 = msa.find(new[] {1}, 0, 0);
            Assert.AreEqual(1, sum2);

			int sum3 = msa.find(new[] { -1, -2, -3, -4, -5, -6 }, 0, 5);
            Assert.AreEqual(-1, sum3);

			int sum4 = msa.find(new[] { -10 }, 0, 0);
            Assert.AreEqual(-10, sum4);

			int sum5 = msa.find(new[] { 1, -1, -1, -1, -1, 5 }, 0, 5);
            Assert.AreEqual(5, sum5);
        }
    }
}

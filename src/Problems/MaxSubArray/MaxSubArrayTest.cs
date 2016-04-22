using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Topcoder.Problems.MaxSubArray
{
    [TestFixture()]
    class MaxSubArrayTest
    {
        [Test()]
        public void TestGetByDC()
        {
            MaxSubArray msa = new MaxSubArray();
            int sum = msa.FindByDC(6, new[] {2, -1, 2, 3, 4, -5});
            Assert.AreEqual(10, sum);

            int sum2 = msa.FindByDC(1, new[] {1});
            Assert.AreEqual(1, sum2);

            int sum3 = msa.FindByDC(6, new[] { -1, -2, -3, -4, -5, -6 });
            Assert.AreEqual(-1, sum3);
        }
    }
}

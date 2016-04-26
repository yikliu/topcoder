using System;
using NUnit.Framework;

namespace Topcoder
{
    [TestFixture]
    public class GridWalk
    {
        public long CountWaysOfWalk(int[] pos, int steps, int[] dimenensions)
        {
            if (steps <= 0)
                return 1;

            int N = pos.Length;
            long res = 0;
            long forward = 0;
            long backward = 0;
            for (int i = 0; i < N; i++)
            {
                pos[i]++;

                if (pos[i] <= dimenensions[i])
                {
                    forward = CountWaysOfWalk(pos, steps - 1, dimenensions);
                    res += forward;
                }

                pos[i] = pos[i] - 2;

                if (pos[i] > 0)
                {
                    backward = CountWaysOfWalk(pos, steps - 1, dimenensions);
                    res += backward;
                }
                
                res += backward;
            }

            return res;
        }
    }
}
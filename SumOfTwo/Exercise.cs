using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTwo
{
    public class Exercise
    {
        public static int SumOfTwo(int[] nums, int SumToFind)
        {
            List<Sums> sums = [];
            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (nums[i] + nums[i + 1] == SumToFind)
                {
                    sums.Add(new Sums(nums[i], nums[i + 1]));
                }
            }

            return sums.Distinct().Count();
        }
    }

    public struct Sums
    {
        public Sums(int value1, int value2)
        {
            v1 = value1;
            v2 = value2;
            v3 = value1 + value2;
        }

        public int v1 = 0;
        public int v2 = 0;
        public int v3 = 0;
    }
}

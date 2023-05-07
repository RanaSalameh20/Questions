using System;
using System.Collections.Generic;

namespace FirstQuestion
{
    internal class SearchForTarget
    {
        public int[] GetTwoSumEqualTarget(int[] nums, int target)
        {
            int[] resultIndeces = new int[2];
            Dictionary<int, int> NumberAndIndexPairs = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int remain = target - nums[i];
                if (NumberAndIndexPairs.ContainsKey(remain))
                {
                    resultIndeces[0] = NumberAndIndexPairs[remain];
                    resultIndeces[1] = i;
                    break;

                }
                else if (!NumberAndIndexPairs.ContainsKey(nums[i]))
                {
                    NumberAndIndexPairs.Add(nums[i], Array.IndexOf(nums, nums[i]));
                }

            }
            return resultIndeces;
        }
    }
}
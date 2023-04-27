using System;

namespace SingleNumber
{
    public class Single
    {
        public int FindSingleNumber(int[] nums)
        {
            int single = nums[0];
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 1; i += 2)
            {

                if (nums[i] != nums[i + 1])
                {
                    return nums[i];
                }
            }
            return nums[nums.Length - 1];

        }
    }
}
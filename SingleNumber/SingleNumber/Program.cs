using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleNumber
{
    class Program
    {
        // the Question : https://leetcode.com/problems/single-number/submissions/926249805/
        public static void Main(string[] args)
        {
            //test1
            Single singleNumber = new Single();
            int[] nums1 = { 1, 1,4, 2, 2 };
            int single1 = singleNumber.FindSingleNumber(nums1);
            Console.WriteLine(single1);

            //test2
            int[] nums2 = { 2,2,1 };
            int single2 = singleNumber.FindSingleNumber(nums2);

            Console.WriteLine(single2);

            //tese3
            int[] nums3 = { 1};
            int single3 = singleNumber.FindSingleNumber(nums3);
            Console.WriteLine(single3);
        }
    }
}

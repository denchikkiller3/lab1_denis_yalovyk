using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab6.1
{
    public class Number
    {
        public void RecursionNumber(int[] nums)
        {
            Array.Reverse(nums);
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
        }
        public void RecursionNumber(int number)
        {
            Console.WriteLine(numebr.ToString().Reverse().ToArray());
        }
    }
}

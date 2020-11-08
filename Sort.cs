// 
using System;

namespace practice_c_
{
    public class Sort
    {
        public static int Select_Number(int[]numbers ,bool select ,int target) 
        {
            if (select == false)
            {
                Array.Sort(numbers);
                return numbers[target-1];
            }
            else
            {
                Array.Sort(numbers);
                return numbers[numbers.Length - target];
            }
        }
    
    }
}
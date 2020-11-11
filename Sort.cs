// 
using System;

namespace practice_c_
{
    public class Sort
    {
        public static int[] Get_sort(int[] numbers)
        {
            int b = 0;
            for (int i = 0; i < numbers.Length; i++)
                {
                    for (int k = i+1; k < numbers.Length; k++)
                    {
                        if (numbers[i]> numbers[k])
                        {
                            b = numbers[i];
                            numbers[i]= numbers[k];
                            numbers[k] = b;
                            
                        }
                    }
                }
            return numbers;
        }
    
    }
}
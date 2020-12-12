// 
using System;

namespace practice_c_
{
    public class Sort
    {
        public static int[] Get_sort(int[] numbers)
        {
            int smaller = 0;
            
            // this loop for ordering the array
            for (int i = 0; i < numbers.Length; i++)  
                { 
                    // this for compare the element in array togther 
                    for (int k = i+1; k < numbers.Length; k++)
                    {
                        if (numbers[i]> numbers[k]) // then we save them by ascending .
                        {
                            smaller = numbers[i];
                            numbers[i]= numbers[k];
                            numbers[k] = smaller;
                            
                        }
                    }
                }
            return numbers; // at the end return a sorted array .
        }
    
    }
}

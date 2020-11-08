using System;
using System.Collections.Generic;

namespace practice_c_
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine(Factor.IsFactor(80,150)); // false
          Console.WriteLine(Digit.Is_Digit("b")); // false
          Console.WriteLine(Digit.Is_Digit("b145")); // false
          Console.WriteLine(Digit.Is_Digit("1459")); // true 

          var numbers = new int[] { 4 ,5 ,1 ,2 ,10};

         Console.WriteLine(Sort.Select_Number(numbers , true ,2)); // 5
         Console.WriteLine(Sort.Select_Number(numbers , false ,1));  //1
         Console.WriteLine(Sort.Select_Number(numbers , true ,1)); //10
        
        }
    }
}

using System;

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

        }
    }
}

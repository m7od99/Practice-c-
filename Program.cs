using System;
using System.Collections.Generic;
using System.Linq;


namespace practice_c_
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine(Factor.IsFactor(80,150)); // false
          Console.WriteLine(Factor.IsFactor(2,200)); // true
          Console.WriteLine(Factor.IsFactor(20,400)); // true
          Console.WriteLine(Digit.Is_Digit("b")); // false
          Console.WriteLine(Digit.Is_Digit("b145")); // false
          Console.WriteLine(Digit.Is_Digit("1459")); // true 

          var numbers = new int[] { 4 ,5 ,1 ,2 ,10};

          Console.WriteLine(Select.Select_Number(numbers , false , 1)); // 1
          Console.WriteLine(Select.Select_Number(numbers , false ,2)); //2
          Console.WriteLine(Select.Select_Number(numbers , false ,3)); //4
          Console.WriteLine(Select.Select_Number(numbers , true ,1)); // 10
          Console.WriteLine(Select.Select_Number(numbers , true ,2)); // 5
          Console.WriteLine(Select.Select_Number(numbers , true ,3)); // 4

          Console.WriteLine(Pattern.Get_Pattern("love" , "live"));  // ve
          Console.WriteLine(Pattern.Get_Pattern("love" , "elon"));  // lo
          Console.WriteLine(Pattern.Get_Pattern("hellooooo" , "hello"));  // hello
          Console.WriteLine(Pattern.Get_Pattern("look" , "tooklook"));  // look
          Console.WriteLine(Pattern.Get_Pattern("ok.ok" , "ok.ok"));  // ok.ok
          Console.WriteLine(Pattern.Get_Pattern("dddkokokdle" , "bokds"));  // okd
          Console.WriteLine(Pattern.Get_Pattern("ttd" , "dottttk")); //tt

          for (int i = 0; i < 100; i++)
          {
             Console.Write(Util.TestFactor()+ " "); // true
          }
          System.Console.WriteLine();
          System.Console.WriteLine();
          for (int i = 0; i < 1000; i++)
          {
             Console.Write(Util.TestSellect()+" "); // true 
          }

          
        }
    }

}

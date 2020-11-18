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

          var numbers = new int[] { 4 ,5 ,1 ,2 ,2 };

          Console.WriteLine(Select.Select_Number(numbers , false , 1)); // 1
          Console.WriteLine(Select.Select_Number(numbers , false ,2)); //2
          Console.WriteLine(Select.Select_Number(numbers , false ,3)); //4
          Console.WriteLine(Select.Select_Number(numbers , true ,1)); // 10
          Console.WriteLine(Select.Select_Number(numbers , true ,2)); // 5
          Console.WriteLine(Select.Select_Number(numbers , true ,3)); // 4

          Console.WriteLine(Pattern.Get_Psttern("love" , "live"));  // ve
          Console.WriteLine(Pattern.Get_Psttern("love" , "elon"));  // lo
          Console.WriteLine(Pattern.Get_Psttern("hellooooo" , "hello"));  // hello
          Console.WriteLine(Pattern.Get_Psttern("look" , "tooklook"));  // look
          Console.WriteLine(Pattern.Get_Psttern("okok " , "okoo"));  // look


          

          
    
        }
    }

}

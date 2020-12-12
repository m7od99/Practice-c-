namespace practice_c_
{
    public class Select
    {
         public static int Select_Number(int[] numbers ,bool select ,int target) 
        {   
            if (select == false) // if false Descending 
            {
             int[] copyArray = Select.Copy_Array(numbers); // make copy for array 
             var smallest =0;

             for (int i = 0; i < target; i++)
             {
                 smallest = Select.MinNumber(copyArray); // find smallest number 
                 Select.Skip(copyArray , false ,target); // then skip it until match the target . 
             }
             return smallest;
            }

            else // the same thing for Ascending 
            {
             int[] copyArray = Select.Copy_Array(numbers);
             var largest =0;

             for (int i = 0; i < target; i++)
             {
                 largest = Select.MaxNumber(copyArray); 
                 Select.Skip(copyArray , true ,target);
             }
             return largest;
            
            }

        }
        public static int IndexOf(int[] numbers ,int number)
       {
           var index = 0;
           for (int i = 0; i < numbers.Length; i++)
           {
               if (numbers[i] == number)
               {
                   index = i ;
               }
           }
           return index ;
       }
         public static char[] ToCharArray(string input)
        {
            var toChar = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                toChar[i] = input[i];
            }
            return toChar;
        }   
         public static string SubString(string input , int from , int to)
       {
           var sub = "";
           for (int i = from; i <= to; i++)
           {
               sub= sub + input[i];
           }
           return sub;
       }
         public static string Longest_String(string[] input)
       {
           var counts = new int[input.Length];
           for (int i = 0; i < input.Length; i++)
           {
                counts[i] = input[i].Length;
           }
    
           var longest = Select.MaxNumber(counts);
           var longestWord ="";
           for (int i = 0; i < input.Length; i++)
           {
               if (input[i].Length == longest)
               {
                   longestWord = input[i];
               }
           }

           return longestWord;
       }

         public static int[] Copy_Array(int[] numbers)
        {

            int[]copy = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                copy[i] = numbers[i];
            }
            return copy;
        }
        public static int MaxNumber(int[] numbers)
        {
            var cNumber = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > cNumber)
                {
                    cNumber = numbers[i];
                }
            }
            return cNumber;
        }
         public static int MinNumber(int[] numbers)
        {
            var cNumber = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < cNumber)
                {
                    cNumber = numbers[i];
                }
            }
            return cNumber;
        }    
        public static int Skip(int[] numbers , bool size , int target)
        {
            var ignore = 0;
            foreach(var item in numbers)
            {
                ignore = ignore + item ;
            }
            if (size == true)
            {
                int max = Select.MaxNumber(numbers);
                int index = 0;
                for (int a = 0; a < target; a++)
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                       if (numbers[i] == max)
                         {
                             index = i;
                         }
                     }
                     max = Select.MaxNumber(numbers);
                }
                
                 return numbers[index]=0;
            }
            else 
            {
                int max = Select.MinNumber(numbers);
                int index = 0;
                for (int a = 0; a < target; a++)
                {
                     for (int i = 0; i < numbers.Length; i++)
                    {
                       if (numbers[i] == max)
                         {
                             index = i;
                         }
                     }
                     max = Select.MinNumber(numbers);
                }
               
                 return numbers[index]=ignore;
            }
            
        }

   
     }
 }

namespace practice_c_
{
    public class Select
    {
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
               
                 return numbers[index]=99999995;
            }
            
        }

        public static int Select_Number(int[] numbers ,bool select ,int target) 
        {   
            if (select == false)
            {
             int[] copyArray = Select.Copy_Array(numbers);
             var smallest =0;

             for (int i = 0; i < target; i++)
             {
                 smallest = Select.MinNumber(copyArray); 
                 Select.Skip(copyArray , false ,target);
             }
             return smallest;
            }

            else
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
   
     }

 }
namespace practice_c_
{
    public class Select
    {
          public static int Select_Number(int[]numbers ,bool select ,int target) 
        {   
            if (select == false)
            {
             var copyArray = new int[numbers.Length];

             for (int i = 0; i < numbers.Length; i++)
                 copyArray[i] = numbers[i];
            
             var index = 0;
             var smallest = 0;
             var cNumber = copyArray[0];

             for (int i = 0; i < target; i++)
             {
                 for (int a = 0; a < copyArray.Length; a++)
                 {
                     if (copyArray[a] < cNumber)
                     {
                         cNumber = numbers[a];
                         index = a ;
                     }
                 }
                 smallest = cNumber;
                 cNumber = copyArray[0];
                 copyArray[index] = 955555554;
                 
             }
             return smallest;
            }

            else
            {
             var copyArray = new int[numbers.Length];
             for (int i = 0; i < numbers.Length; i++)
                 copyArray[i] = numbers[i];
             
             var largest = 0;
             var idex = 0;
             var cNumber = copyArray[0];

             for (int i = 0; i < target; i++)
             {
                 for (int a = 0; a < copyArray.Length; a++)
                 {
                     if (copyArray[a] > cNumber)
                     {
                         cNumber = numbers[a];
                         idex = a ;
                     }      
                 }
                 largest = cNumber;
                 cNumber = copyArray[0];
                 copyArray[idex] =0;
             }
             
             return largest;
            }
        }
    }
}
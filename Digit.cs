namespace practice_c_
{
     class Digit
    {
       public static bool Is_Digit(string input)
       {  
           var count = 0;
           while (true)
           {
               foreach (var item in input)
               {
                   if ((int)item >=48 && (int)item <=57)
                   {
                       count++;
                   }
               }
               break;
           }
             if (count == input.Length)
               {
                   return true ;
               }
               else return false;
       }
    }
}
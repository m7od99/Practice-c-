namespace practice_c_
{
     class Digit
    {
       public static bool Is_Digit(string input)
       {  
           while (true)
           {
               foreach (var item in input)
               {
                   if ((int)item >=57 || (int)item <=48)
                   {
                       return false;
                   }
                    else return true;
               }
           }
          
       }
    }
}
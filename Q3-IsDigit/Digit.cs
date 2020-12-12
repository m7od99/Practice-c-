namespace practice_c_
{
     class Digit
    {
       public static bool Is_Digit(string input)
       {  
           while (true)
           {
               // if evrey characters in string bettwen 47 and 58 (according to ASCII) return true "digit "
               foreach (var item in input)
               {
                   if ((int)item >58 || (int)item <47)
                       return false;
                   
                    else return true;
               }
           }
          
       }
    }
}

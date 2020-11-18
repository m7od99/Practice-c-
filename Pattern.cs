using System;

namespace practice_c_

{
     class Pattern
    {
       public static string Get_Psttern(string first , string second)
       {
           var sstring = "";
           var index = 0;
           var words = new string[second.Length];
           var isIn = true;
           for (int a = 0; a < second.Length; a++)
           {
               for (int i = 0; i < first.Length; i++)
               {
                   if (second[a] == first[i] && i == a && isIn == true)
                   {
                       sstring =sstring+ first[i];
                       index = i;
                       isIn = false;
                   }
                   else if (second[a] == first[i] && i > index && isIn == true)
                   {
                       sstring = sstring+first[i];
                       index=i;
                       isIn = false;
                   }
                   else if (second[a] == first[i] && i < index && isIn == true)
                   {
                       sstring = "" +first[i];
                       index =i;
                       isIn = false;
                   }
               }
               words[a]= sstring;  
               if (second[a] != first[index] && isIn == true)
               {
                   index=0;
                   sstring="";
               }
               isIn = true;
           }
           return Select.Longest_String(words);
       }

    }
}
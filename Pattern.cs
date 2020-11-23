using System;
using System.Collections.Generic;
using System.Linq;

namespace practice_c_

{
     class Pattern
    {
        public static string Get_Pattern(string first , string second)
        {
            //  initialize a counter set it to 0 .
            var counter = 0;
            // initialize a index set it to 0 , then take first pattern position to compare it with other .
            var index = 0;
           //  initialize a bool switch to keep the count in the right position.
            var stop = true;
            //0- initialize a list of int tuples named size .
            var size = new List<(int w, int counter )>();

            var i = 0; // i for whlie .

            // for every character w in string 2 , for every character in string 1 that match it :
            while(i < second.Length)
            {
                for (int k = index; k < first.Length; k++)
                {
                    if (second[i] == first[k] && stop == true)
                    {
                        counter++;
                        stop = false;
                        index = k;
                        // while both string have characters keep incrementing to two string indexes .
                        counter = counter +Pattern.counterNextPattern(first,second, k , i);
                    }
                }
                size.Add((i, counter));
                // cheack if w have another character in string 1 that match it . 
                if (Pattern.IsAontherPattern(first , second[i] , index+1) == true)
                {
                    //if yes continue count . from new position 
                    stop = true ;
                    counter = 0 ;
                    index = index +1; 
                    continue;
                }
                else // if no, go for next w . 
                {
                    index = 0;
                    stop = true;
                    counter = 0;
                    i++;
                }
            }   
            return Pattern.Longest_Pattern(size , second); // return longest pattern .

        }
        public static bool IsAontherPattern(string first , char second , int index)
        {
            //to cheack if there another pattern start with same characters 
            var isTrue = false;
            for (int i = index; i < first.Length; i++)
            {
                if (second == first[i])
                {
                    isTrue= true;
                }
            }
            return isTrue;
        }

        public static bool IsMoreCharacters(string first , int index)
        {
            // to cheack if there more chracters .
            if (first.Length -1 == index)
            {
                return false;
            }
            else return true;
        }
        public static int counterNextPattern(string first , string second ,int index1 ,int index2)
        {
            var counterer = 0;
            //while both string have characters keep incrementing to two string indexes 
            while (Pattern.IsMoreCharacters(first,index1) == true && Pattern.IsMoreCharacters(second,index2) == true)
            {
                if (first[index1 +1 ] == second [index2 +1 ])
                {
                    counterer++;
                    index1 = index1+1;
                    index2 = index2+1;
                }
                else break;
            }
             return counterer ;
        }

        public static string Longest_Pattern(List<(int w , int counter)> numbers , string second)
        {
           var max  = numbers.Max(o => o.Item2); // find maxe value in counter .
           var index = numbers.FindIndex(0 , x => x.Item2 == max); // then find index of it .
           var start = numbers[index].Item1; // take w  for starting substring and max for stop .
           
           return second.Substring(start , max);
        }

    }
}
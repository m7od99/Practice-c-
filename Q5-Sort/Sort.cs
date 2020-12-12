// 
using System;
using System.Collections.Generic;
namespace practice_c_ {
    public class Sort {
        public static int[] Get_sort (int[] numbers) {
            int smaller = 0;

            // this loop for ordering the array
            for (int i = 0; i < numbers.Length; i++) {
                // this for compare the element in array togther 
                for (int k = i + 1; k < numbers.Length; k++) {
                    if (numbers[i] > numbers[k]) // then we save them by ascending .
                    {
                        smaller = numbers[i];
                        numbers[i] = numbers[k];
                        numbers[k] = smaller;

                    }
                }
            }
            return numbers; // at the end return a sorted array .
        }
        
        public static int[] QSort(int[] A)
        {
            // 1- If  size (A) = 2 :   
            //  -Compare and fix order
            //  -return A
            if (A.Length < 2)
            {
                return A;
            }

            // 2-  pick some element in A (call it k)
            var k = A[0];

            // 3- make 2 lists  B and C
            var B = SmallerThen(A , k);
            var C = BiggerThen(A ,k);

            // -4 Sort(B) , Sort(C) .
            B = QSort(B);
            C = QSort(C);

            // 5- modify A .
            A = Modify(B , C ,k);
            // 6- return A .
            return A;
        }

        public static int[] SmallerThen(int[] numbers , int k)
        {
            var x = 0;
            var smaller = new List<int>();
            foreach(var number in numbers)
            {
                if (number < k)
                {
                    smaller.Add(number);
                }
                else if (number == k)
                {
                    x++;
                    if (x > 1)
                    {
                        smaller.Add(k);
                        x--;
                    }
                }
            }
            return smaller.ToArray();
        }
          public static int[] BiggerThen(int[] numbers , int k)
        {
            var Bigger = new List<int>();
            foreach(var number in numbers)
            {
                if (number > k)
                {
                    Bigger.Add(number);
                }
            }
            return Bigger.ToArray();
        }

        public static int[] Modify(int[] smaller , int[] bigger , int k)
        {
            var A = new List<int>();
            for (int i = 0; i < smaller.Length; i++)
            {
                A.Add(smaller[i]) ;
            }
            A.Add(k);
            for (int d = 0; d < bigger.Length; d++)
            {
                A.Add(bigger[d]);
            }
            return A.ToArray();
        }

    }
}
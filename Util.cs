using System;

namespace practice_c_
{
    public class Util
    {
        public static bool TestFactor()
        {
            var x = RandomNumber();
            var y = RandomNumber();
            if (Factor.IsFactor(x,y) == true && y%x >0)
            {
                return false;
            }
            return true;
        }

        public static int RandomNumber()
        {
            return new Random().Next(1,1000);
        }
        public static int LengthIntArray()
        {
            return new Random().Next(1000,1000);
        }
        public static int[] RandomIntArray()
        {
            var x = new int[LengthIntArray()];
            for (int i = 0; i < x.Length; i++)
            {
                x[i] =LengthIntArray();
            }
            return x;
        }
        public static bool TestSellect()
        {
            var numbers = RandomIntArray();
            var isTrue = RandomBool();
            var target = RandomNumber();
            var select = Select.Select_Number(numbers , isTrue ,target);
            numbers = Sort.QSort(numbers);
            
            if (isTrue == false)
            {
                if (numbers[target-1] == select)
                {
                    return true ;
                }
                else return false;
            }
            else
            {
                Array.Reverse(numbers);
                if (numbers[target-1] == select)
                {
                    return true ;
                }
                else return false;
            }

        }
        public static bool RandomBool()
        {
            var x = new Random().Next(1,2);
            if (x/2 ==1)
            {
                return true;
            }
            return false;
        }
    }
}
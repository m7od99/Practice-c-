//given tow numbers- program that tell if the second number is a factor of the list 

namespace practice_c_
{
    class Factor
    {
        public static bool IsFactor(int first , int second)
        {
            if (second%first ==0)
                return true ;
            else return false ;
        }
    }
}
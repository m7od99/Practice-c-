

namespace practice_c_
{
    class Factor
    {
        public static bool IsFactor(int first , int second)
        {
            // if reminder = 0 return true else false .
            if (second%first ==0) 
                return true ;
            else return false ;
        }
    }
}
using System;

namespace practice_c_ {
    public class Util {
        public static bool TestFactor () {
            var x = RandomNumber ();
            var y = RandomNumber ();
            if (Factor.IsFactor (x, y) == true && y % x > 0) {
                return false;
            }
            return true;
        }

        public static int RandomNumber () {
            return new Random ().Next (1, 1000);
        }
        public static int LengthIntArray () {
            return new Random ().Next (1000, 1000);
        }
        public static int[] RandomIntArray () {
            var x = new int[LengthIntArray ()];
            for (int i = 0; i < x.Length; i++) {
                x[i] = LengthIntArray ();
            }
            return x;
        }
        public static bool TestSellect () {
            var numbers = RandomIntArray ();
            var isTrue = RandomBool ();
            var target = RandomNumber ();
            var select = Select.Select_Number (numbers, isTrue, target);
            numbers = Sort.QSort (numbers);

            if (isTrue == false) {
                if (numbers[target - 1] == select) {
                    return true;
                } else return false;
            } else {
                Array.Reverse (numbers);
                if (numbers[target - 1] == select) {
                    return true;
                } else return false;
            }

        }
        public static bool RandomBool () {
            var x = new Random ().Next (1, 2);
            if (x / 2 == 1) {
                return true;
            }
            return false;
        }

        public static string RandomNumbersString () {
            string alph = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var word = "";

            for (int i = 0; i < 10; i++) {
                word = word + alph[LitterNRandom ()];
            }
            return word;
        }
        static int LitterNRandom () => new Random ().Next (23, 35);
        static int LitterRandom () => new Random ().Next (0, 26);

        public static bool TestIsDigits () {
            var x = RandomNumbersString ();
            if (Digit.Is_Digit (x) == true && IsDigits (x) == false) {
                return false;
            }
            return true;
        }

        public static bool IsDigits (string input) {
            foreach (var latter in input) {
                if (char.IsDigit (latter) == false) {
                    return false;
                }
            }
            return true;
        }

        public static string RandomString () {
            string alpha = " ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var word = "";
            for (int i = 0; i < 100; i++) {
                word = word + alpha[LitterRandom ()];
            }
            return word;
        }
        public static bool TestIsPattern () {
            var word = RandomString ();
            var wordplus = RandomStringPlus (word);
            if (Pattern.Get_Pattern (wordplus, word) == word) {
                return true;
            }
            return false;
        }
        public static string RandomStringPlus (string input) {
            string alpha = " ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            for (int i = 0; i < 30; i++) {
                input = input + alpha[LitterRandom ()];
            }
            return input;
        }

    }
}
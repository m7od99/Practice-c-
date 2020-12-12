namespace practice_c_ {
    public class Select {
        public static int Select_Number (int[] numbers, bool select, int target) {
            if (select == false) // if false Descending 
            {
                int[] copyArray = Select.Copy_Array (numbers); // make copy for array 
                var smallest = 0;

                for (int i = 0; i < target; i++) {
                    smallest = Select.MinNumber (copyArray); // find smallest number 
                    SkipSmaller (copyArray); // then skip it until match the target . 
                }
                return smallest;
            } else // the same thing for Ascending 
            {
                int[] copyArray = Select.Copy_Array (numbers);
                var largest = 0;

                for (int i = 0; i < target; i++) {
                    largest = Select.MaxNumber (copyArray);
                    SkipBigger (copyArray);
                }
                return largest;

            }

        }
        public static int IndexOf (int[] numbers, int number) {
            var index = 0;
            for (int i = 0; i < numbers.Length; i++) {
                if (numbers[i] == number) {
                    index = i;
                }
            }
            return index;
        }
        public static char[] ToCharArray (string input) {
            var toChar = new char[input.Length];
            for (int i = 0; i < input.Length; i++) {
                toChar[i] = input[i];
            }
            return toChar;
        }
        public static string SubString (string input, int from, int to) {
            var sub = "";
            for (int i = from; i <= to; i++) {
                sub = sub + input[i];
            }
            return sub;
        }
        public static int[] Copy_Array (int[] numbers) {

            int[] copy = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++) {
                copy[i] = numbers[i];
            }
            return copy;
        }
        public static int MaxNumber (int[] numbers) {
            var cNumber = numbers[0];
            for (int i = 0; i < numbers.Length; i++) {
                if (numbers[i] > cNumber) {
                    cNumber = numbers[i];
                }
            }
            return cNumber;
        }
        public static int MinNumber (int[] numbers) {
            var cNumber = numbers[0];
            for (int i = 0; i < numbers.Length; i++) {
                if (numbers[i] < cNumber) {
                    cNumber = numbers[i];
                }
            }
            return cNumber;
        }

        public static int IgnoreSmallerNumber (int[] numbers) {
            var ignore = 0;
            foreach (var item in numbers) {
                ignore = ignore + item;
            }
            return ignore;
        }
        public static int[] SkipSmaller (int[] numbers) {
            var ignore = 2147483647;
            var min = MinNumber (numbers);
            for (int i = 0; i < numbers.Length; i++) {
                if (numbers[i] == min) {
                    numbers[i] = ignore;
                    break;
                }
            }
            return numbers;
        }

        public static int[] SkipBigger (int[] numbers) {
            var max = MaxNumber (numbers);
            for (int i = 0; i < numbers.Length; i++) {
                if (max == numbers[i]) {
                    numbers[i] = 0;
                    break;
                }
            }
            return numbers;
        }

    }
}
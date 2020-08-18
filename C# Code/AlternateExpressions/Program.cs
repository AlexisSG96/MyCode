using System;

namespace AlternateExpressions
{
    class Program
    {
        // Method to be used as second argument
        public static bool IsLong(string word)
        {
            return word.Length > 8;
        }
        public static bool IsEven(int num)
        {
            return num % 2 == 0;
        }
        static void Main(string[] args)
        {
            //--------------------------------------------------------------------------------------------------------------------------
            Welcome("Earth");
            double days = 500;
            double rotations = DaysToRotations(days);
            Console.WriteLine($"In {days} days, the Earth has rotated {rotations} time(s).");
            //--------------------------------------------------------------------------------------------------------------------------
            // Array to be used as first argument
            string[] adjectives = { "rocky", "mountainous", "cosmic", "extraterrestrial" };

            // Call Array.Find() and 
            // Pass in the array and method as arguments, returns the first value according to the definition
            string firstLongAdjective = Array.Find(adjectives, IsLong);

            Console.WriteLine($"The first long word is: {firstLongAdjective}.");
            //--------------------------------------------------------------------------------------------------------------------------
            string[] spaceRocks = { "meteoroid", "meteor", "meteorite" };

            bool makesContact = Array.Exists(spaceRocks, (string s) => s == "meteorite");

            if (makesContact)
            {
                Console.WriteLine("At least one space rock has reached the Earth's surface!");
            }
            //--------------------------------------------------------------------------------------------------------------------------
            /*
            The type of num is int. It’s great to be explicit like this to avoid errors, but some developers wouldn’t include int. To them, it’s obvious! Here’s their reasoning:

            The modulo operator (%) is only used with numbers, so num must be a number
            The result of the operation num % 2 is compared to the integer 0. We can only compare similar types, so num must also be an integer!
            Therefore, we can remove int without causing any errors
            When there is just one parameter in a lambda expression, we don’t need the parentheses around the parameter either:
            */
            string[] spaceRockss = { "meteoroid", "meteor", "meteorite" };

            bool makesContactt = Array.Exists(spaceRocks, s => s == "meteorite");

            if (makesContactt)
            {
                Console.WriteLine("At least one space rock has reached the Earth's surface!");
            }
            //--------------------------------------------------------------------------------------------------------------------------      
            int[] numbers = { 1, 3, 5, 6, 7, 8 };
            bool hasEvenNumber = Array.Exists(numbers, IsEven);
            if (hasEvenNumber)
            {
                Console.WriteLine($"Even numbers exist?: {hasEvenNumber}");
            }
            //--------------------------------------------------------------------------------------------------------------------------
            bool hasBigDozen = Array.Exists(numbers, (int num) =>
            {
                bool isDozenMultiple = num % 12 == 0;
                bool greaterThan20 = num > 20;
                return isDozenMultiple && greaterThan20;
            });
            Console.WriteLine($"Has big dozen?: {hasBigDozen}");
            //--------------------------------------------------------------------------------------------------------------------------
            int[] nums = { 0, 555, 252, 3, 9, 101 };

            bool hasBigNum = Array.Exists(nums, isBig);

            bool hasSmallNum = Array.Exists(nums, isSmall);

            bool hasMediumNum = Array.Exists(nums, (n) => n >= 10 && n <= 100);

            Console.WriteLine($"Any big #s? {hasBigNum}");
            Console.WriteLine($"Any small #s? {hasSmallNum}");
            Console.WriteLine($"Any medium #s? {hasMediumNum}");
        }
        static bool isBig(int n) => n > 100;
        static bool isSmall(int n) => n < 10;
        static bool HitGround(string s)
        {
            return s == "meteorite";
        }

        static double DaysToRotations(double days) => days / 365;

        static void Welcome(string planet) => Console.WriteLine($"Welcome to {planet}!");

    }
}

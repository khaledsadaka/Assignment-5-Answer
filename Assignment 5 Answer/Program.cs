namespace Assignment_5_Answer
{
    internal class Program
    {
        static void Swap(ref int x, ref int y)
        {
            int temp = x; 
            x = y;       
            y = temp;     
        }


        public static (int, int) SumSub(int x, int y, ref int sum, ref int sub)
        {
            sum = x + y;
            sub = x - y;
            return (sum, sub);

        }

        static int SumDigits(int num)
        {
            int result = 0;
            while (num > 0)    
            {
                result += num % 10;
                num /= 10;
            }
            return result;

        }

        static bool isPrime(int n)
        {
            if (n <= 1) return false;


            for (int i = 2; i * i <= n; i++)  
            {
                if (n % i == 0) return false;
            }
            return true;

        }

        static int[] MinMax(int[] arr)
        {

            int min = arr[0];
            int max = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            int[] result = { min, max };
            return result;

        }

        static int Factorial(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return (result);
        }



        static void Main(string[] args)
        {
            #region Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.

            /*

            int a = 5, b = 10;

            Console.WriteLine($"Before Swap: a = {a}, b = {b}");

            Swap(ref a, ref b);

            Console.WriteLine($"After Swap: a = {a}, b = {b}");

            */

            #endregion

            #region Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.

            /*

            int a = 5, b = 10;

            Console.WriteLine($"Before Swap: a = {a}, b = {b}");

            Swap(ref a, ref b);

            Console.WriteLine($"After Swap: a = {a}, b = {b}");

            */

            #endregion

            #region Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

            /*

            int x, y, sum = 0, sub = 0;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            (int, int) result = SumSub(x, y, ref sum, ref sub);

            Console.WriteLine(sum);
            Console.WriteLine(sub);

            */

            #endregion

            #region Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.

            /*

            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(SumDigits(num));

            */

            #endregion

            #region Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:

            /*

            int num = int.Parse(Console.ReadLine());
            bool prime = isPrime(num);
            if (prime)
            {
                Console.WriteLine("prime");
            }
            else
            {
                Console.WriteLine("not prime");
            }

            */

            #endregion

            #region Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters

            /*

            int[] arr = { 10, 2, 5, 7, 4, 7, -5 };
            int[] arrResult = MinMax(arr);
            Console.WriteLine(arrResult[0]);
            Console.WriteLine(arrResult[1]);

            */

            #endregion

            #region Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter

            /*

            Console.WriteLine(Factorial(7));

            */

            #endregion

            #region Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter

            /*


            */

            #endregion



        }
    }
}

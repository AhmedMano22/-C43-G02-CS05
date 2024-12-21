using System.Runtime.ExceptionServices;

namespace assgiment_5
{
    internal class Program
    {

        #region Q1
        //First pass by value 
        /* When parameters are passed by value, we take a copy from values and  the method receives a copy of the 
         variable's value. Any changes made to the parameter within the method 
          do not affect the original variable outside the method */


        //public static void SWAP(int X, int Y)
        //{
        //    int temp = X;
        //    X = Y;
        //    Y = temp;
        //}


        // second Passing by reference
        /*
         When parameters are passed by reference, the method receives the memory address of the variable. 
         so changes will affect on the original values
         
         */
        //public static void SWAP(ref int X, ref int Y)
        //{
        //    int temp = X;
        //    X = Y;
        //    Y = temp;
        //}
        #endregion
        #region Q2
        //public static int SumArray(ref int[] arr)
        //{
        //    int sum = 0;
        //    if (arr is not null)
        //    {
              
        //        arr = new int[] { 10, 20, 30, 40 };

              
        //        for (int i = 0; i < arr.Length; i++)
        //            sum += arr[i];
        //    }

           
        //    return sum;
        //}
        #endregion
        #region Q3
        //public static void SumSub(int x, int y, out int sum, out int sub)
        //{
        //    sum = x + y;
        //    sub = x - y;
        //}
        #endregion
        #region Q4
        //public static int SumOfDigits(int number)
        //{
        //    int sum = 0;

        //    // loop in mumber  characters as string
        //    foreach (char digit in number.ToString())
        //    {
        //        //here convert charcters to number to make summiton
        //        sum += int.Parse(digit.ToString());  
        //    }

        //    return sum;
        //}
        #endregion
        #region Q5
        //public static bool IsPrime(int number)
        //{
        //    // Edge case: Numbers less than or equal to 1 are not prime
        //    if (number <= 1)
        //    {
        //        return false;
        //    }

        //    // Check for divisibility from 2 to the square root of the number
        //    for (int i = 2; i <= Math.Sqrt(number); i++)
        //    {
        //        if (number % i == 0)
        //        {
        //            return false; // If divisible, the number is not prime
        //        }
        //    }

        //    return true; 
        //}
        #endregion
        #region Q6
        //public static void MinMaxArray(int[] arr, ref int min, ref int max)
        //{
        //    // i will  set min and max to the first element of the array
        //    min = arr[0];
        //    max = arr[0];

        //    // Loop through the array 
        //    foreach (int num in arr)
        //    {
        //        if (num < min)
        //        {
        //            min = num;  // here when find number is smaller put it to min 
        //        }

        //        if (num > max)
        //        {
        //            max = num; // here when find number is larger put it to max 
        //        }
        //    }

        //}
        #endregion
        #region Q7
        //public static long Factorial(int number)
        //{
        //    // If the number is less than 0, factorial is not defined
        //    if (number < 0)
        //    {
        //        throw new ArgumentException("Factorial is not defined for negative numbers.");
        //    }

        //    // Initialize result to 1
        //    long result = 1;

        //    // Loop through all numbers from 1 to the given number
        //    for (int i = 1; i <= number; i++)
        //    {
        //        result *= i;  // Multiply the result by i
        //    }

        //    return result;
        //}
        #endregion
        #region Q8
        //public static string ChangeChar(string input, int position, char newChar)
        //{
        //    // If the position is out of length, return the original string
        //    if (position < 0 || position >= input.Length)
        //    {
        //        return input;
        //    }

        //    // Convert the string to a char array to allow modification
        //    char[] charArray = input.ToCharArray();

        //   
        //    charArray[position] = newChar;

        //   
        //    return new string(charArray);
        //}
        #endregion
        static void Main(string[] args)
            {
            #region Answer 1
            //int A = 10, B = 5;
            //Console.WriteLine($"Before Swap (By Value):");
            //Console.WriteLine($"A = {A}"); // 10
            //Console.WriteLine($"B = {B}"); // 5

            //// Swap by value
            //SWAP(A, B);

            //Console.WriteLine("After Swap (By Value):");
            //Console.WriteLine($"A = {A}"); // 10 (unchanged)
            //Console.WriteLine($"B = {B}"); // 5 (unchanged)

            //Console.WriteLine(); // Empty line for separation

            //// Example 2: Passing by reference
            //A = 10;
            //B = 5;
            //Console.WriteLine($"Before Swap (By Reference):");
            //Console.WriteLine($"A = {A}"); // 10
            //Console.WriteLine($"B = {B}"); // 5

            //// Swap by reference
            //SWAP(ref A, ref B);

            //Console.WriteLine("After Swap (By Reference):");
            //Console.WriteLine($"A = {A}"); // 5 (swapped)
            //Console.WriteLine($"B = {B}"); // 10 (swapped)
            #endregion
            #region Answer 2
            //int[] numbers = { 1, 2, 3 };
            //Console.WriteLine("Passing by Value:");

            //// Passing the array by value (the method receives a copy of the reference)
            //int result = SumArray(numbers); // Passing By Value
            //Console.WriteLine($"Sum = {result}"); // 100 (sum of 10+20+30+40)
            //Console.WriteLine($"Numbers[0] = {numbers[0]}"); // 1 (unchanged, original array is not modified)
            //Console.WriteLine($"Original array's HashCode: {numbers.GetHashCode()}"); // Same reference, not changed

            //Console.WriteLine(); // Empty line for separation

            //// Example 2: Passing by Reference
            //numbers = new int[] { 1, 2, 3 };
            //Console.WriteLine("Passing by Reference:");

            //// Passing the array by reference (the method modifies the original reference)
            //int resultRef = SumArray(ref numbers); // Passing By Reference
            //Console.WriteLine($"Sum = {resultRef}"); // 100 (sum of 10+20+30+40)
            //Console.WriteLine($"Numbers[0] = {numbers[0]}"); // 10 (array is modified)
            //Console.WriteLine($"Original array's HashCode: {numbers.GetHashCode()}"); // Different reference, array is modified
            #endregion
            #region Answer3
            //Console.Write("Enter first number (x): ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("Enter second number (y): ");
            //int b = int.Parse(Console.ReadLine());
            //int SumResult, SubResult;
            //SumSub(a, b, out SumResult, out SubResult);
            //Console.WriteLine($"Sum Result = {SumResult}");
            //Console.WriteLine($"Sub Result = {SubResult}");
            #endregion
            #region Answer 4
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());
            //int result = SumOfDigits(number);
            //Console.WriteLine($"The sum of the digits of the number {number} is: {result}");
            #endregion
            #region Answer 5
            //i search on ths
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());
            //bool result = IsPrime(number);

            //if (result)
            //{
            //    Console.WriteLine($"{number} is a prime number.");
            //}
            //else
            //{
            //    Console.WriteLine($"{number} is not a prime number.");
            //}
            #endregion
            #region Answer 6
            //int[] numbers = { 5, 3, 8, 1, 7, 6, 2 };


            //int min = 0, max = 0;
            //MinMaxArray(numbers, ref min, ref max);
            //Console.WriteLine($"The minimum value in the array is: {min}");
            //Console.WriteLine($"The maximum value in the array is: {max}");
            #endregion
            #region Answer 7
            // Accept user input for the number
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //long result = Factorial(number);

            //// Display the result
            //Console.WriteLine($"The factorial of {number} is: {result}");
            #endregion
            #region Answer 8
            //Console.Write("Enter a string: ");
            //string input = Console.ReadLine();
            //Console.Write("Enter the position to change (0-based index): ");
            //int position = int.Parse(Console.ReadLine());

            //Console.Write("Enter the new character: ");
            //char newChar = char.Parse(Console.ReadLine());
            //string modifiedString = ChangeChar(input, position, newChar);
            //Console.WriteLine($"Modified string: {modifiedString}");
            #endregion

        }
        
    }
}

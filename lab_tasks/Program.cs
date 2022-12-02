using System;
using System.Text;

namespace lab_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //Console.WriteLine("This app checks if the sum of digits of a given number is equal to the square of the first digit of it");
            //Console.WriteLine("Please, enter a three-digit number to check:");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int firstDigit = number / 100;
            //int sumOfDigitsOfNum = sumOfDigits(number);
            //Console.WriteLine("Sum of digits of " + number + ": " + sumOfDigitsOfNum);
            //Console.WriteLine("Square of the first digit of " + number + ": " + Math.Pow(firstDigit, 2));
            //isEqualToSquare(firstDigit, sumOfDigitsOfNum);
            #endregion
            #region Task 2
            //Console.WriteLine("This app checks if the sum of digits of a given number is an even number. If yes, the app will show the products of its digits");
            //Console.WriteLine("Please, enter a two-digit number to check:");
            //int secondTaskNum = Convert.ToInt32(Console.ReadLine());
            //int secondTaskSum = sumOfDigits(secondTaskNum);
            //if (secondTaskSum%2==0)
            //{
            //    Console.WriteLine("The products of digits is " + productOfDigits(secondTaskNum));
            //} else
            //{
            //    Console.WriteLine("Entered number's sum of digits is NOT an even number");
            //}
            #endregion
            #region Task 3
            //int[] integers= {25,1,2,3,4,5,24 };
            //reverseIntArray(integers);
            #endregion

            #region 21 Nov Task 1
            //Console.WriteLine("This app adds any digit to a given number");
            //Console.WriteLine("Please, enter a digit to add:");
            //int addNum = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please, enter a number:");
            //int num = Convert.ToInt32(Console.ReadLine());
            //addNumberToBeginning(addNum,num);
            #endregion
            #region 22 Nov Task 1
            //CharsInStringCount('a', "Salam");
            #endregion
            #region 22 Nov Task 2
            //LastThreeDigits("ASASDASDASHFAJSFHLS");
            #endregion
            #region 24 Nov Task 1
            //string s = "abcd";
            //int[] numbers = new int[0];
            //for (int i = 0; i <1000; i++)
            //{
            //    Array.Resize(ref numbers, i+1);
            //    numbers[i] = i+1;
            //}
            //foreach (int num in numbers) 
            //{
            //    string numStr = num.ToString();
            //    if (numStr.Contains('3') == false && numStr.Contains('4') == false)
            //    {
            //        Console.WriteLine(numStr);
            //    }
            //}
            #endregion
            #region 25 Nov Task 1
            //Console.WriteLine("This app changes first and last digits of the given integer!");
            //Console.WriteLine("Please, enter any number:");
            //int num = Convert.ToInt32(Console.ReadLine());
            //changeFirstAndLast(num); 
            #endregion
            #region 25 Nov Task 2
            Console.WriteLine(elevenElevenEleven());
            #endregion
        }
        static void isEqualToSquare(int firstDigit, int sum)
        {
            if (sum == Math.Pow(firstDigit, 2))
            {
                Console.WriteLine("The sum of digits is equal to the square of the first digit");
            }
            else
            {
                Console.WriteLine("\nThe sum of digits is NOT equal to the square of the first digit");
            }
        }
        static int sumOfDigits(int number)
        {
            int sum = 0;
            int digit;
            while (number > 0)
            {
                digit = number % 10;
                sum += digit;
                number /= 10;
            }
            return (sum);
        }
        static int productOfDigits(int number)
        {
            int product = 1;
            int digit;
            while (number > 0)
            {
                digit = number % 10;
                product *= digit;
                number /= 10;
            }
            return (product);
        }
        static void reverseIntArray(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                int index = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = index;
            }
            string str = string.Join(",", array);
            Console.WriteLine(str);
        }
        static void addNumberToBeginning(int addNumberInit, int number)
        {
            int digitCount = 0;
            int initNum = number;
            while (number > 0)
            {
                number /= 10;
                digitCount++;
            }

            int addNumber = (int)(addNumberInit * Math.Pow(10, Convert.ToDouble(digitCount)));
            initNum += addNumber;
            Console.WriteLine("\n" + initNum);
        }

        static void CharsInStringCount(char letter, string str)
        {
            int count = 0;
            char[] letters = str.ToCharArray();
            foreach (var item in letters)
            {
                if (item == letter)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        static void LastThreeDigits(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (i >= str.Length - 3)
                {
                    Console.Write(str[i]);
                }
            }
        }

        static int changeFirstAndLast(int number)
        {
            int lastDigit = number % 10;
            int digitCount = 0;
            int initNum = number;
            int numberCopy = number;
            while (number > 0) //11111
            {
                number /= 10;
                digitCount++;
            }
            for (int i = 0; i < digitCount - 1; i++)
            {
                initNum /= 10;
            }
            int firstDigit = initNum;
            int powerOf10 = Convert.ToInt32(Math.Pow(10, Convert.ToDouble(digitCount - 1)));
            int lastToAdd = lastDigit * powerOf10;
            numberCopy -= firstDigit * Convert.ToInt32(Math.Pow(10, Convert.ToDouble(digitCount - 1)));
            numberCopy -= lastDigit;
            numberCopy += firstDigit;
            numberCopy += lastToAdd;
            Console.WriteLine(numberCopy);
            return numberCopy;
        }
        static int elevenElevenEleven()
        {
            int[] numbers = new int[0];
            int index = 0;
            for (int i = 11; i < 1000; i += 11)
            {
                if (sumOfDigits(i) > 11)
                {
                    Array.Resize(ref numbers, numbers.Length + 1);
                    numbers[index] = i;
                    index++;
                }
            }
            return numbers[10];
        }
    }
}
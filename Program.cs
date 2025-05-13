using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = checkInput(args);
            bool flage = false;
            while (!flage)
            {
                menuPriter();
                string input = Console.ReadLine();
                switch (input)
                {
                    case "a":
                        intArr = checkInput(args);
                        break;
                    case "b":
                        arrPrinter(intArr);
                        break;
                    case "c":
                        arrPrinter(revers(intArr));
                        break;
                    case "d":
                        arrPrinter(ascendingSort(intArr));
                        break;
                    case "e":
                        singleNumPrinter(max(intArr));
                        break;
                    case "f":
                        singleNumPrinter(min(intArr));
                        break;
                    case "g":
                        singleNumPrinter(avg(intArr));
                        break;
                    case "h":
                        singleNumPrinter(count(intArr));
                        break;
                    case "i":
                        singleNumPrinter(sum(intArr));
                        break;
                    case "j":
                        flage = true;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
            }
        }

        static int[] checkInput(string[] strArr)  // This method takes a string array as input and converts it to an integer array.
        {
            bool flage = false;
            while(flage == false) 
            {
                flage = true;
                if (strArr.Length >= 3)
                {
                    foreach (string str in strArr)
                    {
                        foreach (char ch in str)
                        {
                            if (!char.IsDigit(ch) && ch != ' ')
                            {
                                strArr = getInput();
                                flage = false;
                                break;
                            }
                        }
                        if (!flage)
                        {
                            break;
                        }
                    }
                }
                else
                {
                    strArr = getInput();
                    flage = false;
                }
            }
            return convert(strArr);
        }
        static string[] getInput()
        {
            string[] strArr;
            Console.WriteLine("Please enter a numerical series (Give a space to separate a number from another number): ");
            strArr = Console.ReadLine().Split(' ');
            return strArr;
        }
        static int[] convert(string[] strArr)
        {
            int[] intArr = new int[strArr.Length];
            for (int i = 0; i < strArr.Length; i++)
            {
                intArr[i] = Convert.ToInt32(strArr[i]);
            }
            return intArr;
        }
        // So far, the absorption stage of the numerical series.

        static void menuPriter() 
        { 
            Console.WriteLine("Please select an option from the menu below: ");
            Console.WriteLine("a. Input a Series. (Replace the current series)");
            Console.WriteLine("b. Display the series in the order it was entered.");
            Console.WriteLine("c. Display the series in the reversed order it was entered.");
            Console.WriteLine("d. Display the series in sorted order (from low to high).");
            Console.WriteLine("e. Display the Max value of the series.");
            Console.WriteLine("f. Display the Min value of the series.");
            Console.WriteLine("g. Display the Average of the series.");
            Console.WriteLine("h. Display the Number of elements in the series.");
            Console.WriteLine("i. Display the Sum of the series.");
            Console.WriteLine("j. Exit");
            return;
        }
        static int max(int[] intArr)
        {
            int bigest = 0;
            return bigest;
        }
        static int min(int[] intArr)
        {
            int smallest = 0;
            return smallest;
        }
        static int sum(int[] intArr)
        {
            int sum = 0;
            return sum;
        }
        static int avg(int[] intArr)
        {
            int avg = 0;
            return avg;
        } 
        static int count(int[] intArr)
        {
            int count = 0;
            return count;
        }
        static int[] ascendingSort(int[] intArr)
        {
            int[] sortedArr = new int[intArr.Length];
            return sortedArr;
        }
        static int[] revers(int[] intArr)
        {
            int[] reversedArr = new int[intArr.Length];
            for (int i = 0; i < intArr.Length; i++)
            {
                reversedArr[i] = intArr[intArr.Length - 1 - i];
            }
            return reversedArr;
        }
        static void arrPrinter(int[] intArr)
        {
            Console.WriteLine("The series is: ");
            foreach (int num in intArr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            return;
        }
        static void singleNumPrinter(int num)
        {
            Console.WriteLine("The result is: ");
            Console.WriteLine(num + " ");
            return;
        }
    }
}

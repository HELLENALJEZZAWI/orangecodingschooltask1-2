﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orangecodingschooltask1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //*****************task1******************************
            //Console.WriteLine("Enter username:");

            //string userName = Console.ReadLine();

            //Console.WriteLine("Username is: " + userName);
            //*****************task2*****************************
            //double number1 = 34.5;
            //Console.WriteLine("Double " + number1);
            //String Name = "hellen";
            //Console.WriteLine("string " + Name);
            //char letter = 'Q';
            //Console.WriteLine("char " +letter);
            //bool check = true;
            //Console.WriteLine("boolean " + check);
            //int number2 = 12;
            //Console.WriteLine("int " + number2);
            //const string str = "hi hi";
            //Console.WriteLine("const " + str);
            //Console.ReadKey();
            // **************************task3*********************************
            //string[] cars = { "Volvo", "BMW", "Ford" };
            //foreach (string i in cars)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("the array length is " + cars.Length);
            // **************************task4*********************************

            //int[] arr = new int[10];

            //Console.WriteLine("Input 10 elements in the array:");

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write("element - {0} : ", i);
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.Write("Elements in array are: ");
            //foreach (int element in arr)
            //{
            //    Console.Write(element + " ");
            //
            //}
            // **************************task5*********************************
            //Console.WriteLine("Please enter first name:");
            //string userfname = Console.ReadLine();
            //Console.WriteLine("Please enter last name:");
            //string userlname = Console.ReadLine();
            //Console.WriteLine("Please enter year of birth:");
            //string age = Console.ReadLine();

            //Console.WriteLine("Your data is: " + userfname+" "+ userlname + " " +age);
            // **************************task6*********************************
            //int[] arr = new int[3];

            //Console.WriteLine("Input 3 elements in the array:");

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write("element - {0} : ", i);
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.Write("the sum is  ");

            //    Console.Write(arr.Sum());
            //***********************************file2****************************
            //***********************************problem1****************************

            //int x = 3;
            //int y = 5;
            //if (x < y)
            //{
            //    Console.WriteLine("x is smaller than y, x= :" + x);
            //}
            //***********************************problem2****************************
            //Console.WriteLine("Please enter a number:");
            //int number;


            //bool isNumber = int.TryParse(Console.ReadLine(), out number);

            //if (isNumber)
            //{
            //    if (number > 0)
            //    {
            //        Console.WriteLine("The sign is +");
            //    }
            //    else if (number < 0)
            //    {
            //        Console.WriteLine("The sign is -");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The number is 0");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid number.");
            //}
            //***********************************problem3****************************

            //Console.WriteLine("Enter the first number:");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter the second number:");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter the third number:");
            //int num3 = Convert.ToInt32(Console.ReadLine());

            //int temp;
            //if (num1 > num2)
            //{
            //    temp = num1;
            //    num1 = num2;
            //    num2 = temp;
            //}
            //if (num1 > num3)
            //{
            //    temp = num1;
            //    num1 = num3;
            //    num3 = temp;
            //}
            //if (num2 > num3)
            //{
            //    temp = num2;
            //    num2 = num3;
            //    num3 = temp;
            //}

            //Console.WriteLine("Numbers in ascending order:", num1, num2, num3);
            //Console.ReadKey();
            //***********************************problem4****************************
            //Console.WriteLine("Enter the first number:");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter the second number:");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter the third number:");
            //int num3 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter the fourth number:");
            //int num4 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter the fifth number:");
            //int num5 = Convert.ToInt32(Console.ReadLine());


            //int max = num1;


            //if (num2 > max)
            //{
            //    max = num2;
            //}


            //if (num3 > max)
            //{
            //    max = num3;
            //}

            //if (num4 > max)
            //{
            //    max = num4;
            //}


            //if (num5 > max)
            //{
            //    max = num5;
            //}


            //Console.WriteLine("The maximum number is: " + max);
            //***********************************problem5****************************
            //Console.WriteLine("Input kilometers per hour:");
            //double kmPerHour = Convert.ToDouble(Console.ReadLine());
            //double conversionFactor = 0.621371;
            //double milesPerHour = kmPerHour * conversionFactor;
            //Console.WriteLine($"{kmPerHour} kilometers per hour is equal to {milesPerHour} miles per hour.");

            //***********************************problem6****************************
            //Console.WriteLine("Input hours:");
            //int hours = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Input minutes:");
            //int minutes = Convert.ToInt32(Console.ReadLine());

            //int totalMinutes = hours * 60 + minutes;

            //Console.WriteLine($"Total: {totalMinutes} minutes.");
            //Console.ReadKey();
            //***********************************problem7****************************
            //Console.WriteLine("Input minutes:");
            //int totalMinutes = Convert.ToInt32(Console.ReadLine());


            //int hours = totalMinutes / 60;
            //int remainingMinutes = totalMinutes % 60;
            //Console.WriteLine($"{hours} Hours, {remainingMinutes} Minutes"); 
            //***********************************problem8****************************
            //    string[] sentences = new string[]
            //    {
            //    "This is a short sentence.",
            //    "Here's a longer sentence with more words.",
            //    "This sentence is much longer and contains additional content.",
            //    "Yet another example of a long sentence that might stretch over multiple lines.",
            //    "A very brief sentence."
            //    };


            //    int fixedLength = 40;

            //    foreach (string sentence in sentences)
            //    {
            //        Console.WriteLine($"{TruncateOrPad(sentence, fixedLength),-40}");
            //    }
            //}


            //static string TruncateOrPad(string value, int maxLength)
            //{
            //    if (value.Length <= maxLength)
            //    {
            //        return value.PadRight(maxLength);
            //    }
            //    else
            //    {
            //        return value.Substring(0, maxLength);
            //    }

            //***********************************problem9****************************

            //    Console.WriteLine("Enter a sentence:");
            //    string input = Console.ReadLine();

            //    string result = ReverseOddWords(input);

            //    Console.WriteLine($"Modified string: {result}");
            //}

            //static string ReverseOddWords(string input)
            //{
            //    // Split the input string into words
            //    string[] words = input.Split(' ');

            //    // Process each word
            //    for (int i = 0; i < words.Length; i++)
            //    {
            //        // Check if the length of the word is odd
            //        if (words[i].Length % 2 != 0)
            //        {
            //            // Reverse the word
            //            char[] charArray = words[i].ToCharArray();
            //            Array.Reverse(charArray);
            //            words[i] = new string(charArray);
            //        }
            //    }

            //    // Join the words back into a string with spaces
            //    string result = string.Join(" ", words);

            //    return result;




        }
    }
}

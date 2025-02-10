using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Wk4Ex3
{
    internal class Program
    {
        //method to make a string in reverse
        static void ReverseString(string input)
        {
            string reverse = "";
            int letter = 0;

            //counts how many letters are in a word
            foreach (char c in input)
            {
                letter++;
            }
            
            //letter -=1 to get the last index; loops until the index is = 0, counts down the index
            for (letter -= 1; letter >= 0; letter--)
            {
                reverse += input[letter];  //adds the letters backwards into the retValue        
            }
            Console.WriteLine(reverse);
        }

        //method to count how many vowels in a word
        static void CountVowels(string value)
        {
           int counter = 0;
            int vowelNum = 0;

            //makes the string all lowercase
            value = value.ToLower();

            //checks if counter is less than length of the word given, loops if true
            while (counter < value.Length)
            {
                //assigns the letter to x, puts the counter inside the index to check each letter
                char x = value[counter];

                //tests x against each case
                switch (x)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        {
                            vowelNum++; //adds 1 vowels
                            break;
                        }
                } //closes switch

                counter++; //adds 1 to counter
            } 
            Console.WriteLine(vowelNum);
        }

        //method to check if a word is a palindrome
        static void IsPalindrome(string value)
        {
            int letter = 0;
            string wordA = "";
            string wordB = "";
            string result = "";

            //counts the amount of letters in value
            foreach (char c in value)
            {
                letter++; //adds 1 for each letter there is
                wordA += c; //add the letters into wordA
            }

            //subtract 1 from letter because index starts at 0 (10 character word has 9 indexes)
            for (letter -= 1; letter >= 0; letter--)
            {
                wordB += value[letter]; //adds letters to wordB
            }
            if (wordA == wordB) //checks if wordA and Word B are the same
            {
                result = "a palindrome";
            }
            else
            {
                result = "not a palindrome";
            }
            Console.WriteLine($"{value} is {result}");
        }


        static void Main(string[] args)
        {
            //declarations

            //input
            int choice = 0; //the number the user inputs to choose an option
            string word = ""; //user input

            //output
            int pass = 0; //testing variable for loops

            //print prompt, receives input from user
            Console.WriteLine("Enter a word:");
            word = Console.ReadLine();

            while (pass == 0)
            {
                //tests if input is a number               
                Console.WriteLine("Choose an operation:\n1.Reverse Word\n2.Count Vowels\n3.Check if Palindrome");
                choice = Convert.ToInt32(Console.ReadLine());
                pass++; //adds one to pass, quitting loop

                if (choice > 3)
                {
                    Console.WriteLine("Please enter a vaild number.");
                }
                
            }
            
            switch (choice) //tests choice to see which method to use
            {
                case 1: //sends to ReverseString method; prints result
                    ReverseString(word);
                    break;
                case 2://sends to CountVowels method; prints result
                    CountVowels(word);
                    break;
                case 3://sends to IsPalindrome method; prints result
                    IsPalindrome(word);
                    break;
            }
        }
    }
}

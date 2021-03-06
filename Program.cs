﻿/*
Author: Cameron Spilker
Section: 2 
Group: 11
Date: 9/21/2016

Your task is to create a program that will help you familiarize yourself with various data structures available in the C# language.
You are the owner of a very successful hamburger restaurant. 
Your faithful customers line up every day and eat dozens of burgers. 
You are writing a program to track exactly how many hamburgers each customer eats.

Create a new C# Console Application. In the Main function, add a new variable of type Queue that contains items of type string.

Create a variable for a Queue with items of type string
This variable will represent your line of customers waiting outside.
Create a variable for a Dictionary with keys of type string and values of type int.
This variable will hold information about each customer
Put 100 customers into the queue
You can use the randomName function below to generate random people for your line
Add a random number of burgers to the total for each customer. Make sure there is a key in the dictionary for each customer before you try incrementing their total!
Print out each customer and their total burgers eaten.

This program uses a random name and number generator. It stores the name in a queue and the name with the number in the dictionary. 
It will then output the name with the number.
 */



using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Basics_Assignment
{
    class Program
    {
        //This is the random name class that puts 8 different names randomly
        public static Random random = new Random();

        public static string randomName()
        {
            string[] names = new string[8] { "Dan Morain", "Emily Bell", "Carol Roche", "Ann Rose", "John Miller", "Greg Anderson", "Arthur McKinney", "Joann Fisher" };
            int randomIndex = Convert.ToInt32(random.NextDouble() * 7);
            return names[randomIndex];
        }
        //This is the random number class that will produce a random number
        public static int randomNumberInRange()
        {
            return Convert.ToInt32(random.NextDouble() * 20);
        }
        static void Main(string[] args)
        {
            //The queue is created along with the dicitionary and variables
            Queue<string> myQueue = new Queue<string>();
            Dictionary<string, int> myDict = new Dictionary<string, int>();
            int iValue = 0;

            //While loop that will input the random names into the cue, it will do 100 customers
            while (myQueue.Count < 100)
            {
                myQueue.Enqueue(randomName());
                
            }

            //this foreach loop will put the random name and random number with it. The If Else statement will match a name with a number, if the same name comes up it will add a random number to itself
            foreach(string keyWord in myQueue)
            {
                iValue = randomNumberInRange();

                if (!myDict.ContainsKey(keyWord))
                {
                    myDict.Add(keyWord, 0);
                }
                
                    myDict[keyWord] += iValue;
 
            }

            //this for each loop will allow me to print the name with the number of burgers purchased with it. 
            //I had it print in white text with a red background for fun
            foreach(KeyValuePair<string, int> CustBurg in myDict)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Red;

                Console.WriteLine(CustBurg.Key + "\t\t" + CustBurg.Value);
            }
            
          //this allows the program to stay open until the user is finished
          Console.Read();




        }
    }
}

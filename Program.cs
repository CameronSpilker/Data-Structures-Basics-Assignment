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
        public static Random random = new Random();

        public static string randomName()
        {
            string[] names = new string[8] { "Dan Morain", "Emily Bell", "Carol Roche", "Ann Rose", "John Miller", "Greg Anderson", "Arthur McKinney", "Joann Fisher" };
            int randomIndex = Convert.ToInt32(random.NextDouble() * 7);
            return names[randomIndex];
        }

        public static int randomNumberInRange()
        {
            return Convert.ToInt32(random.NextDouble() * 20);
        }
        static void Main(string[] args)
        {
            Queue<string> myQueue = new Queue<string>();
            Dictionary<string, int> myD = new Dictionary<string, int>();
            int iValue = 0;

            while (myQueue.Count < 100)
            {
                myQueue.Enqueue(randomName());
                
            }

            foreach(string keyWord in myQueue)
            {
                iValue = randomNumberInRange();

                if (!myD.ContainsKey(keyWord))
                    myD.Add(keyWord, iValue);

                else myD[keyWord] += iValue;

 
            }


            foreach(KeyValuePair<string, int> CustBurg in myD)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Red;

                Console.WriteLine(CustBurg.Key + "\t\t" + CustBurg.Value);
            }
            

          Console.Read();




        }
    }
}

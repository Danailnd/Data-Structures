using System;

namespace CH_2_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialization 
            string sentence = "Write a C# Sharp Program to display the following patterns using the alphabet ";

            // Logic 

            string[] words = sentence.Split(" ");
            string longest = "";
            foreach (string word in words)
            {
                if (longest.Length < word.Length)
                {
                    longest = word;
                }
            }
            //Output
            Console.WriteLine("Longest word is: " + longest);
            Console.ReadLine();
        }
    }
}

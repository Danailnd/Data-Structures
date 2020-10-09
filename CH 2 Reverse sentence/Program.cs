using System;

namespace CH_2_Reverse_sentence
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Display the pattern like pyramid using the alphabet. ";
            string[] splittedsentence = sentence.Split(" ");
            string[] reversesentence = new string [splittedsentence.Length];
            int length = splittedsentence.Length - 1;
            foreach (string word in splittedsentence)
            {
                reversesentence[length] = word;
                length--;

            }
            string answer = "";
            foreach (string rword in reversesentence)
            {
                answer = answer + rword + " ";
            }
            Console.WriteLine(answer);


            Console.ReadLine();
             
        }
    }
}
/*Write a C# program to reverse the words of a sentence.Original String: 
 * “Display the pattern like pyramid using the alphabet.”
 * Reverse String: 
 * “alphabet. the using pyramid like pattern the Display”*/


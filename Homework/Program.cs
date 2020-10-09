using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;
using System.Collections.Generic;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Remove from comment to execute function

            //array();
            //stack();
            //queue();
            //list();
            
            Console.ReadLine();


        }
        static void array()
        {
            int[] array = new int[10];

            array[0] = 0;
            array[1] = 1;
            array[2] = 2;
            array[3] = 3;
            array[4] = 4;
            array[5] = 5;
            array[6] = 6;
            array[7] = 7;
            array[8] = 8;
            array[9] = 9;

            Console.WriteLine("Does it contain 6? ");
            Console.WriteLine(array.Contains(6));
            Console.WriteLine(string.Join(",", array));
        }
        static void stack()
        {

            Stack stk = new Stack();
            int counter = 0;
            while (counter<10)
            {
                stk.Push(counter);
                counter++;
            }
            Console.WriteLine("Does it contain 6? ");
            Console.WriteLine(stk.Contains(6));
            string a = "";
            while (stk.Count>0)
            {
                a = a + Convert.ToString(stk.Pop()) + ",";
            }
            Console.WriteLine(a);
         
          
        }
        static void queue()
        {
            Queue q = new Queue();
            int counter = 0;
            while (counter < 10)
            {
               q.Enqueue(counter);
                counter++;
            }
            Console.WriteLine("Does it contain 6? ");
            Console.WriteLine(q.Contains(6));
            string a = "";
            while (q.Count > 0)
            {
                a = a + Convert.ToString(q.Dequeue()) + ",";
            }
            Console.WriteLine(a);
        }
        static void list()
        {
            List<int> l = new List<int>();
            int i = 0;
            while (i<10)
            {
                l.Add(i);
                i++;
            }

            Console.WriteLine("Does it contain 6? ");
            Console.WriteLine(l.Contains(6));
            Console.WriteLine(string.Join(",", l));

        }
    }
}
/* Array 
Declare new array
Add 10 items into array
Check if specific item exists into the array
Display all items from the array

Stack – same functionality as with Array

Queues – same functionality as with Array

List<T> - same functionality as with Array*/


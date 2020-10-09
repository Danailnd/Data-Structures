﻿using System;
using System.Data;

namespace CH2_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Ivan", "Peter", "Maria", "Jane", "John" };
            DateTime[] bdays = new DateTime [names.Length ];
            bdays[0] = new DateTime(2000, 01, 02);
            bdays[1] = new DateTime(2000, 10, 02);
            bdays[2] = new DateTime(2002, 03, 03);
            bdays[3] = new DateTime(2000, 01, 05);
            bdays[4] = new DateTime(2001, 07, 10);

            Console.Write("Input Index: ");
            int index = int.Parse(Console.ReadLine());

            int day = bdays[index].Day;
            string word;
            if (day<=10)
            {
                word = "In the begining of ";
            }
            else if (day >= 20)
            {
                word = "At the end of ";
            }
            else
            {
                word = "In the middle of ";
            }
            //User Input
            string month = Month(bdays[index].Month);
            Console.WriteLine(bdays[index].Month);
            Console.WriteLine(names[index] + " is born in " + word + month);
        }
        static string Month(int month)
        {
            if (month == 1) { return "January"; }
            if (month == 2) { return "February"; }
            if (month == 3) { return "March"; }
            if (month == 4) { return "April"; }
            if (month == 5) { return "May"; }
            if (month == 6) { return "June"; }
            if (month == 7) { return "July"; }
            if (month == 8) { return "August"; }
            if (month == 9) { return "September"; }
            if (month == 10) { return "October"; }
            if (month == 11) { return "November"; }
            if (month == 12) { return "December"; }
            return "Unknown";
        }

    }
}

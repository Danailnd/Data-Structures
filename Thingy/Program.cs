using System;

namespace Thingy
{
    

    


    class Program
    {
        static void Main(string[] args)
        {
            string[] names = {"Bob", "Jill", "Garry", "Lucille", "Danail" };

            DateTime[] bdays = new DateTime[names.Length];
            bdays[0] = new DateTime(2000, 01, 02);
            bdays[1] = new DateTime(2002, 10, 15);
            bdays[2] = new DateTime(2000, 09, 02);
            bdays[3] = new DateTime(2000, 9, 13);
            bdays[4] = new DateTime(2000, 10, 16);


        }
    }
}

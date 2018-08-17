using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAStringDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            string fName = "Keenan";
            string mName = "Andre";
            string lName = "Carroll";
            Console.WriteLine(fName + " " + mName + " " + lName);
            fName = fName.ToUpper();
            Console.WriteLine(fName);

            StringBuilder pg = new StringBuilder("This is my first string builder.");
            pg.Append("Now I can continue to add to my string without loosing performance.");
            pg.Append("This is my last sentence.");
            pg.Append("Ok one more, Have a good day!");
            Console.WriteLine(pg);
            Console.Read();
        }
    }
}

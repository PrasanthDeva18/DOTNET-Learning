using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // structure of type declaration in c#
            // type variablename;
            // int, double, string, char, bool; 
            // in c# name must be identified with unique, these unique names are called identifiers

            int a = 10;
            bool isValue = true;
            char letter = 'z';
            string b = "Welcome to c# programming";
            double temp = 18.2;

            const double pi = 3.14; // used for constant value to store and unchangeable

            Console.WriteLine(a);
            Console.WriteLine(isValue);
            Console.WriteLine(letter);
            Console.WriteLine(b);
            Console.WriteLine(temp);
            Console.WriteLine(pi);


            //Multi Variables in sametype
            int x = 5, y = 6, z = 50;

            int a1, b1, c;

            a1 = b1 = c = 50;

            Console.WriteLine(x + y + z);
            Console.WriteLine(a1 + b1 + c);

            // const a22;
            // a22 = 10;

            const int a22 = 10;

            Console.WriteLine(a22);

            string a21 = "Hello ";

            string a23 = "World";

            Console.WriteLine(a21 + a23);

            string aa_out = a21 + a23;

            Console.WriteLine(aa_out);
        }
    }

}
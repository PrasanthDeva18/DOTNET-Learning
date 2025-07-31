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

        }
    }

}
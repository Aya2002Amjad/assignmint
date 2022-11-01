using System;

namespace Assignment1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first string: ");
            string string1=Console.ReadLine();
            Console.WriteLine("Please enter the second string: ");
            string string2 = Console.ReadLine();
            int size = string1.Length + string2.Length;
            char [] newstring=new char[size] ;
            
            if (string1.Length == string2.Length)
            {
                int index = 0;
                for (int i = 0; i < string1.Length; i++)
                {
                    newstring[index] = string1[i];
                    index += 2;
                }
                   index = 1;
                for (int i = 0; i < string2.Length; i++)
                {
                    newstring[index] = string2[i];
                    index += 2;
                }
                Console.WriteLine(newstring);
            }
            else
                Console.WriteLine(newstring);




        }
    }
}

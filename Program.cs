using System;

namespace Assignment1
{

    class Program
    {


        static void Main(string[] args)
        {

            int result = 0, result1 = 0;
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Please enter the first number:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the second number:");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please choose the operation from the following (+,-,*,/):");
                char symbole = Convert.ToChar(Console.ReadLine());
                

                switch (symbole)
                {
                    case '*':
                        {
                            result = multiplication(num1, num2);
                            break;
                        }
                    case '/':
                        {
                            result = Division(num1, num2);
                            break;
                        }
                    case '+':
                        {
                            result = Addition(num1, num2);
                            break;
                        }
                    case '-':
                        {
                            result = subtraction(num1, num2);
                            break;
                        }

                    default:
                        Console.WriteLine("Wrong symbol!");
                        break;
                }

                Console.WriteLine("The result = {0} ", result);
                if (i == 0)
                {
                     result1 = result;
                }
            }
            Console.WriteLine("The result is the same for both operations? ");
            Compar(result1, result);
        }
        
        public static int subtraction(int num1, int num2)
        {
          int  result = num1 - num2;
            return result;
        }
        public static int multiplication(int num1, int num2)
        {
            int result = num1*num2;
            return result;
        }
        public static int Division(int num1, int num2)
        {
            int result = num1/ num2;
            return result;
        }
        public static int Addition(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }
       public static void Compar(int result1,int result)
        {
            if (result1 == result)
                Console.WriteLine("True");
            else Console.WriteLine("False");
        }
    }
}

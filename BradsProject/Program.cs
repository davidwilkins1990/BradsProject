using System.Data;

namespace BradsProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //single line comment
            /*
             
             */
            Console.WriteLine("Hello, Brad!");
            //Run();
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);

            }
            string again = "y";
            while (again == "y") 
            {

                Run2();
                Console.WriteLine("again? y/n");
                again= Console.ReadLine();
            }
            if (again == "n")
            {
                Console.WriteLine("david likes donkey dick");
            }
            Console.ReadLine();

        }



        static void Run()
        {
            Console.WriteLine("poontang boomerang");
            Console.WriteLine('a');
            char example = 'a';
            string words = "david is a doo doo head";

            Console.WriteLine(words);

            Console.WriteLine("pick a number");
            int number1 = 5;
            string input;
            input = Console.ReadLine();
            Console.WriteLine("pick another number");
            string input2 = Console.ReadLine();
            int number2 = Convert.ToInt32(input);
            int number3 = Convert.ToInt32(input2);
            Console.WriteLine(number1 + number2 + number3);

        }// end of Run

        static void Run2()
        {
            Console.WriteLine("what is the length");
            int num1 = GetNum();
            Console.WriteLine("what is the width");
            int num2 = GetNum();
            int result = Multiply(num1, num2);
            Console.WriteLine("Length " + num1 + " x Width " + num2 + " = " + result);

            //Console.WriteLine("again? y/n");
            //string again = Console.ReadLine();
            //if (again=="y")
            //{
            //    Run2();

            //}





        } //endof run2 

        static int GetNum()
        {
            int num;
            string input = Console.ReadLine();

            if (input != null && input != "")
            {
                num = Convert.ToInt32(input);

            }
            else
            {
                num = 10;

            }
            return num;


        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }































    }
}
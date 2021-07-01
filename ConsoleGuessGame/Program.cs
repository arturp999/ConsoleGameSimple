using System;

namespace ConsoleGuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The most basic game ever:");
            Console.WriteLine("Whats the number?" );
            int inputNumber =  Convert.ToInt32(Console.ReadLine());

            int teste = generateRandom();
            //Console.WriteLine(teste);

            do
            {
              Console.WriteLine("Wrong number, try again");
              inputNumber = Convert.ToInt32(Console.ReadLine());

                if (inputNumber > teste)
                {
                    Console.WriteLine("The number is lower than " + inputNumber + ", try again \n");
                }
                if (inputNumber < teste)
                {
                    Console.WriteLine("The number is higher than " + inputNumber + ", try again\n");
                }
                if (inputNumber == teste)
                {
                    Console.WriteLine("\n YOU WIN");
                }
            } while (inputNumber != teste);
        }

        public static int generateRandom()
        {
            var winNumber = new Random();
            var x = winNumber.Next(0, 100);
            return x;
        }
    }
}

using System;

namespace PowersTable2
{
    class Program
    {
        public static int SquaredNumber(int num)
        {
            num = (int)Math.Pow(num, 2);
            return num;
        }
        public static int CubedNumber(int num)
        {
            num = (int)Math.Pow(num, 3);
            return num;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Learn your squars and cubes!");

            int number = 1; int square = 1; int cube = 1;

            bool lContinue = true;
            while (lContinue)
            {
                Console.WriteLine("Please enter an integer.");
                int num; 
                while (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Invalid Number,try again ");
                    Console.Write("Enter integer: \n");
                }

                Console.WriteLine("Number  Squared  Cubed");
                for (int i = 0; i <= num; i++)
                {
                    number = i;
                    square = SquaredNumber(i);
                    cube = CubedNumber(i);
                    Console.WriteLine($"{number} \t {square}\t{cube}");
                }

                Console.WriteLine("Would you like to continue?");
                string input = Console.ReadLine();
                if (input == "yes")
                {
                    lContinue = true;
                }
                else
                {
                    lContinue = false;
                    Console.WriteLine("Come again!");
                }
            }
        }
        
    }
}

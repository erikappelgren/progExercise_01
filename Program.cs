using System;

namespace progExercise_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Erik Appelgren";
            string street = "Kunskapslänken 88";
            string zipcode = "583 28";
            string topInput;
            int topNumber;
            string leftInput;
            int leftNumber;
                Console.Write("Hur långt från toppen: ");
                    topInput = Console.ReadLine();
                    topNumber = Convert.ToInt32(topInput);
            

                Console.Write("Hur långt från vänster: ");
                    leftInput = Console.ReadLine();
                    leftNumber = Convert.ToInt32(leftInput);

            

            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();


            Console.SetCursorPosition(leftNumber, topNumber);
            Console.WriteLine(name);
            Console.SetCursorPosition(leftNumber, topNumber + 1);
            Console.WriteLine(street);
            Console.SetCursorPosition(leftNumber, topNumber + 2);
            Console.WriteLine(zipcode);
          

            
            Console.ReadKey();
        }
    }
}

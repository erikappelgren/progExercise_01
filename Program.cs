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

            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            
                Console.WriteLine(name);
                Console.WriteLine(street);
                Console.WriteLine(zipcode);
            
            Console.ReadKey();
        }
    }
}

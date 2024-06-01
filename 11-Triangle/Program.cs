namespace HelloWorld {
    internal class Program
    {
        private static void Main(string[] args)
        {
           // Give space at the start
            Console.WriteLine();
            // Get the input from user

            // Angel 1
            Console.Write("Enter An Angle Number 1 : ");
            int angel1, angel2, angel3;
            bool success = int.TryParse(Console.ReadLine(), out angel1);
            Console.WriteLine();
            while (!success || angel1 < 0 || angel1 > 180)
            {
                Console.Write("Please Enter Just An Angel (0-180) : ");
                success = int.TryParse(Console.ReadLine(), out angel1);
            }

            // Angel 2
            Console.Write("Enter An Angle Number 2 : ");
            success = int.TryParse(Console.ReadLine(), out angel2);
            Console.WriteLine();
            while (!success || angel2 < 0 || angel2 > 180)
            {
                Console.Write("Please Enter Just An Angel (0-180) : ");
                success = int.TryParse(Console.ReadLine(), out angel2);
            }

            // Angel 3
            Console.Write("Enter An Angle Number 3 : ");
            success = int.TryParse(Console.ReadLine(), out angel3);
            Console.WriteLine();
            while (!success || angel3 < 0 || angel3 > 180)
            {
                Console.Write("Please Enter Just An Angel (0-180) : ");
                success = int.TryParse(Console.ReadLine(), out angel3);
            }
            // calculations
            Console.WriteLine(angel1 + angel2 + angel3 == 180 ? "Valid Triangle" : "Invalid Triangle");
            Console.WriteLine();
        }
    }
}

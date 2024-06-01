namespace HelloWorld {
    internal class Program
    {
        private static void Main(string[] args)
        {
           // Give space at the start
            Console.WriteLine();
            // Get the input from user
            Console.Write("Enter A Number : ");
            int num;
            bool success = int.TryParse(Console.ReadLine(), out num);
            Console.WriteLine();
            // Conditions
            while (!success || num < 0)
            {
                Console.Write("Please Enter Just A Positive Number : ");
                success = int.TryParse(Console.ReadLine(), out num);
            }
            // calculations
            // evens
            Console.WriteLine("Evens Are : ");
            Console.WriteLine();
            for (int i = 0; i <= num ; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine();

            // odds
            Console.WriteLine("Odds Are : ");
            Console.WriteLine();
            for (int i = 0; i <= num ; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine();
        }
    }
}

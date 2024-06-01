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
            for (int i = 1; i <= num; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) 
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else 
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine();
        }
    }
}

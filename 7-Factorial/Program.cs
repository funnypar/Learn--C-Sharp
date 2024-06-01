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
            // Conditions
            while (!success || num < 0)
            {
                Console.Write("Please Enter Just A Positive Number : ");
                success = int.TryParse(Console.ReadLine(), out num);
            }
            // calculations
            if (num == 0 || num == 1) 
            {
                Console.WriteLine();
                Console.WriteLine("The Factorial is : 1");
                Console.WriteLine();
            }
            else 
            {
                int result = 1;
                for (int i = num; i > 0; i-- )
                {
                    result *= i;
                }
                Console.WriteLine();
                Console.WriteLine("The Factorial is : " + result);
                Console.WriteLine();
            }
        }
    }
}

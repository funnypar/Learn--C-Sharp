namespace HelloWorld {
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Give space at the start
            Console.WriteLine();
            // Get the input from user
            Console.Write("Enter thr time : ");
            string userInput = Console.ReadLine();
            int time = Convert.ToInt32(userInput);
            // Conditions
            if (time < 0 || time > 24)
            {
                Console.WriteLine("Invalid Time");
            }
            else if (time >= 0 && time <= 5) 
            {
                Console.WriteLine("Dawn");
            }
            else if (time >= 6 && time <= 11) 
            {
                Console.WriteLine("Morning");
            }
            else if (time >= 12 && time <= 17) 
            {
                Console.WriteLine("Afternoon");
            }
            else 
            {
                Console.WriteLine("Evening");
            }
            Console.WriteLine();
        }
    }
}

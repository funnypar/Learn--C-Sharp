namespace HelloWorld {
    internal class Program
    {
        private static void Main(string[] args)
        {
           // Give space at the start
            Console.WriteLine();
            // Get the input from user
            Console.Write("Enter Your Age : ");
            int age;
            bool success = int.TryParse(Console.ReadLine(), out age);
            Console.WriteLine();
            // Conditions
            while (!success || age < 1 || age > 125)
            {
                Console.Write("Please Enter Just A Positive Number : ");
                success = int.TryParse(Console.ReadLine(), out age);
            }
            // calculations
            Console.WriteLine("You Are Living " + age * 12 * 31 + " Days 🥳");
            Console.WriteLine();
        }
    }
}

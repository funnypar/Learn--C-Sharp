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
            // Conditions
            while (!success)
            {
                Console.WriteLine();
                Console.Write("Please Enter A Number : ");
                success = int.TryParse(Console.ReadLine(), out age);
            }
            while (age < 1 || age > 125)
            {
                Console.WriteLine();
                Console.Write("Please Enter A Valid Age : ");
                success = int.TryParse(Console.ReadLine(), out age);
            }
            if (age > 0 && age <= 12) 
            {
                Console.WriteLine();
                Console.WriteLine("You Are A Child 😽");
                Console.WriteLine();

            }
            else if (age >= 13 && age <= 18)
            {
                Console.WriteLine();
                Console.WriteLine("You Are A Teenager 🙈");
                Console.WriteLine();
            }
            else if (age >= 19 && age <= 59)
            {
                Console.WriteLine();
                Console.WriteLine("You Are An Adult 🤠");
                Console.WriteLine();
            }
            else 
            {
                Console.WriteLine();
                Console.WriteLine("You Are A Senior Adult 🧐");
                Console.WriteLine();
            }
        }
    }
}

namespace HelloWorld {
    internal class Program
    {
        private static void Main(string[] args)
        {
           // Give space at the start
            Console.WriteLine();
            // Get the input from user
            Console.Write("Password : ");
            string pass = Console.ReadLine();
            Console.WriteLine();

            while (string.IsNullOrEmpty(pass) || pass.StartsWith(" "))
            {
                Console.Write("Please Start Password With Words : ");
                pass = Console.ReadLine();
            }

            pass = pass.Trim().Replace(" ", "");

            // Get password again

            Console.Write("Enter Password Again : ");
            string pass2 = Console.ReadLine();
            Console.WriteLine();
            while (string.IsNullOrEmpty(pass2))
            {
                Console.Write("Please Start Password With Words : ");
                pass2 = Console.ReadLine();
            }

            pass2 = pass2.Trim().Replace(" ", "");

            // conditions
            Console.WriteLine(pass == pass2 ? "Passwords Match 🤌" : "Passwords Do Not Match 🤏");
            Console.WriteLine();
        }
    }
}

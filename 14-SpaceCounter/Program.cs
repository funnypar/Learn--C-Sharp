namespace HelloWorld {
    internal class Program
    {
        private static void Main(string[] args)
        {
           // Start
            Console.WriteLine();
            Console.WriteLine("Welcome To Text Informations 🧐 ");
            Console.WriteLine();
            Console.WriteLine("Enter Your Text : ");
            Console.WriteLine();
            // User input
            Console.Write("--> ");
            string userInput = Console.ReadLine().Trim().Replace(" ", "");
            // app
            TextLong(userInput);
            SpaceCounter(userInput);
            // end
            Console.WriteLine();
        }

        static void TextLong(string userInput)
        {
            Console.WriteLine();
            Console.WriteLine($"The Text Has {userInput.Length} Characters !");
        }
        static void SpaceCounter(string userInput)
        {
            int counter = 0;
            foreach(char word in userInput)
            {
                if(char.IsWhiteSpace(word))
                {
                    counter++;
                }
            };
            Console.WriteLine();
            Console.WriteLine($"The Text Has {counter} Spaces !");
        }
    }
}
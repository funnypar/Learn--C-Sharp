namespace HelloWorld {
    internal class Program
    {
        private static void Main(string[] args)
        {
           // Give space at the start
            Console.WriteLine();
            // Get the input from user
            Console.Write("Enter The Number Of Items : ");
            bool success = int.TryParse(Console.ReadLine(), out int item);
            Console.WriteLine();

            while (!success || item <= 0)
            {
                Console.Write("Please Enter Positve Number : ");
                Console.WriteLine();
                success = int.TryParse(Console.ReadLine(), out item);
            }

            // Create an array

            string[] list = new string[item];


            for (int i = 0; i < list.Length; i++)
            {
                Console.Write("Enter The Item : ");
                list[i] = Console.ReadLine().Trim();
            }

            Console.WriteLine();
            Console.WriteLine("Your List's Item Are : ");
            Console.WriteLine();

            int j = 1;
            foreach(string i in list)
            {
                Console.WriteLine($"    {j} --> {i}");
                j++;
            }
            
            Console.WriteLine();

            // search part

            Console.Write("Do You Want To Search In There (Yes Or No): ");
            string answer = Console.ReadLine().Trim().ToLower();
            Console.WriteLine();


            while (!string.IsNullOrEmpty(answer) && answer != "yes" && answer != "y" && answer != "no" && answer != "n") 
            {
                Console.Write("Please Enter Correct Value : ");
                answer = Console.ReadLine().Trim().ToLower();
            }

            switch(answer)
            {
                case "yes":
                case "y":
                    Console.Write("Search For : ");
                    string search = Console.ReadLine().Trim().ToLower();
                    int found = Array.IndexOf(list, search);
                    if(found >= 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"{found + 1} --> {list[found]}");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Not Found !");
                        Console.WriteLine();
                    }
                    break;
                default :
                    break;
            }

        }
    }
}

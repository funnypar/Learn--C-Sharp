namespace HelloWorld {
    internal class Program
    {
        private static void Main(string[] args)
        {
           // Give space at the start
            Console.WriteLine();
            string userInput = "";
            Console.WriteLine();
            Console.WriteLine("Welcome To Your ToDo List 🤠 ");
            Console.WriteLine();
            Console.WriteLine("Enter Your First Item : ");
            Console.WriteLine();
            // Create List
            List<string> list = new List<string>();
            Console.Write("--> ");
            list.Add(Console.ReadLine().Trim());
            Console.WriteLine();
            // app
            do 
            {
                Console.WriteLine("Choose Your New Action : ");
                Console.WriteLine("Enter Item --> \"i\" or \"insert\"");
                Console.WriteLine("Update Item --> \"u\" or \"update\"");
                Console.WriteLine("Delete Item --> \"d\" or \"delete\"");
                Console.WriteLine("Find Item --> \"f\" or \"find\"");
                Console.WriteLine("Show List --> \"l\" or \"list\"");
                Console.WriteLine("End --> \"e\" or \"end\"");
                Console.WriteLine();
                Console.Write("--> ");
                userInput = Console.ReadLine().Trim().ToLower();
                Console.WriteLine();
                // calculation
                switch(userInput)
                {
                    case "i":
                    case "insert":
                        Console.Write("Enter Your Item : ");
                        // add to list
                        list.Add(Console.ReadLine());
                        Console.WriteLine();
                        // message
                        Console.Write("Item Has Imported !");
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    case "u":
                    case "update":
                        Console.Write("Select The Item By The Number : ");
                        // select item
                        bool success = int.TryParse(Console.ReadLine(), out int item);
                        while(!success || item < 1 || item > list.Count)
                        {
                            Console.Write("Please Select Correct Item : ");
                            success = int.TryParse(Console.ReadLine(), out item);
                        }
                        Console.Write("Insert New Value : ");
                        // update
                        list[item - 1] = Console.ReadLine().Trim();
                        Console.WriteLine();
                        // message
                        Console.WriteLine("Item Has Updated !");
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    case "d":
                    case "delete":
                        Console.Write("Select The Item By The Number : ");
                        success = int.TryParse(Console.ReadLine(), out item);
                        while(!success || item < 1 || item > list.Count)
                        {
                            Console.Write("Please Select Correct Item : ");
                            success = int.TryParse(Console.ReadLine(), out item);
                        }
                        // delete
                        list.RemoveAt(item -1);
                        Console.WriteLine();
                        // meassage
                        Console.WriteLine("Item Has Deleted !");
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    case "f":
                    case "find":
                        Console.Write("Search For : ");
                        string search = Console.ReadLine().Trim().ToLower();
                        int found = list.IndexOf(search);
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
                        };
                        break;
                    case "l":
                    case "list":
                        Console.WriteLine("Your List : ");
                        Console.WriteLine();
                        int j = 1;
                        foreach (var i in list)
                        {
                            Thread.Sleep(200);
                            Console.WriteLine($"{j} --> {i}");
                            j++;
                        }
                        Console.WriteLine();
                    break;
                }
            } while (userInput != "e" && userInput != "end");
        }
    }
}
namespace HelloWorld {
    internal class Program
    {
        private static void Main(string[] args)
        {
           // Give space at the start
            Console.WriteLine();
            // Get the input from user
            Console.WriteLine("Select One Of The Items : ");
            Console.WriteLine("1.Buy");
            Console.WriteLine("2.Sell");
            Console.WriteLine("3.Swap");
            Console.WriteLine();
            Console.Write("Your Answer Is : ");
            int answer = Convert.ToInt32(Console.ReadLine());
            
            // Conditions
            while (answer > 3 || answer < 1)
            {
                Console.Write("Select Beetwen 1-3 : ");
                answer = Convert.ToInt32(Console.ReadLine());
            }
            do 
            {
                switch(answer)
                    {
                    case 1 :
                        Console.WriteLine("You Have Selected --> Buy");
                        Console.WriteLine();
                        Console.Write("You Can Stop It By \"0\" Or Your New Answer Is : ");
                        answer = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2 :
                        Console.WriteLine("You Have Selected --> Sell");
                        Console.WriteLine();
                        Console.Write("You Can Stop It By \"0\" Or Your New Answer Is : ");
                        answer = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3 :
                        Console.WriteLine("You Have Selected --> Swap");
                        Console.WriteLine();
                        Console.Write("You Can Stop It By \"0\" Or Your New Answer Is : ");
                        answer = Convert.ToInt32(Console.ReadLine());
                        break;
                    default :
                        Console.Write("Select Beetwen 1-3 : ");
                        answer = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
            } while (answer != 0);  
        }
    }
}

namespace HelloWorld {
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Give space at the start
            Console.WriteLine();
            // Get the input from user
            Console.Write("Enter The Number Of A Day : ");
            int day = Convert.ToInt32(Console.ReadLine());
            // Conditions
            switch (day)
            {
                case 1 :
                    Console.WriteLine("Today Is Monday");
                    break;
                case 2 :
                    Console.WriteLine("Today Is Sunday");
                    break;
                case 3 :
                    Console.WriteLine("Today Is Tuesday");
                    break;
                case 4 :
                    Console.WriteLine("Today Is Wednesday");
                    break;
                case 5 :
                    Console.WriteLine("Today Is Thursday");
                    break;
                case 6 : 
                    Console.WriteLine("Today Is Friday");
                    break;
                case 7 :
                    Console.WriteLine("Today Is Saturday");
                    break;
                default:
                    Console.WriteLine("There are only 7 days in a week :) ");
                    break;
            }
            Console.WriteLine();
        }
    }
}

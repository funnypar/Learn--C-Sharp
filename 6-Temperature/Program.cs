namespace HelloWorld {
    internal class Program
    {
        private static void Main(string[] args)
        {
           // Give space at the start
            Console.WriteLine();
            // Get the input from user
            Console.Write("Enter Your Temperature's Unit (F Or C) : ");
            string unit = Console.ReadLine().ToLower();
            // Conditions
            while (unit != "f" && unit != "c")
            {
                Console.WriteLine();
                Console.Write("Please Enter (f or c) : ");
                unit = Console.ReadLine().ToLower();
            }
            // Get Temp
            Console.Write("Enter Your Temperature : ");
            float temp;
            bool success = float.TryParse(Console.ReadLine(), out temp);

            while (!success)
            {
                Console.Write("Please Enter Just A Number : ");
                success = float.TryParse(Console.ReadLine(), out temp);
            }

            // Temp conditions
            if (unit == "f") 
            {
                Console.WriteLine();
                Console.WriteLine("The Temperature Is " + temp + "F " + "and " + string.Format("{0:0.00}",(temp-32F)*(5F/9F)) + "C");
                Console.WriteLine();
            }
            else 
            {
                Console.WriteLine();
                Console.WriteLine("The Temperature Is " + temp + "C " + "and " + string.Format("{0:0.00}",(temp*(9F/5F))+32) + "F");
                Console.WriteLine();
            }
        }
    }
}

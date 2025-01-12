internal class Program
{
    private static void Main(string[] args)
    {
        // Practice 1 : Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console.

        /*
        int count = 0;
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0)
                count++;
        }
        Console.WriteLine($"There are {count} numbers!");
        Console.ReadLine();
        */

        // Practice 2 : Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.

        /*
        bool input = true;
        double sum = 0;

        do
        {
            Console.Write("Enter a number or say \"ok\" to calculate the sum : ");
            var userInput = Console.ReadLine();
            
            if(userInput == "ok")
            {
                Console.WriteLine($"Sum : {sum}");
                input = false;
            } else
            {
                sum += Convert.ToDouble(userInput);
            }
        } while (input);
        */

        //Practice 3 : Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

        /*
        var fact = 1;
        Console.Write("Enter a number to calculate the factorial : ");
        var userInput = Convert.ToInt32(Console.ReadLine());

        if (userInput == 0)
            Console.WriteLine("The factorial is : 1");


        while (userInput != 1)
        {
            fact *= userInput;
            userInput--;
        }

        Console.WriteLine($"The factorial is : {fact}");

        */

        //Practice 4 : Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. If the user guesses the number, display “You won"; otherwise, display “You lost". (To make sure the program is behaving correctly, you can display the secret number on the console first.)

        /*
        var random = new Random();
        int answer = random.Next(10);
        int chances = 4;

        while (chances != 0)
        {
            Console.Write("What is your guess : ");
            int userAnswer = Convert.ToInt32(Console.ReadLine());
            if (userAnswer == answer)
            {
                Console.WriteLine("You Won :)");
                break;
            }
            if (chances > 1)
                Console.WriteLine(@"You Lost :( 
Try again :)");       
            chances--;
        }
        if (chances == 0)
            Console.WriteLine("Game Over :(");

        */

        //Prcatice 5 : Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the numbers and display it on the console. For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
        Console.WriteLine("Enter a series of numbers : ");
        var userInput = Console.ReadLine().Split(',');
        int answer = Convert.ToInt32(userInput[0]);

        foreach(var num in userInput)
        {
            if (Convert.ToInt32(num) > answer)
                answer = Convert.ToInt32(num);
        }

        Console.WriteLine($"The Max is {answer}");
    }
}
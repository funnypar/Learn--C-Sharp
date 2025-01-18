using System.Linq;
internal class Program
{
    public static void Practice1()
    {
        Console.Write("Please enter some numbers with hyphens: ");
        var valid = false;
        var answer = true;
        var userInput = Console.ReadLine();
        while(!valid)
        {
            if (String.IsNullOrEmpty(userInput) || !userInput.Contains('-'))
            {
                Console.WriteLine("Please enter valid input like (1-2-3) : ");
                userInput = Console.ReadLine();
            }
            else valid = true;
        }

        var textArr = userInput?.Split('-');

        for(int i = 0; i<textArr?.Length ;i++)
        {
            if(i != textArr.Length - 1)
            {
                if (Math.Abs(Convert.ToInt32(textArr[i]) - Convert.ToInt32(textArr[i + 1])) != 1)
                    answer = false;
            }
        }

        Console.WriteLine($"{((answer) ? "Consecutive":"Not Consecutive")}");
    }

    public static void Practice2()
    {
        Console.Write("Please enter some numbers with hyphens: ");
        var valid = false;
        var answer = true;
        var userInput = Console.ReadLine();
        while (!valid)
        {
            if (String.IsNullOrEmpty(userInput) || !userInput.Contains('-'))
            {
                Console.WriteLine("Please enter valid input like (1-2-3) : ");
                userInput = Console.ReadLine();
            }
            else valid = true;
        }

        var textArr = userInput?.Split('-');
        var numbers = new int[textArr.Length];

        for (int i = 0; i < textArr?.Length; i++)
        {
            numbers[i] = Convert.ToInt32(textArr[i].Trim());
        }

        answer = Math.Abs(numbers.Distinct().ToArray().Length - numbers.Length) != 0 ? true:false;

        Console.WriteLine($"{((answer) ? "Duplicate" : "Not Duplicate")}");
    }

    public static void Practice3()
    {
        Console.Write("Please enter a clock time like (19:00) -->  ");
        var valid = false;
        var userInput = Console.ReadLine();
        while (!valid)
        {
            if (String.IsNullOrEmpty(userInput) || !userInput.Contains(':'))
            {
                Console.WriteLine("Please enter valid input like (01:30) -->  ");
                userInput = Console.ReadLine();
            }
            else valid = true;
        }

        var timeArr = userInput?.Split(":");
        Console.WriteLine($"{((timeArr[0][0] >= 0 && timeArr[0][1] < 5 && timeArr[1][0] < 6) ? "Ok" : "Invalid Time")}");
    }

    public static void Practice4()
    {
        Console.Write("Please enter a text -->  ");
        var userInput = Console.ReadLine();
        var timeArr = userInput?.Split(' ');
        var strings = new string[timeArr.Length];
        for(int i= 0; i<timeArr.Length; i++)
        {
            timeArr[i] = timeArr[i].ToLower();
            var first = char.ToUpper(timeArr[i][0]);
            var more = timeArr[i].Substring(1);
            strings[i] = first + more;
        }
        Console.WriteLine($"{String.Join("",strings)}");
    }

    public static void Practice5()
    {
        Console.Write("Please enter a text -->  ");
        var userInput = Console.ReadLine();
        var counter = 0;
        var valWords = new char[5] {'a','e','o','u','i'};
        foreach(var word in userInput)
        {

            if(valWords.Contains(word))
                counter++;
        }
        Console.WriteLine($"This text has {counter} vowels!");
    }
    private static void Main(string[] args)
    {
        // Practice 1 : Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".

        //Practice1();



        //Practice 2 : Write a program and ask the user to enter a few numbers separated by a hyphen. If the user simply presses Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.

        //Practice2();

        // Practice 3 : Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display "Invalid Time". If the user doesn't provide any values, consider it as invalid time.

        //Practice3();

        //Practice 4 : Write a program and ask the user to enter a few words separated by a space. Use the words to create a variable name with PascalCase. For example, if the user types: "number of students", display "NumberOfStudents". Make sure that the program is not dependent on the input. So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".

        //Practice4();

        //Prctice 5 : Write a program and ask the user to enter an English word. Count the number of vowels (a, e, o, u, i) in the word. So, if the user enters "inadequate", the program should display 6 on the console.

        Practice5();
    }
}
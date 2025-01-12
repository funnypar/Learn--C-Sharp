using System.Collections.Generic;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        /* Prcatice 1 : When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

            If no one likes your post, it doesn't display anything.
            If only one person likes your post, it displays: [Friend's Name] likes your post.
            If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
            If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
            Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.

        */


        //var enter = false;
        //var users = new List<string>();

        //while (!enter)
        //{
        //    Console.WriteLine("Enter a user who likes your post : (Or just press Enter to see the result)");
        //    Console.Write("--> ");
        //    var userInput = Console.ReadLine();

        //    if (String.IsNullOrEmpty(userInput))
        //    {
        //        enter = true;
        //        break;
        //    }
        //    else
        //    {
        //        users.Add(userInput);
        //    }
        //}

        ////if (users.Count == 0)
        ////{
        ////    Console.WriteLine("\nNobody likes your post :(");
        ////}
        ////else if (users.Count == 1)
        ////{
        ////    Console.WriteLine($"\n{users[0]} likes your post :)");
        ////}
        ////else if (users.Count == 2)
        ////{
        ////    Console.WriteLine($"\n{users[0]} and {users[1]} likes your post :)");
        ////}
        ////else
        ////{
        ////    Console.WriteLine($"\n{users[0]} and {users[1]} and {users.Count} others like your post :)");
        ////}

        //switch (users.Count) {
        //    case 0: Console.WriteLine("\nNobody likes your post :("); break;
        //    case 1: Console.WriteLine($"\n{users[0]} likes your post :)"); break;
        //    case 2: Console.WriteLine($"\n{users[0]} and {users[1]} likes your post :)");break;
        //    default: Console.WriteLine($"\n{users[0]} and {users[1]} and {users.Count - 2} others like your post :)"); break;
        //}



        // ----------------------------------------------------------------------------------------------------------------------------------------------------------------------



        // Practice 2 : Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. Display the reversed name on the console.




        //if (users == null || !users.Any())
        //{
        //    Console.WriteLine("The list is null or empty.");
        //}
        //else
        //{
        //    var newUsers = new List<string>(); 
        //    newUsers.AddRange(users); 
        //    newUsers.Reverse();

        //    var newl = String.Join(" , ", newUsers);
        //    Console.WriteLine(newl);
        //}


        // ----------------------------------------------------------------------------------------------------------------------------------------------------------------------


        // Practice 3 : Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the result on the console.

        //var numbers = new List<int>();

        //while (numbers.Count != 5)
        //{
        //    Console.WriteLine("Please enter 5 different numbers : ");
        //    Console.Write("--> ");
        //    var userInput = Convert.ToInt32(Console.ReadLine());

        //    if (!numbers.Contains(userInput))
        //        numbers.Add(userInput);
        //    else Console.WriteLine("This number has entered! Try another one!");
        //}
        //Console.WriteLine(String.Join(" , ",numbers));




        // ----------------------------------------------------------------------------------------------------------------------------------------------------------------------




        // Practice 4 : Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may include duplicates. Display the unique numbers that the user has entered.

        //var enter = false;
        //var users = new List<int>();

        //while (!enter)
        //{
        //    Console.WriteLine("Enter the numbers : (Or just write \"Quit\") ");
        //    Console.Write("--> ");
        //    var userInput = Console.ReadLine();

        //    if (userInput == "quit" || userInput == "Quit" || String.IsNullOrEmpty(userInput))
        //    {
        //        enter = true;
        //        break;
        //    }
        //    else
        //    {
        //        users.Add(Convert.ToInt32(userInput));
        //    }
        //}

        //if (users.Count > 0)
        //    Console.WriteLine($"\n[{String.Join(" , ", users)}]");
        //else Console.WriteLine("\nYour list is empty :)");



       }
}
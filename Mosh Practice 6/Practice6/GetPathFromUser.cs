using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Practice6
{
    internal class PathManager
    {
        public static bool IsSaveNeeded()
        {
            Console.WriteLine(@"


-------- Would you like to save it ? -------------
|        1. yes                                  |
|        2. no                                   |
--------------------------------------------------

");
            while (true)
            {
                Console.Write("Please select an option : ");
                var userChoice = Console.ReadLine();
                var userChoiceLower = userChoice?.ToLower();

                bool isUserInputValid = IsUserChoiceValid(userChoiceLower);

                if (isUserInputValid && userChoiceLower == "yes")
                {
                    return true;
                }
                if (isUserInputValid && userChoiceLower == "no")
                {
                    return false;
                }

            }
        }
        public static bool IsReadAndSaveAllContentNeeded()
        {
            Console.WriteLine(@"


-------- Would you like to save all the content and save them in a file ? -------------
|        1. yes                                  |
|        2. no                                   |
--------------------------------------------------

");
            while (true)
            {
                Console.Write("Please select an option : ");
                var userChoice = Console.ReadLine();
                var userChoiceLower = userChoice?.ToLower();

                bool isUserInputValid = IsUserChoiceValid(userChoiceLower);

                if (isUserInputValid && userChoiceLower == "yes")
                {
                    return true;
                }
                if (isUserInputValid && userChoiceLower == "no")
                {
                    return false;
                }

            }
        }
        public static string GetValidPath()
        {
            while (true)
            {
                Console.Write("Please enter a path : ");
                var userInputPath = Console.ReadLine();
                if (Directory.Exists(userInputPath))
                {
                    return userInputPath;
                }
                else
                {
                    Console.WriteLine("Please enter a valid Path : ");
                }
            }
        }
        
        public static bool IsUserChoiceValid(string userChoice)
        {
            if (userChoice == "yes" || userChoice == "no")
            {
                return true;
            }
            return false;
        }
    }
}

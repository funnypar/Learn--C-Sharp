using Practice6;
using System.IO;
internal class Program
{
    private static void Main(string[] args)
    {
        // Give a valid path from the user
        var userPath = PathManager.GetValidPath();
        
        // Find all paths and print it 
        List<string> filesPath = new List<string>();
        var fileLists = FileManager.GetAllTxtFilesWithUserPath(userPath,filesPath);

        foreach (var file in fileLists)
        {
            Console.WriteLine(file);
        }


        // Is save needed
        bool isSaveNeeded = PathManager.IsSaveNeeded();

        if (isSaveNeeded)
        {
            // Give a Path from user to save in directory
            var userSavePath = PathManager.GetValidPath();
            // Give a Path's name from user to save the file
            var userSaveFileName = FileManager.GetValidFileName();

            FileManager.SaveFile(userSavePath,userSaveFileName, filesPath.ToArray());
        }
        else
        {
            Console.WriteLine("\nOK! We will do whatever you want :) ");
        }

        // Is all content needed
        bool isReadAndSaveAllContentNeeded = PathManager.IsReadAndSaveAllContentNeeded();

        if (isReadAndSaveAllContentNeeded)
        {
            var allContents = 
            // Give a Path from user to save in directory
            var userSavePath = PathManager.GetValidPath();
            // Give a Path's name from user to save the file
            var userSaveFileName = FileManager.GetValidFileName();

            FileManager.SaveFile(userSavePath, userSaveFileName, filesPath.ToArray());
        }
        else
        {
            Console.WriteLine("\nOK! We will do whatever you want :) ");
        }
    }
}
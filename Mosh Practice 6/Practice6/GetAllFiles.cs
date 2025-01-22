using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Practice6
{
    public class FileManager
    {
        public static List<string> GetAllTxtFilesWithUserPath(string directory, List<string> fileList)
        {

            foreach (string file in Directory.GetFiles(directory, "*.txt"))
            {
                fileList.Add(file);
            }

            if (Directory.GetDirectories(directory).Any())
            {
                foreach (string subDir in Directory.GetDirectories(directory))
                {
                    GetAllTxtFilesWithUserPath(subDir, fileList);
                }
            }
            return fileList;
        }
        public static string GetValidFileName()
        {
            while (true)
            {
                Console.Write("Please enter a name for file : ");
                var userInputName = Console.ReadLine();
                string pattern = @"^(?!^(CON|PRN|AUX|NUL|COM[1-9]|LPT[1-9])$)[^<>:""/\\|?*\s.][^<>:""/\\|?*]*[^<>:""/\\|?*\s.]$";

                if (!Directory.Exists(userInputName) && Regex.IsMatch(userInputName, pattern))
                {
                    return userInputName;
                }
                else
                {
                    Console.WriteLine("Please enter a valid Path : ");
                }
            }
        }
        public static void SaveFile(string path, string fileName, string[] filesPath)
        {
            var sourceFilePath = $"{path}\\{fileName}.txt";

            // Open the file for writing with FileStream
            using (FileStream fs = new FileStream(sourceFilePath, FileMode.Create, FileAccess.Write))
            using (StreamWriter writer = new StreamWriter(fs))
            {
                foreach (string filePath in filesPath)
                {
                    writer.WriteLine(filePath);
                }
            }
        }

        public static async Task<string> ReadFileContent (string filePath)
        {
            using (var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (var reader = new StreamReader(fs))
            {
                return await reader.ReadToEndAsync();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practice6
{
    internal class Files
    {
        public static void SaveFilesPath(string path,string[] filesPath)
        {
            File.Create(path).Close();

            Console.WriteLine("Now you can have all paths! ");
        }
    }
}

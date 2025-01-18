using System.IO;
internal class Program
{
    public static void Practice1()
    {
        var words = File.ReadAllText(@"D:\127.0.0.1\C#\projects\Practice5\Practice5\Practice5\Test.txt").Split(" ");
        Console.WriteLine($"The count of words : {words.Length}");
    }
    public static void Practice2()
    {
        var words = File.ReadAllText(@"D:\127.0.0.1\C#\projects\Practice5\Practice5\Practice5\Test.txt").Split(" ");
        int index = 0;
        int length = 0;
        for(int i=0; i< words.Length; i++)
        {
            if (words[i].Length > length)
            {
                length = words[i].Length;
                index = i;
            }
        }
        Console.WriteLine($"The longest of word : {words[index]}");
    }
    private static void Main(string[] args)
    {
        // Practice 1 :  Write a program that reads a text file and displays the number of words.
        
        //Practice1();

        // Practice 2 : Write a program that reads a text file and displays the longest word in the file.
        Practice2();
    }
}
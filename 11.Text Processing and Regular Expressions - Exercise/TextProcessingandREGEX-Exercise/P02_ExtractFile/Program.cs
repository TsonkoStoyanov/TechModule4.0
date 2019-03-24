using System;

namespace P02_ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = Console.ReadLine();


            int ext = filePath.LastIndexOf('.');
       

            string extension = filePath.Substring(ext + 1);

            int fil = filePath.LastIndexOf('\\');
            int lengthFil = filePath.Length - 1 - extension.Length - fil - 1;
            
            string file = filePath.Substring(fil + 1, lengthFil);


            Console.WriteLine($"File name: {file}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}

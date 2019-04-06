using System;
using System.Text;
using System.Text.RegularExpressions;

namespace P01_Deciphering
{
    class Program
    {
        static void Main(string[] args)
        {
            string encryptedString = Console.ReadLine();

            string[] substrings = Console.ReadLine().Split(" ");

            StringBuilder sb = new StringBuilder();

            string pattern = @"^[d-z{}|#]+$";


            if (!Regex.IsMatch(encryptedString, pattern))
            {
                Console.WriteLine("This is not the book you are looking for.");
                return;
            }

            for (int i = 0; i < encryptedString.Length; i++)
            {
                char current = (char)(encryptedString[i] - 3);
                sb.Append(current);
                
            }

            var result = sb.ToString().Replace(substrings[0], substrings[1]);
            Console.WriteLine(result);
            
        }
    }
}

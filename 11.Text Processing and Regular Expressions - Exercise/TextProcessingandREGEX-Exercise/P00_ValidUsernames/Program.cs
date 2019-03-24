using System;
using System.Runtime.InteropServices;

namespace P00_ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(", ");

            foreach (var name in names)
            {
                if (!IsValidLength(name))
                {
                    continue;
                }

                if (!IsContainOnlyValidCharacter(name))
                {
                    continue;
                }

                Console.WriteLine(name);
            }
        }

        private static bool IsContainOnlyValidCharacter(string name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (!char.IsLetterOrDigit(name[i]) && name[i] != '-' && name[i] != '_')
                {
                    return false;
                }
            }

            return true;
        }

        private static bool IsValidLength(string name)
        {
            if (name.Length >= 3 && name.Length <= 16)
            {
                return true;
            }

            return false;

        }
    }
}

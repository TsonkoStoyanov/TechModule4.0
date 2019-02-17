using System;

namespace P03_PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool isValid = true;

            if (!IsValidLength(password))
            {
                Console.WriteLine($"Password must be between 6 and 10 characters");
                isValid = false;
            }
            if (!IsValidContent(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isValid = false;
            }

            if (!ContainsTwoDigit(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
                isValid = false;
            }

            if (isValid)
            {
                Console.WriteLine($"Password is valid");
            }

        }

        private static bool ContainsTwoDigit(string password)
        {
            int count = 0;

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    count++;
                }
            }

            if (count >= 2)
            {
                return true;
            }

            return false;

        }

        private static bool IsValidContent(string password)
        {
            bool isValidContent = true;

            for (int i = 0; i < password.Length; i++)
            {
                if (!char.IsLetterOrDigit(password[i]))
                {
                    return isValidContent = false;
                }
            }

            return isValidContent;
        }

        private static bool IsValidLength(string password)
        {
            if (password.Length < 6 || password.Length > 10)
            {
                return false;
            }

            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

namespace P01_SongEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string songPattern = @"^[A-Z\s]+$";

            string artistPattern = @"^[A-Z][a-z\s']+$";

            string input = string.Empty;

            List<string> songsWithArtist = new List<string>();

            StringBuilder sb = new StringBuilder();

            //Z = 90 A = 65
            //z = 122 a = 97

            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputArgs = input.Split(":");

                if (Regex.IsMatch(inputArgs[0], artistPattern) && Regex.IsMatch(inputArgs[1], songPattern))
                {
                    string artist = inputArgs[0];
                    string song = inputArgs[1];

                    int artistLength = artist.Length;
                    int songLength = song.Length;

                    for (int i = 0; i < artistLength; i++)
                    {
                        if (char.IsLetter(artist[i]) && char.IsUpper(artist[i]))
                        {
                            int decryptInt = artist[i] + artistLength;

                            if (decryptInt > 90)
                            {
                                decryptInt -= (90 - 65);
                            }

                            sb.Append((char)decryptInt);
                        }

                        else if (char.IsLetter(artist[i]) && char.IsLower(artist[i]))
                        {
                            int decryptInt = artist[i] + artistLength;

                            if (decryptInt > 122)
                            {
                                decryptInt -= (122 - 96);
                            }

                            sb.Append((char)decryptInt);
                        }
                        else
                        {
                            sb.Append(artist[i]);
                        }


                    }

                    sb.Append("@");

                    for (int i = 0; i < songLength; i++)
                    {
                        if (char.IsLetter(song[i]))
                        {
                            int decryptInt = song[i] + artistLength;

                            if (decryptInt > 90)
                            {
                                decryptInt -= (90 - 64);
                            }

                            sb.Append((char)decryptInt);
                        }
                        else
                        {
                            sb.Append(song[i]);
                        }

                    }
                    Console.WriteLine($"Successful encryption: {sb}");
                    sb.Clear();
                }
                else
                {
                    Console.WriteLine($"Invalid input!");
                }

            }

        }
    }
}

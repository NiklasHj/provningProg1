using System;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ordlista = new string[3] { "apa", "bepa", "cepa" };

            Random random = new Random();

            int slumpTal = random.Next(ordlista.Length);

            string ord = ordlista[slumpTal];

            char[] stars = new char[ord.Length];

            for (int i = 0; i < stars.Length; i++)
            {
                stars[i] = '*';
            }

            int antalGissningar = 10;

            do
            {
                Console.WriteLine("Make a guess!");
                string gissning = Console.ReadLine();

                if (ord.Contains(gissning))
                {
                    char[] ordChars = ord.ToCharArray();

                    for (int i = 0; i < ordChars.Length; i++)
                    {
                        if (gissning.ToCharArray()[0] == ordChars[i])
                        {
                            stars[i] = gissning.ToCharArray()[0];
                        }
                    }

                    Console.WriteLine(stars);

                    string starWord = new string(stars);

                    if (starWord.Contains("*"))
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("You win blin!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Wrong guess blyat!");
                    antalGissningar--;
                    Console.WriteLine("You have: " + antalGissningar + " left!");
                }
            } while (antalGissningar > 0);

        }
    }
}

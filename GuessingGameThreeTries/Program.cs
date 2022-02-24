using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)

        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis numbri ära arvata, siis ta on mängu võitnud;
            //kasutajal on kolm katset, kui kasutaja ei suuda kolme katsega numbrit ära arvata
            //siis mängu võidab arvuti.
            //programm genereerib juhuslikku numbrit ühe korra.

            Random rnd = new Random();

            int cpuNumber = rnd.Next(1, 11);

            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Palun sisesta arv 1 ja 10 vahel");
                int randomNumber = Convert.ToInt32(Console.ReadLine());

                if (randomNumber == cpuNumber)
                {
                    Console.WriteLine("Oled võitnud, arvasid numbri ära!");
                    break;
                }
                else
                {
                    i++;


                    Console.WriteLine($"Vale vastus arvuti võitis. Proovi veel, {3 - i} katset jäänud.");
                }

            }




        }



        }
    }

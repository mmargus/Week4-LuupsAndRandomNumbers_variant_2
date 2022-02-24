using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis numbri ära arvata, siis ta on mängu võitnud;
            //katsete arv on piiramatu.
            //programm genereerib juhuslikku numbrit ühe korra.

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            bool loopActive = true;
            int i = 0;
            while (loopActive)
            {
                Console.WriteLine("Sisesta arv 1 ja 10 vahel");
                int randomNumber = Convert.ToInt32(Console.ReadLine());
                if (randomNumber == cpuNumber)
                {
                    Console.WriteLine("Õnnitleme, oled mängu võitnud!");
                    loopActive = false;
                }
                else
                {
                    Console.WriteLine($"Vale number, proovi veel.");
                    i++;
                    Console.WriteLine($"Oled katsetanud juba {i} korda:");
                }

                }


            }
        }
    }

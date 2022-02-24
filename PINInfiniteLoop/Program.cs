using System;

namespace PINInfiniteLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada PIN-koodi:
            //programm võrdleb sisestatud PIN-kodi arvuga 1234;
            //kui sisestatud PIN-kood on 1234, siis konsool kuvab "Tere tulemast!";
            //kui sisestatud PIN-kood on midagi muud, siis konsool kuvab "Vale PIN. Proovi uuesti";
            //katsete arv on piiramatu.

            bool loopActive = true; //boolean --> true/false
            int i = 0;

            while (loopActive)
            {
                Console.WriteLine("Sisesta PIN-kood:");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if (userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    loopActive = false;

                }
                else
                {
                    i++; //väärtus kasvab ühe võrra.
                    Console.WriteLine("Vale PIN-kood. Proovi uuesti!");
                    Console.WriteLine($"Oled vale PIN-koodi {i} korda sisestanud.");


                }

            }


            Console.WriteLine("Kena päeva!");
        }

    }
}

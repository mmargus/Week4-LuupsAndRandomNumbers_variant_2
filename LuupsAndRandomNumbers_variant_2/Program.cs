using System;

namespace LuupsAndRandomNumbers_variant_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada PIN-koodi:
            //programm võrdleb sisestatud PIN-kodi arvuga 1234;
            //kui sisestatud PIN-kood on 1234, siis konsool kuvab "Tere tulemast!";
            //kui sisestatud PIN-kood on midagi muud, siis konsool kuvab "Vale PIN. Proovi uuesti";
            //kasutajal on kolm katset. i < 3

            int i = 0; // - iteration
            while (i < 3) //While-loop
            {
                Console.WriteLine("Sisesta PIN-kood:");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if (userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else
                {
                    //i = i + 1 == i++ (üke liitmine) ja sama on i-- (ühe lahutamine)
                    i++;

                    Console.WriteLine($"Vale PIN. {3 - i} katset on jäänud.");

                }


            }



            Console.WriteLine("Kena päeva!");

        }
    }
}

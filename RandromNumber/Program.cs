using System;

namespace RandromNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit, number on 1-10.
            //kui genereeritud number on 5, progremm lõpetab töö ja soovib "kena päeva"
            //kui genereeritud number on midagi muud, siis programm jätkab oma tööd.

            Random rnd = new Random();
            int i = 0;
            while (i != 5)


            {
                int myRandomNumber = rnd.Next(1, 11);
                Console.WriteLine($"Juhuslik number on: {myRandomNumber}");
                if (myRandomNumber == 5)
                {
                    i = myRandomNumber;
                }

            }
            Console.WriteLine("Kena päeva!");





        }
    }
}

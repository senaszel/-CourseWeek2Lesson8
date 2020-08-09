using System;

namespace CourseWeek2Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise7();
        }

        private static void Exercise7()
        {
            /* 7. Napisz program, który dla liczby zadanej przez użytkownika narysuje diament o krótszej
                  przekątnej o długości wprowadzonej przez użytkownika i wg wzoru:
                            *
                           ***
                          *****
                         *******
                        *********
                         *******
                          *****
                           ***
                            *               */

            int diagonal = 9;

            int prehalf = diagonal / 2;
            int upperParts = 1;

            int posthalf = 1;
            int lowerParts = diagonal-2;

            for (int i = 0; i < diagonal; i++)
            {
                if (i < diagonal / 2)
                {
                    Console.WriteLine(string.Concat(new string(' ', prehalf), new string('*', upperParts), new string(' ', prehalf)));
                    prehalf -= 1;
                    upperParts += 2;
                }
                else if (i == diagonal / 2)
                {
                    Console.WriteLine(new string('*', diagonal));
                }
                else if (i > diagonal / 2)
                {

                    Console.WriteLine(string.Concat(new string(' ', posthalf), new string('*', lowerParts), new string(' ', posthalf)));
                    posthalf += 1;
                    lowerParts -= 2;
                }
            }
        }

        private static void Exercise6()
        {
            /* 6. Napisz program, który dla liczb od 0 do 20 obliczy sumę wg wzoru: 1 + ½ + 1/3 + ¼ itd.        */

            for (double i = 1; i <= 20; i++)
            {
                double result = i + 0.5 * i + 0.33333 * i + 0.25 * i;
                Console.WriteLine($"Result of putting {i} for x into this equasion \"1x + 1/2x + 1/3x + 1/4x\" is {Math.Round(result, 2)}");
            }
        }

        private static void Exercise5()
        {
            /* 5. Napisz program, który dla liczb od 1 do 20 wyświetli na ekranie ich 3 potęgę      */

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(string.Concat($"3rd power of {i} is ", Math.Pow(i, 3), "."));
            }
        }

        private static void Exercise4()
        {
            /* 4. Napisz program, który po podaniu liczby całkowitej wyświetli piramidę liczb od 1 do podanej liczby w formie jak poniżej:
                    1
                    2 3
                    4 5 6
                    7 8 9 10        */

            int numberOfblocks = 10;
            int rowLimit = 1;
            int prevLimit = 0;
            for (int blockNb = 1; blockNb <= numberOfblocks; blockNb++)
            {
                if (blockNb - prevLimit < rowLimit)
                {
                    Console.Write(string.Concat(blockNb, " "));
                }
                else
                {
                    Console.WriteLine(string.Concat(blockNb, " "));
                    rowLimit += 1;
                    prevLimit = blockNb;
                }
            }
        }

        private static void Exercise3()
        {
            /* 3. Napisz program, który zaimplementuje ciąg Fibonacciego i wyświetli go na ekranie.     */

            Console.Write("Those are first 92 Fibonacci numbers:  ");
            long preprev = 0;
            Console.Write(string.Concat(preprev, " "));
            long prev = 1;
            Console.Write(string.Concat(prev, " "));

            for (int i = 2; i <= 92; i++)
            {
                long current = preprev + prev;
                preprev = prev;
                prev = current;
                Console.Write(string.Concat(current, " "));
            }
        }

        private static void Exercise2()
        {
            /* 2. Napisz program, w którym za pomocą pętli do…while znajdziesz wszystkie liczby parzyste z zakresu 0 – 1000     */

            int number = 1;
            do
            {
                if (number % 2 == 0) Console.Write(string.Concat(number, " "));
                number += 1;

            } while (number <= 1000);
        }

        private static void Exercise1()
        {
            /* 1. Napisz program, który sprawdzi ile jest liczb pierwszych w zakresie 0 – 100   */

            int primeCounter = 0;
            for (int number = 0; number <= 100; number++)
            {
                if (number == 1) continue;
                if (number == 2 || number == 3 || number == 5) { primeCounter += 1; }
                if (number % 2 == 0 || number % 3 == 0 || number % 5 == 0) continue;

                int boundary = (int)Math.Floor(Math.Sqrt(number));

                int i = 6;
                bool isPrime = false;
                while (i <= boundary)
                {
                    if (number % (i + 1) == 0 || number % (i + 5) == 0)
                    {
                        isPrime = true;
                        break;
                    }
                    i += 6;
                }

                if (!isPrime)
                {
                    primeCounter += 1;
                }
            }

            Console.WriteLine($"In range 0-100 there is {primeCounter} prime numbers.");
            // Adaptacja (poprawa!) https://stackoverflow.com/a/44203452/12024534
        }


    }
}

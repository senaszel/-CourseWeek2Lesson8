using System;

namespace CourseWeek2Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise3();
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

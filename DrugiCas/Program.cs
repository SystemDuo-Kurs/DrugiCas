using System;

namespace DrugiCas
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 253;
            a++;
            Console.WriteLine(a);
            a++;
            Console.WriteLine(a);
            a++;
            Console.WriteLine(a);
            a++;
            Console.WriteLine(a);
            a++;
            Console.WriteLine(a);
            Console.WriteLine("=================");
            int abc = 2147483000;
            abc = abc / 2 * 7;
            Console.WriteLine(abc);
            //sbyte b = -128;

            int x = 5;
            x = x * 3;
            x += 2;
            x++;


            int nesto = -5;
            Console.WriteLine($"X je {x}");
            Console.WriteLine($"Minimalan int je {int.MinValue}");
            Console.WriteLine($"Maksimalan int je: {int.MaxValue}");

            uint nestoDrugo = 0;
            Console.WriteLine($"Minimalan uint je {uint.MinValue}");
            Console.WriteLine($"Maksimalan uint je: {uint.MaxValue}");

            long veeelikBroj;
            Console.WriteLine($"Long je {sizeof(long)} bajta");
            Console.WriteLine($"Maksimalan long je: {long.MaxValue}");
            Console.WriteLine($"Long je {sizeof(ulong)} bajta");
            Console.WriteLine($"Maksimalan long je: {ulong.MaxValue}");

            float aa = 2.34f;
            double b = 4.56;
            Console.WriteLine($"Double je {sizeof(double)} bajta");
            decimal c = (decimal)3.456;
            Console.WriteLine($"Decimal je {sizeof(decimal)} bajta");

            char karakter = 'a';
            string slova = "Ovo je string";
            Console.WriteLine(slova);

            bool istina = 5 > 6;
            istina = false;

            int broj = 11;


            //  broj > 0      broj < 10        A&&B -- And
            //     F              F                F
            //     T              F                F
            //     F              T                F
            //     T              T                T 


            if (broj > 0 && broj < 10)
            {
                Console.WriteLine("Broj je izmedju 0 i 10");
            }
        }
    }
}

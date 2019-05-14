using System;

namespace MMDrawing
{

    class Program
    {
        
        static void PrintFirstHalf(int n )
        {
            char dash = '-';
            char star = '*';
            int outerDashes = n;
            int innerDashes = n;
            int middleDashes = 2 * n;
            int stars = n;
            for (int i = 0; i < n / 2 + 1; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}",
                    new string(dash, outerDashes),
                    new string(star, stars),
                    new string(dash, innerDashes),
                    new string(dash, middleDashes)
                    );
                outerDashes -= 1;
                stars += 2;
                innerDashes -= 2;
                middleDashes -= 2;

            }

        }

        static void PrintSecondHalf(int n)
        {
            char dash = '-';
            char star = '*';
            int outerDashes = n / 2;            int outerstars = n;            int innerDashes = 1;            int innerStars = n * 2 - 1;            int middleDashes = n - 1;            for (int k = 0; k < n / 2 + 1; k++)
            {
                Console.WriteLine("{0}{1}{2}{3}{2}{1}{4}{1}{2}{3}{2}{1}{0}",
                    new string(dash, outerDashes),
                    new string(star, outerstars),
                    new string(dash, innerDashes),
                    new string(star, innerStars),
                    new string(dash, middleDashes));

                outerDashes -= 1;
                innerDashes += 2;
                innerStars -= 2;
                middleDashes -= 2;


            }

        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintFirstHalf(n);
            PrintSecondHalf(n); 
                        
        }
    }
}

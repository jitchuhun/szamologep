using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace szamologep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Számológép (by: DM)");
            Console.WriteLine("...");

            bool kilepes;
            char[] muveletek = new char[6] { '+', '-', '*', '/', 'N', 'H' };

            do
            {
                Console.WriteLine("+ vagy - vagy * vagy / vagy N vagy H");
                Console.WriteLine("Művelet választása:");
                char muvelet = Convert.ToChar(Console.ReadLine());

                if (muveletek.Contains(muvelet))
                {
                    if (muvelet == 'N')
                    {
                        Console.WriteLine("Gépelje be a számot:");
                        double x = Convert.ToDouble(Console.ReadLine());

                        switch (muvelet)
                        {
                            case 'N':
                                if (x >= 0)
                                {
                                    Console.WriteLine("Az eredmény: {0}", Math.Sqrt(x));
                                }
                                else if (x < 0)
                                {
                                    Console.WriteLine("Nem értelmezhető.");
                                }
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Gépelje be az 1. számot:");
                        double x = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Gépelje be a 2. számot:");
                        double y = Convert.ToDouble(Console.ReadLine());

                        switch (muvelet)
                        {
                            case '+':
                                Console.WriteLine("Az összeg: {0}", x + y);
                                break;
                            case '-':
                                Console.WriteLine("A különbség: {0}", x - y);
                                break;
                            case '*':
                                Console.WriteLine("A szorzat: {0}", x * y);
                                break;
                            case '/':
                                if (y != 0)
                                {
                                    Console.WriteLine("A hányados: {0}", x / y);
                                }
                                else
                                {
                                    Console.WriteLine("Nem értelmezhető.");
                                }
                                break;
                            case 'H':
                                Console.WriteLine("A hatvány: {0}", Math.Pow(x, y));
                                break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Ilyen műveletet nem tudok elvégezni.");
                }

                Console.WriteLine("Ki szeretnél lépni? (true/false)");
                kilepes = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine("...");

            } while (kilepes != true);
        }
    }
}

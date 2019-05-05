using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golden_Gate
{ 
    class Program
    {

        static void print(int[] vec)
        {
            foreach (int i in vec)
            {
                Console.Write(i + "   ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            while (true)
            {
                int n = 0;
                bool ok;
                Console.WriteLine("Cate elemente se introduc?");
                do
                {
                    ok = true;
                    try
                    {
                        n = Convert.ToInt32(Console.ReadLine());

                    }
                    catch (FormatException e)
                    {
                        ok = !ok;
                        Console.WriteLine(e.Message + "\n");
                    }
                    if (n < 5)
                        Console.WriteLine("Trebuie sa tastati un numar > 5!");
                } while (!ok || n < 5);

                int[] vec = new int[n];
                Console.WriteLine("Tastati elemente:");
                for (int i = 0; i < n; i++)
                {
                    try
                    {
                        vec[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException e)
                    {
                        i--;
                        Console.WriteLine(e.Message + "\n Reincercati:");
                    }
                }
                Console.WriteLine("SUCCES in citire");

                Sort x = new Sort();
                x.MergeSort(ref vec,
                            0,
                            vec.Length - 1,
                            false); //Sortare vector de elemente citit
                print(vec);

                GoldenGate GG = new GoldenGate();
                vec = GG.GoldGate(vec);

                print(vec);

                Console.ReadKey();
            }
        }
    }
}

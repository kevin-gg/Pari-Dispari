using System;

namespace Metodi
{
    public class Metodo
    {
        public static int InputInt()
        {
            int n;
            do
            {
                Console.WriteLine("inserisci un numero");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 0);
            return n;
        }
        public static void Conta(int n1, int n2)
        {
            int pari = 0, dispari = 0;
           
            int max = Math.Max(n1, n2);
            int min = Math.Min(n1, n2);
            for (int count = min; count <= max; count++)
            {
                if (count % 2 != 0)
                {
                      dispari++;
                    Console.WriteLine($"{count} dispari");
                }
                else
                {
                      pari++;
                    Console.WriteLine($"{count} pari");
                }
                Console.WriteLine($"I positivi sono:{pari};I negativi sono:{dispari}");

            }
            
        }
    }
}

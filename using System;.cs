using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Dongusu_Pıramıt
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, satirdakiboslukmiktari, satirdakiyildizmiktari, sayi;
            Console.Write("Lütfen piramitin kaç basamaklı olacağını giriniz  : ");
            sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
            for (i = 1; i <= sayi; i++)
            {
                for (satirdakiboslukmiktari = i; satirdakiboslukmiktari <= sayi; satirdakiboslukmiktari++)
                {
                    Console.Write(" ");
                }
                for (satirdakiyildizmiktari = 1; satirdakiyildizmiktari <= i; satirdakiyildizmiktari++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
 
        }
    }  
}
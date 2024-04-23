using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Tablice
    {
        public void Powitanie()
        {
            Console.WriteLine("Witaj w pliku tablice!");
        }
        public int[] Stworz_Tablice()
        {
            Console.WriteLine();
            Console.WriteLine("===============Tworzenie Tablicy===============");
            Console.Write("Podaj ilość elementów tablicy: ");
            int dlugosc = int.Parse(Console.ReadLine());
            int[] tab = new int[dlugosc];

            for(int i = 0; i < tab.Length; i++)
            {
                Console.Write($"Podaj {i+1} element tablicy: ");
                tab[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            return tab;
        }
        public void Wyswietl_Tablice(int[] tab)
        {
            Console.WriteLine("===============Oto Twoja Tablica===============");
            foreach (int i in tab)
            {
                Console.Write(i+", ");
            }
            Console.WriteLine();
        }
    }
}

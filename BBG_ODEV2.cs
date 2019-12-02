using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yapmak istediginiz islemi seciniz");
            Console.WriteLine("1) Ondaliktan Romana");
            Console.WriteLine("2) Romandan Ondaliga");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Console.WriteLine("Sayi giriniz:");
                    int onluk = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(RomandanSayiya(onluk));
                    break;
                case 2:
                    Console.WriteLine("Roman rakami giriniz:");
                    string roman = Console.ReadLine();
                    roman = roman.ToUpper();
                    Console.WriteLine(SayidanRomana(roman));
                    break;
            }
            Console.ReadLine();
        }
        private static Dictionary<char, int> RomanSozluk = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        public static int SayidanRomana(string roman)
        {
            int sayi = 0;
            for (int i = 0; i < roman.Length; i++)
            {
                if (i + 1 < roman.Length && RomanSozluk[roman[i]] < RomanSozluk[roman[i + 1]])
                {
                    sayi -= RomanSozluk[roman[i]];
                }
                else
                {
                    sayi += RomanSozluk[roman[i]];
                }
            }
            return sayi;
        }
        public static string RomandanSayiya(int sayi)
        {
            if ((sayi < 0) || (sayi > 3999)) throw new ArgumentOutOfRangeException("1 ile 3999 arasinda bir sayi giriniz");
            if (sayi < 1) return string.Empty;
            if (sayi >= 1000) return "M" + RomandanSayiya(sayi - 1000);
            if (sayi >= 900) return "CM" + RomandanSayiya(sayi - 900);
            if (sayi >= 500) return "D" + RomandanSayiya(sayi - 500);
            if (sayi >= 400) return "CD" + RomandanSayiya(sayi - 400);
            if (sayi >= 100) return "C" + RomandanSayiya(sayi - 100);
            if (sayi >= 90) return "XC" + RomandanSayiya(sayi - 90);
            if (sayi >= 50) return "L" + RomandanSayiya(sayi - 50);
            if (sayi >= 40) return "XL" + RomandanSayiya(sayi - 40);
            if (sayi >= 10) return "X" + RomandanSayiya(sayi - 10);
            if (sayi >= 9) return "IX" + RomandanSayiya(sayi - 9);
            if (sayi >= 5) return "V" + RomandanSayiya(sayi - 5);
            if (sayi >= 4) return "IV" + RomandanSayiya(sayi - 4);
            if (sayi >= 1) return "I" + RomandanSayiya(sayi - 1);
            throw new ArgumentOutOfRangeException("hata");
            /* kaynakca: www.stackoverflow.com
                         www.geeksforgeeks.org
                         www.youtube.com 
                         www.freecodecamp.org 
                         
               ogrenci no:2017280052 */
        }
    }
}

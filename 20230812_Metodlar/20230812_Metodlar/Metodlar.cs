using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230812_Metodlar
{
    internal class Metodlar
    {
        public double ToplamaIslemi(double s1,double s2)
        {
            double toplam = s1 + s2;
            return toplam;
        }
        public void ToplaVeYaz(double sayi1,double sayi2) 
        {
            Console.WriteLine("Sayıların Toplamı ");
            Console.WriteLine("İki Adet Double Değer Toplandı");
            Console.WriteLine("Toplanan değerler {0} ve {1}",sayi1,sayi2);
            Console.WriteLine("Toplam ="+(sayi1+sayi2));
        
        }
    }
}

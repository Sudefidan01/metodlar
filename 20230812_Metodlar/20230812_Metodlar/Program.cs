using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230812_Metodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Metodlar Konu Anlatım
            //Metodlar(Fonksiyonlar)
            //Metodlar yapı itibari ile içerisinde bulunan kod bloklarını içerisnde istediğimiz yerde çalıştırmamızı sağlayan yapılardır
            //Programımız içerisinde aynı komut satırlarını birden fgazla yerde uygulamak istersek bu komut satırlarını bir paket haline getirebiliriz. Bu sayede program içerisinde kod yazma hamallığından kurtulmuş oluruz
            //Metodlar ,Class(Sınıf) yapısı içerisinde yazılırlar ve diğer sınıflar ve metodlar içerisinde hiçbir engel olmaksızın kullanılabilirler

            //Metod Yazım Kuralı
            //<erişim düzenliyici> <geri dönüş tipi> <Metod adı>(parametreler)
            //{
            //Komut Satırları
            //Komut Satırları
            //Komut Satırları
            //}

            //Erişim Düzenleyiciler
            //Erişim düzenleyicileri bir Class veya metod'un başka bir proje veya başka bir sınıf içerisindfen erişmemizi sağlayan yardımcı komutlardır
            //Private => Belirtilen class veya metodu gizli olarak tanımlar.Dışarıdan herhangi bir yapıdan erişim sağlayamaz.Sadece kendi yapısı içerisinden erişim sağlanabilir
            //Public => Halka açık manasına gelir .Diğer sınıflar veya projeler içerisinden erişim sağlanabilir
            //Internal => Diğer sınıflar içerisinden erişim sağlanbilir . Sadece başka projelerden erişim sağlanamaz

            //Not : Bir sınıf veya bir metoda erişim düzenleyicisi yazılmadığı takdirde default olarak private kabul edilir

            //Metodlarda geri dönüş tipleri
            //Metodlar yapıları itibari ile çağrıldığında kendi içerisindeki kod bloklarını işleme alan yapılardır
            //Metodlardan bazı durumlarda geriye bir değer döndürmesini isteyebiliriz
            //Metod geriye bir değer döndürecek ise hangi türden değer döndürüyor ise o türü belirtmemiz gereklidir
            //Metod içerisinde geriye dönecek olan komut satırlarını sonunda "return" komutu ile döndürebiliriz
            //Eğer bir değer döndürmesini istemiyor isek metodumuzu "void" olarak tanımlamamız gerekiyor

            //Metodlarda Parametreler
            //Metodlar içerisinde parametre tanımlamak zorunlu değildir
            //Eğer bir parametre alacak ise hangi türdeb değerler alıyor ise (<tür> <takmaAd>) şeklinde belirtmemiz gerekmektedir.Birden fazla parametre alması durumunda ,(virgül) ile diğer parametreleri de yan yana ekleyebiliriz.
            #endregion

            Metodlar m = new Metodlar();
            Console.Write("Bir Sayı Giriniz : ");
            int sayi1=int.Parse(Console.ReadLine());
            Console.Write("Bir Sayı Daha Giriniz : ");
            int sayi2 = int.Parse(Console.ReadLine());


            //Console.WriteLine(m.ToplamaIslemi(sayi1,sayi2));
            //Console.WriteLine(m.ToplamaIslemi(5.4, 2.4));
            //double geciciSayi = m.ToplamaIslemi(5,4.2);
            m.ToplaVeYaz(sayi1,sayi2);


            Console.ReadKey();
        }
    }
}

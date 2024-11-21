using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Schema;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Ders 2

            #region Double Değişkenler

            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            //Meyve,sebze ekranı yapıcaz.Ve bunun çeşitli gramajları olsun ve gramajlarıda otomatik olarak çarptıralım.Yani meyvelerin ve sebzelerin bir fiyatı olsun sonra bu fiyata göre küçük bir çıktı oluşturalım.

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice; // meyvelerin kilosu.

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice + " TL");
            //Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice + " TL");
            //Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice + " TL");
            //Console.WriteLine("---- Patates Birim Fiyatı: " + potatoPrice + " TL");
            //Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice + " TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram; 

            //appleGram = 1.245; // kaç gram aldığımız yer.
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;


            //Console.WriteLine("Alınan Ürün: Elma => " + "Birim Fiyat: " + applePrice + " - Gramaj: " + appleGram + " -> Toplam Tutar: " + appleTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün: Portakal => " + "Birim Fiyat: " + orangePrice + " - Gramaj: " + orangeGram + " -> Toplam Tutar: " + orangeTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün: Çilek => " + "Birim Fiyat: " + strawberryPrice + " - Gramaj: " + strawberryGram + " -> Toplam Tutar: " + strawberryTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün: Patates => " + "Birim Fiyat: " + potatoPrice + " - Gramaj: " + potatoGram + " -> Toplam Tutar: " + potatoTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün: Domates => " + "Birim Fiyat: " + tomatoPrice + " - Gramaj: " + tomatoGram + " -> Toplam Tutar: " + tomatoTotalPrice + " TL");


            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice; //Tüm alışveriş tutarı.

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutar: " + shoppingTotalPrice + " TL");

            #endregion

            #region Char Değişkenler

            // '' char değişkenler tek tırnak ile tanımlanıyor.

            //char symbol;
            //symbol = 'a';


            //Console.WriteLine(symbol);



            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Bir hava yolu firması için müşterinin bilet bilgilerini alacağız.

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi *****");
            //Console.WriteLine();

            /* string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;*/ // Yolcunun bilgileri,kimlik numarası gibi düşünülebilir.


            //Yukardaki bilgileri biz tanımlamayacağız. Klavyeden alacağız.

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();


            //Console.Write("Yolcu SoyAdı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgsi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu Tc Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();



            //Console.WriteLine();

            //Console.WriteLine("-------------------------") ;

            //Console.WriteLine("Yolcu Tc Kimlik No: " + passengerIdentityNumber + " - " + "Yolcu Ad Soyad: "+ passengerName + " " +  passengerSurname + " " + passengerDistrict + " / " + passengerCity + " " + passengerAge);

            #endregion

            #region Klavyeden Tam Sayı Girişleri Ve Dönüşümler

            //Ürünler olsun , ürünlerden kaç adet aldığımızı girelim daha sonra girmiş olduğumuz adet sayıssına göre para verelim sonra bu paranın karşılığını alalım.

            //int shoesPrice, computerPrice, chairPrice, tvPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount , computerCount, chairCount, tvCount; //Kaç tane ayakkabı vs. aldım.

            //Console.Write("Lütfen Aldığınız Ayakkabı Sayısını Giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine()); // Birçok dönüşüm türü var onlardan bir tanesini uyguluyoruz.

            //Console.Write("Lütfen Aldığınız Bilgisayar Sayını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Sandalye Sayını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Televizyon Sayını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice + " TL");

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //Öğrenci Sınav Notu işlemi yapıcağız.

            //double exam1,exam2,exam3,result; //result sonuç veya ortalama.

            //Console.Write("Lütfen 1.Sınav Notunu Giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sınav Notunu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.Sınav Notunu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());


            //result = (exam1 + exam2 + exam3) / 3; // ortalamasını buluyoruz.

            //Console.WriteLine();

            //Console.WriteLine("Sınav Ortalamanız: " + result);

            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender; //cinsiyet

            //Console.Write("Lütfen Cinsiyet Seçiniz: ");

            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);

            #endregion

           // Console.ReadKey();

            #endregion

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region DERS 1

            #region Yazdırma Komutları
            //Console.WriteLine("Merhaba Dünya");  Bir değer yazar imleç o satırda kalır.
            //Console.Write("Selam");  Bir değer yazar imleçi alt satıra indirir.

            //Biz burada bir tane yemek kategori tarzında kart tasarımı yapalım.

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine(); // bir satır boş bırakır.
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine(); // bir satır boş bırakır.
            //Console.WriteLine("***** Yemek Kategorileri *****");



            //Console.Read(); // Read metotu enter tuşuna basana kadar ekranı bekletirim diyo.
            #endregion

            #region Değişkenler (string)

            //string

            //Değişken_türü değişken_adı;

            //Restoran örneğinden devam ediyoruz. Müşteriler için rezervasyon sistemi olsun.

            //string name; // mesela ismi olsun.
            //name = "Mert";
            //Console.Write(name);

            //string passengerName;
            //string passengerSurname;
            //string passengerPhone;
            //string passengerEmail, district, city; //district (ilçe) 

            //passengerName = "Mert";
            //passengerSurname = "Korkmaz";
            //passengerPhone = "0555 999 99 99";
            //passengerEmail = "deneme@gmail.com";
            //district = "Çankaya";
            //city = "Ankara";

            //Console.WriteLine("***** Rezervasyon Kartı *****");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine("Müşteri: " +  passengerName + " " + passengerSurname);
            //Console.WriteLine("İletişim: " + passengerPhone );
            //Console.WriteLine("Email Adresi: " + passengerEmail);
            //Console.WriteLine("Adres: " +  district + "/" + city);
            //Console.WriteLine("-------------------------------------------------");

            //Console.WriteLine();


            //passengerName = "Yaren";
            //passengerSurname = "Kaya";
            //passengerPhone = "0556 888 88 88";
            //passengerEmail = "yaren01@gmail.com";
            //district = "Sapanca";
            //city = "Sakarya";


            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine("Müşteri: " + passengerName + " " + passengerSurname);
            //Console.WriteLine("İletişim: " + passengerPhone);
            //Console.WriteLine("Email Adresi: " + passengerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("-------------------------------------------------");


            //Console.Read();

            #endregion

            #region Değişkenler (int)

            //int 

            //int number = 24;
            //Console.WriteLine(number);  

            //Mesela müşterinin yediği, içtiği ve sonrasında hesabı ödemesi gerektiği bir senaryo oluşturalım.

            //int hamburgerPrice = 300;
            //int cokePrice = 35; //kola fiyatı
            //int waterPrice = 10;
            //int friesPrice = 50; //kızartma
            //int pizzaPrice = 250;
            //int lemonadePrice = 30; // limonata 

            ////Yukardakiler bizim restoranımızda yer alan ürünlerin fiyatı.


            //Console.WriteLine("***** Restoran Menü Fiyatı *****");
            //Console.WriteLine();
            //Console.WriteLine("----- Hamburger Fiyatı : " + hamburgerPrice + " TL");
            //Console.WriteLine("----- Kola Fiyatı : " + cokePrice + " TL");
            //Console.WriteLine("----- Su Fiyatı : " + waterPrice);
            //Console.WriteLine("----- Kızartma Fiyatı : " + friesPrice + " TL");
            //Console.WriteLine("----- Pizza Fiyatı : " + pizzaPrice + " TL");
            //Console.WriteLine("----- Limonata Fiyatı : " + lemonadePrice + " TL");
            //Console.WriteLine();
            //Console.WriteLine("***** Restoran Menü Fiyatı *****");

            ////Şimdiki senaryomuzda bir müşteri geldi ve belirli sayıda ürünler aldı. Bunu hesaplıyacağız.

            //Console.WriteLine();

            //int hamburgerCount; // kaç tane hamburger yedi.
            //int cokeCount;
            //int waterCount; 
            //int friesCount; 
            //int pizzaCount; 
            //int lemonadeCount;



            //int totalHamburgerPrice = 0; // başlangıçta 0 TL. 
            //int totalCokePrice; // başlangıç değeri bir satır yukardaki gibi atmak zorunda değiliz.
            //int totalWaterPrice;
            //int totalFriesPrice;
            //int totalPizzaPrice;
            //int totalLemonedePrice;


            //// totalPrice ' a bir atama yapacağız.

            //hamburgerCount = 3; // 3 tane hamburger yedi.
            //cokeCount = 3;  
            //waterCount = 3;
            //friesCount = 1;
            //pizzaCount = 0;
            //lemonadeCount = 0;

            //totalHamburgerPrice = hamburgerCount * hamburgerPrice; // AdetxFiyat bize toplam hamburger fiyatını verir.
            //totalCokePrice = cokeCount * cokePrice; 
            //totalWaterPrice = waterCount * waterPrice;
            //totalFriesPrice = friesCount * friesPrice;  
            //totalPizzaPrice =  pizzaCount * pizzaPrice;
            //totalLemonedePrice = lemonadeCount* lemonadePrice;



            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + " TL");
            //Console.WriteLine("Kola Tutarı: " + totalCokePrice + " TL");
            //Console.WriteLine("Su Tutarı: " + totalWaterPrice + " TL");
            //Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + " TL");
            //Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " TL");
            //Console.WriteLine("Limonata Tutarı: " + totalLemonedePrice + " TL");
            //Console.WriteLine("---------------------------------------");

            //Console.WriteLine();

            //int totalPrice= totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalLemonedePrice ; // Tüm hesap.

            //Console.WriteLine("Toplam Hesap: " + totalPrice + " TL");




            //Console.ReadKey();  

            #endregion

            #endregion

            




        }
    }
}





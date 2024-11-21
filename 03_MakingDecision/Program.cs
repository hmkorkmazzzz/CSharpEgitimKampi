using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ders 3

            #region If Else

            #region Alıştırma 1

            //Kullanıcıdan bir tane değer alalım ve bu değerin işte bizim istediğimiz değere eşit olup olmadığını kontrol edelim.


            //Console.Write("Lütfen Şifreyi Giriniz: ");
            //string password;
            //password = Console.ReadLine();

            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //Console.ReadKey();

            #endregion

            #region Alıştırma 2 

            // Kullanıcıdan bir tane başkent alalım ve bir tane de ülke alalım.

            //string capital, country;

            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();


            //if (capital == "ankara" & country == "türkiye")

            //{
            //    Console.Write("Veriler Doğrulandı.");
            //}

            //else //aksi durumda.

            //{
            //    Console.Write("Hatalı bilgi.");
            //}


            //Console.ReadKey();
            #endregion

            #region Alıştırma 3

            //Aritmetik değerlerdede doğrulama ve kontrol yapılabilir.

            //int number;
            //Console.Write("Sayıyı Giriniz: ");
            //number = int.Parse(Console.ReadLine());   //Klavyeden okunan değere dönüşüm uyguladık.
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı doğru.");
            //}
            //else //Aksi durumda.
            //{
            //    Console.WriteLine("Sayı hatalı");
            //}

            //Console.ReadKey();

            #endregion

            #region Alıştırma 4

            //Birden fazla if şartı girebiliyoruz. Bir sınav sonucunda öğrencinin almış olduğu nota göre ortalamasını metinsel ifade olarak sunan bir uygulama geliştirelim.
            // Mesela 0-50 arası Vasat, 51-70 arası Orta, 71-85 arası İyi, 85 Üstü Çok iyi mesela... ama bunuda klavyden kullanıcı tarafından alıcaz.

            //int exam1, exam2, exam3, average; //average - ortalama.
            //string result; //sonucu metinsel olarak yazdıracağız.
            //result = "Hata! ";


            //Console.Write("Sınav 1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3; // Ortamalamasını aldık.

            //Console.Write("Sınavların Ortalaması:" + " " + average);

            //Console.WriteLine();

            ////Mesela yukarda birinci adımı test ederek başlayalım.

            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç Vasat.";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç Orta";
            //}
            //if (average < 70 & average >= 84)
            //{
            //    result = "Sonuç İyi ";
            //}
            //if (average > 84)
            //{
            //    result = "Sonuç Çok İyi";
            //}
            //Console.WriteLine(result);

            //Console.ReadKey();


            #endregion

            #region Alıştırma 5

            //If-Else ile ilgili, int ve string gibi değişkenlerle kullandık şimdi bide "veya" ile beraber kullanalım.
            //Yani bir şartın herhangi biri sağlandığı zaman ne oluyor ona bakıyoruz.

            //string city;
            //Console.Write("Lütfen şehir girişi yapınız: ");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa"| city == "trabzon")
            //{
            //    Console.WriteLine("Şehir mevcut");
            //}
            //else //aksi durumda.
            //{
            //    Console.WriteLine("Şehir mevcut değil");
            //}

            //Console.ReadKey();  

            #endregion

            #region Alıştırma 6

            // Şimdi bir de eşit olmama durumları var...

            //Console.Write("Lütfen Kullanıcı Adını Giriniz: ");
            //string username = Console.ReadLine(); // tek satır içerisinde hallettik.

            //if(username != "admin")
            //{
            //    Console.Write("Bu kullanıcı adı kabul edilemez.");
            //}
            //else
            //{
            //    Console.Write("Hoşgeldiniz");
            //}

            //Console.ReadKey();  





            #endregion

            #endregion

            #region Mod İşlemleri

            #region Alıştırma 1
            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);


            //Console.ReadKey();
            #endregion

            #region Alıştırma 2 

            //Şimdi bunu klavyeden dönüşüm haline getirelim.

            //Console.Write("Lütfen 1.sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2; // number 1 'in number 2 ' ye göre modunu alsın.

            //Console.Write("1.sayının 2.sayıya bölümünden kalan: " + result);

            //Console.ReadKey();

            #endregion

            #region Alıştırma 3

            //Mesela bunu IF-ELSE ' e bağlayalım. Bir sayının tek mi çift mi olduğunu bulalım.

            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.Write("Sayı Çifttir.");
            //}
            //else //Aksi durumda.
            //{
            //    Console.Write("Sayı Tektir.");
            //}

            //Console.ReadKey();  

            #endregion



            #endregion

            #region Char Değişkeni İle Karar Yapıları

            //Klavyeden girilen harfe göre takım yazdıran programı hazırlayım. Eğer küçük veya büyük g G girilirse galatasaray yazacak şekilde yapalım.

            //char team;

            //Console.Write("Lütfen takım sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine()); // string dışında tüm değişkenler dönüşüme uğrar.


            //if (team == 'g' | team == 'G') // Burada '' char çünkü.
            //{
            //    Console.Write("Galataray");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}



            //Console.ReadKey();

            #endregion

            #region Örnek Proje Uygulaması

            //Mesela bir yemek seçim ekranı sunalım kullanıcıya kategoriler gelsin.Örnek olarak tatlıyı seçtiği zaman tatlılar açılsın.İçeceği seçerse içecekler açılsın gibi.

            //Console.WriteLine("****** C# Eğitim Kampı Restoran ******");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------------------");
            //Console.WriteLine("1- Ana Yemekler");
            //Console.WriteLine("2- Çorbalar");
            //Console.WriteLine("3- Pizzalar");
            //Console.WriteLine("4- İçecekler");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("----------------------------------------");
            //Console.WriteLine();

            //string menuItem;

            //Console.Write("Detayını görmek istediğiniz menü seçimi: ");
            //menuItem = Console.ReadLine();  

            //// Bu örnekte aşağısı aritmetik değer gibi çalışmıyor sonuçta. O yüzden string ile kullanıyoruz.

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Ana Yemek------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasülye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine();
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Çorbalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorbası");
            //    Console.WriteLine("------------Çorbalar------------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Pizzalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margaritha");
            //    Console.WriteLine("3-Tavuklu Pizza");
            //    Console.WriteLine("------------Pizzalar------------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------İçecekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");
            //    Console.WriteLine("------------İçecekler------------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Tatlılar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Triliçe");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sütlaç");
            //    Console.WriteLine("------------Tatlılar------------");
            //    Console.WriteLine();
            //}



            //Console.ReadKey();


            #endregion

            #region Switch Case

            //Klavyeden girilen sayıya göre yılın aylarını veren uygulama yapalım.


            //Console.Write("Lütfen Ay Girişi Yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch(monthNumber) // Anahtar değerimiz monthNumber olacak burada.
            //{
            //    case 1: Console.Write("Ocak"); break; // işlemi bitiren.
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default: Console.WriteLine("Hatalı Veri Girişi"); break;
            //}

            //Console.ReadKey();  






            #endregion

            #region Switch Case Hesap Makinesi

            //S-C kullanarak hesap makinesi uygulaması yapalım.

            //int number1, number2, result;
            //char symbol;

            //Console.Write("1.Sayıyı Giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("2.Sayıyı Giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen yapmak istediğiniz işlemi giriniz: "); // Kullanıcıdan burada sembol alacağız.
            //symbol = char.Parse(Console.ReadLine());

            //// Girilen sembole göre işlem yaptıracaz.

            //switch (symbol) //Anahtar kelimemiz symbol olacak.

            //{
            //    case '+': // + ise sen şunu yapacaksın. Char tanımladık o yüzden '' kullandık.
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " + result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;
            //    case '*': // + ise sen şunu yapacaksın.
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım: " + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm: " + result);
            //        break;

            //        // İstersek bunların dışında bir değer girilirse default ekleyebiliriz.
                
            //}
            //Console.ReadKey();



            #endregion



            #endregion
        }
    }
}

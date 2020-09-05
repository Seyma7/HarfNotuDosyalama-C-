/****************                      SAKARYA ÜNİVERSİTESİ BİLGİSAYAR VE BİLİŞİM BİİLİMLERİ FAKÜLTESİ                                
************			                           BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
************		                              NESNEYE DAYALI PROGRAMLAMA DERSİ
********            				                   2019-2020 BAHAR DÖNEMİ
 *****                                           AD:ŞEYMA
 **********                                      SOYAD:GÖL
 ************                                    NUMARA:B191210029
 *****************                               SINIF:1C 1.Öğretim
 ***************************************************************************************************************/




using System;
using System.IO;
namespace B191210029ndp
{
    class Program
    {
        //Ogrenci sayisini tutacak olan degiskenimiz sayaca 0 atandi.
        public static int sayac = 0;
        //Notlari tutacak 100 kapasiteli dizi olusturuldu.
        public static double[] notlar = new double[100];
        //Tum harf notlarinin yuzdeleri icin degiskenlere 0 atandi.
        public static double AAyuzdesi = 0;
        public static double BAyuzdesi = 0;
        public static double BByuzdesi = 0;
        public static double CByuzdesi = 0;
        public static double CCyuzdesi = 0;
        public static double DCyuzdesi = 0;
        public static double DDyuzdesi = 0;
        public static double FDyuzdesi = 0;
        public static double FFyuzdesi = 0;
        //Tum harf notlarimizin sayisi icin degiskenlere 0 atandi.
        public static int AAsayisi = 0;
        public static int BAsayisi = 0;
        public static int BBsayisi = 0;
        public static int CBsayisi = 0;
        public static int CCsayisi = 0;
        public static int DCsayisi = 0;
        public static int DDsayisi = 0;
        public static int FDsayisi = 0;
        public static int FFsayisi = 0;
        //Olusturdugum text dosyasindan degerleri okumak icin dosyadanOku fonksiyonu olusturuldu.
        static void dosyadanOku()
        {
            //Dosya yolu belirtildi.
            string dosya_yolu = @"C:\Users\seymagol\source\repos\B191210029ndp\TextFile1.txt";
            //Dosya okunmak uzere acildi.
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            string yazi = sw.ReadLine();
            //Yazi bulunan kisimlar icin:
            while (yazi != null)
            {
                //Bir karakterlik bosluklarla yazilar parcalandi.
                string[] gecici = yazi.Split(' ');
                //Parcalanan yazilarda ilk bolum ad, ikinci soyad, ucuncu odev1(0.1), dorduncu odev2(0.1), besinci vize(0.3), altinci final(0.5) oldugundan degerlerin etkileyecegi oranlar girildi.
                notlar[sayac] = ((0.1 * Convert.ToInt32(gecici[3])) + (0.1 * Convert.ToInt32(gecici[4])) + (0.3 * Convert.ToInt32(gecici[5])) + (0.5 * Convert.ToInt32(gecici[6])));
                //Atanan degerler sonrasinda sayac hep 1 arttirildi.
                sayac++;
                yazi = sw.ReadLine();
            }
            //Dosya okuma tamamlandi,kapatildi.
            sw.Close();
            fs.Close();
            //İsimiz bitince kullandigımiz nesneleri iade ettik.
        }
        static void dosyayaYaz()
        {
            //Okunan degerleri yeni bir text dosyasina yazdirmak icin dosyayaYaz fonksiyonu olusturuldu.
            //Dosya yolu belirtildi.
            string dosya_yolu = @"C:\Users\seymagol\source\repos\B191210029ndp\TextFile2.txt";
            //Belirtilen konumda dosya olusturuldu.
            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            //Yeni olusan dosyaya harf notlarinin sayi ve yuzdeleri yazdirildi.
            sw.WriteLine("AA Sayisi : " + AAsayisi + " AA Yuzdesi : " + AAyuzdesi);
            sw.WriteLine("BA Sayisi : " + BAsayisi + " BA Yuzdesi : " + BAyuzdesi);
            sw.WriteLine("BB Sayisi : " + BBsayisi + " BB Yuzdesi : " + BByuzdesi);
            sw.WriteLine("CB Sayisi : " + CBsayisi + " CB Yuzdesi : " + CByuzdesi);
            sw.WriteLine("CC Sayisi : " + CCsayisi + " CC Yuzdesi : " + CCyuzdesi);
            sw.WriteLine("DC Sayisi : " + DCsayisi + " DC Yuzdesi : " + DCyuzdesi);
            sw.WriteLine("DD Sayisi : " + DDsayisi + " DD Yuzdesi : " + DDyuzdesi);
            sw.WriteLine("FD Sayisi : " + FDsayisi + " FD Yuzdesi : " + FDyuzdesi);
            sw.WriteLine("FF Sayisi : " + FFsayisi + " FF Yuzdesi : " + FFyuzdesi);
            sw.Flush();
            sw.Close();
            fs.Close();
            //İsimiz bitince kullandigımiz nesneleri iade ettik.
        }


        static void Main(string[] args)
        {
            //dosyadanOku fonksiyonu cagirildi ve tek tek tum bilgiler okundu. 
            dosyadanOku();
            
            for (int i = 0; i < sayac; i++)
            {
                //Harf notlarinin araliklari belirtildi,okunan her harf notu 1 arttirildi.
                if (notlar[i] >= 90)
                {
                    AAsayisi++;
                }
                else if (notlar[i] <= 89.99 && notlar[i]>=85)
                {
                    BAsayisi++;
                }
                else if (notlar[i] <= 84.99 && notlar[i] >= 80)
                {
                    BBsayisi++;
                }
                else if(notlar[i] <= 79.99 && notlar[i] >= 75)
                {
                    CBsayisi++;
                }
                else if(notlar[i] <= 74.99 && notlar[i] >= 65)
                {
                    CCsayisi++;
                }
                else if(notlar[i] <= 64.99 && notlar[i] >= 58)
                {
                    DCsayisi++;
                }
                else if(notlar[i] <= 57.99 && notlar[i] >= 50)
                {
                    DDsayisi++;
                }
                else if(notlar[i] <= 49.99 && notlar[i] >= 40)
                {
                    FDsayisi++;
                }
                else if(notlar[i] <= 39.99 )
                {
                    FFsayisi++;
                }
            }
            //Harf notlarinin yuzdesi (100 * ( harf notu sayisi / ogrenci sayisi)) formulunden hesaplatildi.
            AAyuzdesi = 100 * AAsayisi / sayac;
            BAyuzdesi = 100 * BAsayisi / sayac;
            BByuzdesi = 100 * BBsayisi / sayac;
            CByuzdesi = 100 * CBsayisi / sayac;
            CCyuzdesi = 100 * CCsayisi / sayac;
            DCyuzdesi = 100 * DCsayisi / sayac;
            DDyuzdesi = 100 * DDsayisi / sayac;
            FDyuzdesi = 100 * FDsayisi / sayac;
            FFyuzdesi = 100 * FFsayisi / sayac;
            //Hesaplanilan yuzdeler ve harf notu sayilari yeni text dosyasina yazdirilmak uzere dosyayaYaz fonksiyonu cagirildi.
            dosyayaYaz();

            Console.WriteLine("Ortalamalar Hesaplandı ve TextFile2.txt Dosyasina Yazildi!!!");

            Console.ReadKey();
           

        }
    }
}

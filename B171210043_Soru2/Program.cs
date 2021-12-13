/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2020-2021 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 1.ÖDEV 2.SORU
**				ÖĞRENCİ ADI............: ZEYNEP BURCU BAŞTUĞ
**				ÖĞRENCİ NUMARASI.......: B171210043
**              DERSİN ALINDIĞI GRUP... :A 
****************************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B171210043_Soru2
{
    class Program
    {
        static void Main(string[] args)
        {

            bool cikis = false;

            //esc tusuna basana kadar menu ekranda gorunsun diye bir while dongusu yazdim
            while (!cikis)
            {

                Console.WriteLine("MENU ");
                Console.WriteLine("1-String bir degiskende, string degeri substring kullanmadan ara.");
                Console.WriteLine("2-String bir degiskende, string degeri substring kullanarak ara.");
                Console.WriteLine("3-Alfabenin karakterlerini bir stringde kac adet geciyor ara, bul ve ciz.");
                Console.WriteLine("4-Çıkmak için basınız.");
                Console.Write("Secim:");
                int secenek = Convert.ToInt32(Console.ReadLine());
                //switch yapısı ile menu secenekleri olusturdum
                switch (secenek)
                {
                    case 1:
                        Console.WriteLine("Cümleyi Giriniz");
                        string text = Console.ReadLine();
                        Console.WriteLine("Aranacak kelimeyi giriniz");
                        string aranacak = Console.ReadLine();
                        string arananDeger = Console.ReadLine();
                        //burada ise aranan kelimeyi replace ve indexof kullanarak buldum
                        string sekil = text.Replace(aranacak, "*");

                        int adet = sekil.Count(x => x == '*');
                        Console.WriteLine(adet + " Adet Bulunmaktadır");

                        Console.Write("kelime " + aranacak + " indis:");
                        Console.WriteLine(text.IndexOf(aranacak));

                        int indexNo = text.LastIndexOf(arananDeger);
                        Console.Write("kelime " + aranacak + " indis:");
                        Console.WriteLine(text.LastIndexOf(arananDeger));



                        break;

                    case 2:

                        int sayac = 0;
                        Console.WriteLine("Cümleyi Giriniz");
                        string metin = Console.ReadLine();
                        Console.WriteLine("Aranacak kelimeyi giriniz");
                        string aranan = Console.ReadLine();
                        string aranacakDeger = Console.ReadLine();
                        int metinuzunluk = metin.Length;
                        int arananuzunluk = aranan.Length;
                        //burada ise substring ile arananı buldum.
                        for (int i = 0; i <= (metinuzunluk - arananuzunluk); i++)
                        {
                            if (metin.Substring(i, arananuzunluk) == aranan)
                            {
                                sayac++;
                            }
                        }

                        Console.Write("kelime indis:");
                        Console.WriteLine(metin.IndexOf(aranan));
                        int indexNoIki = metin.LastIndexOf(aranacakDeger);
                        Console.Write("kelime " + aranan + " indis:");
                        Console.WriteLine(metin.LastIndexOf(aranacakDeger));


                        break;

                    case 3:

                        Console.WriteLine("Cümleyi Girin :");
                        String cumle = Console.ReadLine();
                        Console.WriteLine("Grafiksel Gosterim ------------------- Karakter Sayisi");
                        cumle = cumle.ToUpper();//cümleleri buyuk harfe cevirdim ki araması daha kolay olsun,kucuk de olabilirdi
                        String karakterler = "ABCÇDEFGĞHIJKLMNOÖPQRSŞTUÜVWXYZ";
                        int[] count = new int[karakterler.Length];
                        //burada string ile olusturulan karakterleri cumle uzunlugu boyunca aratıp sayac ile topladim
                        for (int i = 0; i < cumle.Length; i++)
                        {
                            int index = karakterler.IndexOf(cumle[i]);
                            if (index < 0)
                                continue;
                            else
                            {
                                count[index]++;
                            }
                        }
                        //burada ise yildiz bastırmak icin sayactaki kadar dongu kurdum
                        for (int i = 0; i < count.Length; i++)
                        {

                            for (int a = 0; a < count[i]; a++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine("\t\t\t" + karakterler[i] + " karakteri sayisi\t" + count[i]);
                        }

                        break;
                        //cikmak icin esc tusu kullandım baska tus da olabilirdi.
                    case 4:
                        Console.Write("Uygulamadan Çıkmak İçin ESC tuşuna basınız. ");
                        if (Console.ReadKey().Key == ConsoleKey.Escape) cikis = true;

                        Console.WriteLine("\n");

                        break;
                        // eger gecersiz secim girilirse diye default yazdim
                    default:
                        Console.Write("Gecersiz secim"); break;



                }            
                Console.ReadKey();
            }

        }
    }
}


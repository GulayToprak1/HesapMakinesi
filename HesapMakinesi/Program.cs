using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double number1, number2, sonuc = 0;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("HESAP MAKİNESİ UYGULAMASINA HOŞGELDİNİZ.\n---------------------------------------\nMENÜ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("1-Toplama İşlemi");
                Console.WriteLine("2-Çıkarma İşlemi");
                Console.WriteLine("3-Çarpma İşlemi");
                Console.WriteLine("4-Bölme İşlemi");
                Console.WriteLine("0-Çıkış");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Hangi işlemi yapmak istiyorsunuz? ");
                string menu = Console.ReadLine();

                Console.Clear();

                if (menu == "1" || menu == "2" || menu == "3" || menu == "4" || menu == "0")
                {
                    switch (menu)
                    {
                        case "1":

                            while (true)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.Write("1.Sayıyı Giriniz: ");

                                if (double.TryParse(Console.ReadLine(), out number1))
                                    break;
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("Hata! Sadece Sayı Giriniz.");
                                }
                            }

                            while (true)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.Write("2.Sayıyı Giriniz: ");

                                if (double.TryParse(Console.ReadLine(), out number2))
                                    break;
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("Hata! Sadece Sayı Giriniz.");
                                }
                            }

                            sonuc = number1 + number2;
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Toplama Sonuç:" + sonuc);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Başka Bir İşlem Yapmak istiyorsanız 'ENTER' a Basınız.");
                            Console.ReadLine();
                            Console.Clear();
                            break;

                        case "2":

                            while (true)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.Write("1.Sayıyı Giriniz: ");

                                if (double.TryParse(Console.ReadLine(), out number1))
                                    break;
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("Hata! Sadece Sayı Giriniz.");
                                }
                            }

                            while (true)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.Write("2.Sayıyı Giriniz: ");

                                if (double.TryParse(Console.ReadLine(), out number2))
                                    break;
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("Hata! Sadece Sayı Giriniz.");
                                }
                            }

                            sonuc = number1 - number2;
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Çıkartma Sonuç:" + sonuc);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Başka Bir İşlem Yapmak istiyorsanız 'ENTER' a Basınız.");
                            Console.ReadLine();
                            Console.Clear();
                            break;


                        case "3":

                            while (true)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.Write("1.Sayıyı Giriniz: ");

                                if (double.TryParse(Console.ReadLine(), out number1))
                                    break;
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("Hata! Sadece Sayı Giriniz.");
                                }
                            }

                            while (true)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.Write("2.Sayıyı Giriniz: ");

                                if (double.TryParse(Console.ReadLine(), out number2))
                                    break;
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("Hata! Sadece Sayı Giriniz.");
                                }
                            }

                            sonuc = number1 * number2;
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Çarpma Sonuç:" + sonuc);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Başka Bir İşlem Yapmak istiyorsanız 'ENTER' a Basınız.");
                            Console.ReadLine();
                            Console.Clear();
                            break;


                        case "4":

                            while (true)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.Write("1.Sayıyı Giriniz: ");

                                if (double.TryParse(Console.ReadLine(), out number1))
                                    break;
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("Hata! Sadece Sayı Giriniz.");
                                }
                            }

                            while (true)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.Write("2.Sayıyı Giriniz: ");

                                if (double.TryParse(Console.ReadLine(), out number2))
                                    break;
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("Hata! Sadece Sayı Giriniz.");
                                }
                            }

                            sonuc = number1 / number2;
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Bölme Sonuç:" + sonuc);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Başka Bir İşlem Yapmak istiyorsanız 'ENTER' a Basınız.");
                            Console.ReadLine();
                            Console.Clear();
                            break;


                        case "0":
                            Console.WriteLine("Uygulama kapatıldı..");
                            Console.ReadLine();
                            return;

                        default:
                            Console.WriteLine("Geçersiz seçenek, lütfen tekrar deneyin.");
                            Console.Clear();
                            break;
                    }
                }

                else
                {
                    Console.WriteLine("Yanlış Giriş Yaptınız Lütfen Tekrar Deneyiniz");
                    Console.WriteLine("");
                }

            }

        }
    }
}

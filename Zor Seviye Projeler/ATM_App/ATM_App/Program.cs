using ATM_App.Controller;
using System;
using System.IO;

namespace ATM_App
{
    public class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\Users\ilkay\OneDrive\Masaüstü\myapp\ATM_App\"; // Dosyanın kaydedileceği lokasyon
            string fileName = "EOD_" + DateTime.Now.ToString("ddMMyyyy") + ".txt"; // Dosyanın adı
            string fullPath = Path.Combine(path, fileName); // Tam dosya yolu

            if (!Directory.Exists(path)) // Eğer klasör yoksa oluştur
            {
                Directory.CreateDirectory(path);
            }
            Console.WriteLine("////// ATM`ye Hoşgeldiniz //////");
            while (true)
            {
                try
                {
                    UserController userController = new UserController();
                    User kullanici = userController.LoginUser();
                    if (kullanici != null)
                    {
                        Console.WriteLine("Yapmak istediğiniz işlemi seçiniz:" +
                        "\n1) Bakiye Görüntüle            3) Para Yatırma" +
                        "\n2) Para Çekme                  4) Çıkış Yap");
                        Console.Write("\nSeçiminiz: ");
                        string secim = Console.ReadLine();

                        if (secim == "1")
                        {
                            Console.WriteLine("Şuanki bakiyeniz : " + kullanici.Balance);
                        }

                        else if (secim == "2")
                        {
                            Console.WriteLine("Çekmek istediğiniz tutarı giriniz: ");
                            int cekilecek_Tutar = Convert.ToInt32(Console.ReadLine());
                            if (cekilecek_Tutar <= kullanici.Balance)
                            {
                                kullanici.Balance = (kullanici.Balance - cekilecek_Tutar);
                                Console.WriteLine("Kalan Tutar: " + kullanici.Balance);
                                using (StreamWriter sw = new StreamWriter(fullPath, true))
                                {
                                    // Logları veya fraud olabilecek yani hatalı giriş denemelerin loglarını sw nesnesine yazıyoruz
                                    sw.WriteLine("Gün Sonu Logları");
                                    sw.WriteLine("----------------");
                                    sw.WriteLine("\n #Kullanıcı Adı :  " + kullanici.Username +
                                        "\n - Çekilen Para : " + cekilecek_Tutar +
                                        "\n - Kalan Tutar : " + kullanici.Balance);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Bakiye yetersiz");
                            }
                        }
                        else if (secim == "3")
                        {
                            Console.WriteLine("Yatırmak istediğiniz tutarı giriniz");
                            int yatirilacak_tutar = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Bakiye: " + (kullanici.Balance = yatirilacak_tutar + kullanici.Balance));
                            using (StreamWriter sw = new StreamWriter(fullPath, true))
                            {
                                // Logları veya fraud olabilecek yani hatalı giriş denemelerin loglarını sw nesnesine yazıyoruz
                                sw.WriteLine("Gün Sonu Logları");
                                sw.WriteLine("----------------");
                                sw.WriteLine("\n #Kullanıcı Adı :  " + kullanici.Username +
                                    "\n - Yatıran Para : " + yatirilacak_tutar +
                                    "\n - Toplam Tutar : " + kullanici.Balance);
                                sw.WriteLine("----------------");

                            }
                        }
                        else if (secim == "4")
                        {
                            Console.WriteLine("ATM`den çıkış yapılıyor...");
                            Console.WriteLine("Çıkış yapıldı İyi Günler...");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Lütfen geçerli bir değer giriniz!");
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Hatalı Giriş");

                        throw new Exception("Hesabınıza hatalı giriş denemesi yapıldı!!!" +
                            "\n--------------------------------------------------------------\n");
                    }
                }
                catch (Exception hata)
                {
                    File.AppendAllText(fullPath, "\r\n");
                    File.AppendAllText(fullPath, hata.Message);
                }
            }
        }
    }
}

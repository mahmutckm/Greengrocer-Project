using System.Collections;
using System.Globalization;
namespace Manav_Otomasyon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList meyveler = new ArrayList() { "Elma", "Armut", "Muz", "Çilek", "Erik" };
            ArrayList sebzeler = new ArrayList() { "Patates", "Fasulye", "Bezelye", "Kabak", "Biber" };
            ArrayList alinanmeyve = new ArrayList();
            ArrayList alinansebze = new ArrayList();
            ArrayList alinanürünler = new ArrayList();
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("-----HAL HOŞGELDİNİZ-----");
                    Console.WriteLine("\nMeyve mi sebze mi almak istersiniz?");
                    string secim = Console.ReadLine().ToLower();
                    if (secim == "Meyve" || secim == "MEYVE" || secim == "m" || secim == "M" || secim == "meyve")
                    {
                        Console.Clear();
                        Console.WriteLine("-----Meyve Listesi-----");
                        foreach (var meyve in meyveler)
                        {
                            Console.WriteLine("-" + meyve);
                        }
                        Console.WriteLine("Almak istediğiniz meyvenin adını giriniz.");
                        secim = Console.ReadLine().ToLower();
                        secim = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(secim);
                        bool varmi1 = false;
                        if (meyveler.Contains(secim))
                        {
                            foreach (string[] meyve in alinanmeyve)
                            {
                                if (meyve[0] == secim)
                                {
                                    varmi1 = true;
                                    break;
                                }
                            }
                            if (varmi1)
                            {
                                Thread.Sleep(2000);
                                for (int i = 0; i < alinanmeyve.Count; i++)
                                {
                                    string[] meyve1 = (string[])alinanmeyve[i];
                                    double kilo2 = Convert.ToDouble(meyve1[1]);
                                    Console.WriteLine("{0} Kaç kilo almak istersiniz?", secim);
                                    double alinankilo = Convert.ToDouble(Console.ReadLine());
                                    alinanmeyve.RemoveAt(i);
                                    double kalanKilo = kilo2 + alinankilo;
                                    alinanmeyve.Add(new string[] { secim, kalanKilo.ToString() });
                                    Console.WriteLine("{0} kg güncellendi.", secim);
                                    Thread.Sleep(1000);
                                }
                                continue;
                            }
                            Console.WriteLine("{0} Kaç kilo almak istersiniz?", secim);
                            double kilo1 = Convert.ToDouble(Console.ReadLine());
                            while (kilo1 < 0)
                            {
                                Console.Clear();
                                Console.WriteLine("Hatalı değer girdiniz tekrar deneyiniz.");
                                Console.WriteLine("{0} Kaç kilo almak istersiniz?", secim);
                                kilo1 = Convert.ToDouble(Console.ReadLine());
                            }
                            string sayi = kilo1.ToString();
                            alinanmeyve.Add(new string[] { secim, sayi });
                            Console.WriteLine("Meyve satın alındı.");
                            Console.Clear();
                            Console.WriteLine("Başka bir arzunuz var mı? (E/H)");
                            secim = Console.ReadLine().ToLower();
                            if (secim == "evet" || secim == "e")
                            {
                                continue;
                            }
                            else if (secim == "hayır" || secim == "h")
                            {
                                Console.WriteLine("İyi günler");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Hatalı tuşlama yaptınız");
                                Console.Clear();
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Almak istediğiniz ürün stoklarda yok");
                            Thread.Sleep(2000);
                            Console.Clear();
                            continue;
                        }
                    }
                    else if (secim == "Sebze" || secim == "SEBZE" || secim == "s" || secim == "S" || secim == "sebze")
                    {
                        Console.Clear();
                        Console.WriteLine("-----Sebze Listesi-----");
                        foreach (var sebze in sebzeler)
                        {
                            Console.WriteLine("-" + sebze);
                        }
                        Console.WriteLine("Almak istediğiniz sebzenin adını giriniz.");
                        secim = Console.ReadLine().ToLower();
                        secim = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(secim);
                        bool varmi2 = false;
                        if (sebzeler.Contains(secim))
                        {
                            foreach (string[] sebze in alinansebze)
                            {
                                if (sebze[0] == secim)
                                {
                                    varmi2 = true;
                                    break;
                                }
                            }
                            if (varmi2)
                            {
                                Thread.Sleep(2000);
                                for (int i = 0; i < alinansebze.Count; i++)
                                {
                                    string[] sebze1 = (string[])alinansebze[i];
                                    double kilo2 = Convert.ToDouble(sebze1[1]);
                                    Console.WriteLine("{0} Kaç kilo almak istersiniz?", secim);
                                    double alinankilo = Convert.ToDouble(Console.ReadLine());
                                    alinansebze.RemoveAt(i);
                                    double kalanKilo = kilo2 + alinankilo;
                                    alinansebze.Add(new string[] { secim, kalanKilo.ToString() });
                                    Console.WriteLine("{0} kg güncellendi.", secim);
                                    Thread.Sleep(1000);
                                }
                                continue;
                            }
                            Console.WriteLine("{0} Kaç kilo almak istersiniz?", secim);
                            double kilo1 = Convert.ToDouble(Console.ReadLine());
                            while (kilo1 < 0)
                            {
                                Console.Clear();
                                Console.WriteLine("Hatalı değer girdiniz tekrar deneyiniz.");
                                Console.WriteLine("{0} Kaç kilo almak istersiniz?", secim);
                                kilo1 = Convert.ToDouble(Console.ReadLine());
                            }
                            string sayi = kilo1.ToString();
                            alinansebze.Add(new string[] { secim, sayi });
                            Console.WriteLine("Sebze satın alındı.");
                            Thread.Sleep(2000);
                            Console.Clear();
                            Console.WriteLine("Başka bir arzunuz var mı? (E/H)");
                            secim = Console.ReadLine().ToLower();
                            if (secim == "evet" || secim == "e")
                            {
                                continue;
                            }
                            else if (secim == "hayır" || secim == "h")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Hatalı tuşlama yaptınız");
                                Thread.Sleep(2000);
                                Console.Clear();
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Almak istediğiniz ürün stoklarda yok");
                            Thread.Sleep(2000);
                            Console.Clear();
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Hatalı tuşlama.");
                    }
                }
                catch (FormatException hata)
                {
                    Console.WriteLine("Hata" + hata);
                }
                catch (Exception hata)
                {
                    Console.WriteLine("Hata" + hata);
                }
                finally
                {
                    Console.WriteLine("İyi günler");
                }
            }
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("-----MANAV HOŞGELDİNİZ-----");
                    Console.WriteLine("\nMeyve mi sebze mi almak istersiniz?");
                    Console.WriteLine("Çıkmak için 100 tuşlayın");
                    string secim = Console.ReadLine().ToLower();

                    if (secim == "meyve" || secim == "m")
                    {
                        if (alinanmeyve.Count > 0)
                        {
                            Console.Clear();
                            Console.WriteLine("-----Meyve Listesi-----");
                            foreach (string[] meyve in alinanmeyve)
                            {
                                Console.WriteLine($"{meyve[0]} Kilo: {meyve[1]}");
                            }

                            Console.WriteLine("Almak istediğiniz meyvenin adını giriniz.");
                            secim = Console.ReadLine();
                            secim = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(secim);

                            bool varmi = false;
                            foreach (string[] meyve in alinanmeyve)
                            {
                                if (meyve[0] == secim)
                                {
                                    varmi = true;
                                    break;
                                }
                            }

                            if (varmi)
                            {
                                for (int i = 0; i < alinanmeyve.Count; i++)
                                {
                                    string[] meyve1 = (string[])alinanmeyve[i];
                                    if (meyve1[0] == secim)
                                    {
                                        double kilo2 = Convert.ToDouble(meyve1[1]);
                                        Console.WriteLine("{0} Kaç kilo almak istersiniz?", secim);
                                        double alinankilo = Convert.ToDouble(Console.ReadLine());
                                        while (alinankilo < 0)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Hatalı değer girdiniz tekrar deneyiniz.\n{0} Kaç kilo almak istersiniz?", secim);
                                            alinankilo = Convert.ToDouble(Console.ReadLine());

                                        }
                                        if (alinankilo == kilo2)
                                        {
                                            Console.WriteLine("{0} {1} kg satın alındı.", secim, alinankilo);
                                            alinanmeyve.RemoveAt(i);
                                            alinanürünler.Add(new string[] { secim, alinankilo.ToString() });
                                            break;
                                        }
                                        else if (alinankilo < kilo2)
                                        {
                                            alinanmeyve.RemoveAt(i);
                                            double kalanKilo = kilo2 - alinankilo;
                                            alinanmeyve.Add(new string[] { secim, kalanKilo.ToString() });
                                            Console.WriteLine("{0} kg güncellendi.", secim);
                                            Thread.Sleep(1000);
                                            alinanürünler.Add(new string[] { secim, alinankilo.ToString() });
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Bu kadar kilo meyve yok");
                                            Thread.Sleep(1000);
                                            break;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Seçilen meyve mevcut değil.");
                                Thread.Sleep(1000);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Halden meyve alınmamış");
                            Thread.Sleep(2000);
                            continue;
                        }
                    }
                    else if (secim == "sebze" || secim == "s")
                    {
                        if (alinansebze.Count > 0)
                        {
                            Console.Clear();
                            Console.WriteLine("-----Sebze Listesi-----");
                            foreach (string[] sebze in alinansebze)
                            {
                                Console.WriteLine($"{sebze[0]} Kilo: {sebze[1]}");
                            }

                            Console.WriteLine("Almak istediğiniz sebzenin adını giriniz.");
                            secim = Console.ReadLine();
                            secim = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(secim);

                            bool varmi = false;
                            foreach (string[] sebze in alinansebze)
                            {
                                if (sebze[0] == secim)
                                {
                                    varmi = true;
                                    break;
                                }
                            }

                            if (varmi)
                            {
                                for (int i = 0; i < alinansebze.Count; i++)
                                {
                                    string[] sebze1 = (string[])alinansebze[i];
                                    if (sebze1[0] == secim)
                                    {
                                        double kilo2 = Convert.ToDouble(sebze1[1]);
                                        Console.WriteLine("{0} Kaç kilo almak istersiniz?", secim);
                                        double alinankilo = Convert.ToDouble(Console.ReadLine());
                                        while (alinankilo < 0)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Hatalı değer girdiniz tekrar deneyiniz.\n{0} Kaç kilo almak istersiniz?", secim);
                                            alinankilo = Convert.ToDouble(Console.ReadLine());

                                        }
                                        if (alinankilo == kilo2)
                                        {
                                            Console.WriteLine("{0} {1} kg satın alındı.", secim, alinankilo);
                                            alinansebze.RemoveAt(i);
                                            alinanürünler.Add(new string[] { secim, alinankilo.ToString() });
                                            break;
                                        }
                                        else if (alinankilo < kilo2)
                                        {
                                            alinansebze.RemoveAt(i);
                                            double kalanKilo = kilo2 - alinankilo;
                                            alinansebze.Add(new string[] { secim, kalanKilo.ToString() });
                                            Console.WriteLine("{0} kg güncellendi.", secim);
                                            Thread.Sleep(1000);
                                            alinanürünler.Add(new string[] { secim, alinankilo.ToString() });
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Bu kadar kilo sebze yok");
                                            Thread.Sleep(1000);
                                            break;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Seçilen sebze mevcut değil.");
                                Thread.Sleep(1000);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Halden sebze alınmamış");
                            Thread.Sleep(2000);
                            continue;
                        }
                    }
                    else if (secim == "100")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Sebze veya meyve seçin hatalı tuşlama");
                        Thread.Sleep(1000);
                    }

                    Console.Clear();
                    Console.WriteLine("Başka bir arzunuz var mı? (E/H)");
                    secim = Console.ReadLine().ToLower();
                    if (secim == "evet" || secim == "e")
                    {
                        continue;
                    }
                    else if (secim == "hayır" || secim == "h")
                    {
                        Console.WriteLine("Afiyet Olsun");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Hatalı tuşlama yaptınız");
                        Console.Clear();
                        continue;
                    }
                }
                catch (FormatException hata)
                {
                    Console.WriteLine("Hata" + hata);
                }
                catch (Exception hata)
                {
                    Console.WriteLine("Hata" + hata);
                }
                finally
                {
                    Console.WriteLine("İyi günler");
                }
            }
            ArrayList aürünlistesi = new ArrayList();
            foreach (string[] ürün in alinanürünler)
            {
                string meyveAdi = ürün[0];
                int fiyat = int.Parse(ürün[1]);
                bool meyveBulundu = false;
                foreach (string[] mevcutürün in aürünlistesi)
                {
                    if (mevcutürün[0] == meyveAdi)
                    {
                        mevcutürün[1] = (int.Parse(mevcutürün[1]) + fiyat).ToString();
                        meyveBulundu = true;
                        break;
                    }
                }
                if (!meyveBulundu)
                {
                    aürünlistesi.Add(new string[] { meyveAdi, fiyat.ToString() });
                }
            }
            Console.Clear();
            Console.WriteLine("-----Alınan Ürünler-----");
            if (aürünlistesi.Count > 0)
            {
                foreach (string[] urun in aürünlistesi)
                {
                    Console.WriteLine($"{urun[0]} - {urun[1]} kg");
                }
            }
            else
            {
                Console.WriteLine("Henüz ürün alınmadı.");
            }
            Thread.Sleep(2000);
        }
    }
}
            





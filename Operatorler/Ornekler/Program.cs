//Operatör Örnekler

//Soru 1: Bir sayının 5 katının 2 ye bölümünden kalanı veren C# console kodunu yazın

//Adım 1: Kullanıcıdan değer al
//Adım 2: Sayının 5 katını al
//Adım 3: 5 katının 2 ye bölümünden kalanı hesapla
//Adım 4: Sonucu ekrana yaz
//Adım 5: Bitir

/*Console.WriteLine("1.Sayı Girin: ");
int sayi =int.Parse(Console.ReadLine());

int sayi1 = sayi * 5;
int sayi2 = sayi1 % 2;
Console.WriteLine("Sonuç: " + sayi2);*/

//Soru 2: Toplam 100'den büyük ve 100'den küçük kontrolünü sağlayan C# console uygulamasını yazalım

//Adım 1: Kullanıcıdan değer al
//Adım 2: Kullanıcıdan ikinci değeri al
//Adım 3: Sayıların toplamını hesapla
//Adım 4: toplam kontrolü sağlayalım
//Adım 5: Eğer toplam 100 den büyükse ekranda toplam 100 den büyüktür değilse toplam 100'den küçüktür ya da eşittir yazsın

/*Console.WriteLine("1.Sayi Giriniz: ");
int s1 = int.Parse(Console.ReadLine());

Console.WriteLine("2.Sayi Giriniz: ");
int s2 = int.Parse(Console.ReadLine());

int toplam = s1 + s2;


if (toplam >= 100)
{ 
Console.WriteLine("Toplam 100'den büyüktür");

}
else
{
    Console.WriteLine("Toplam 100'den küçüktür");

}*/


//Soru 3: Kullanıcıdan iki sayı isteyelim. Farkını hesaplayalım. Eğer fark negatifse consolede "Fark negatif", değilse "Fark pozitif veya 0'dır"

/*
//Adım 1: Kullanıcıdan birinci değeri al
//Adım 2: Kullanıcıdan ikinci değeri al
//Adım 3: Sayıların farkını hesapla
//Adım 4: Fark kontrolünü sağlayalım
//Adım 5: Eğer fark 0'dan küçükse ekranda "Fark negatif"
          değilse "Fark pozitif ya da 0'dır*/


Console.WriteLine("1.Sayi Giriniz: ");
int s3 = int.Parse(Console.ReadLine());

Console.WriteLine("2.Sayi Giriniz: ");
int s4 = int.Parse(Console.ReadLine());

int fark = s3 - s4;


if (fark <= 0)
{
    Console.WriteLine("Fark negatif");

}
else
{
    Console.WriteLine("Fark pozitif veya 0'dır");

}

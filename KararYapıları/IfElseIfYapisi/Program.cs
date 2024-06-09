/*
        IF, ELSE IF 

        Birden fazla olasılığın olduğu ve her bir olasılık için farklı işlemler yapılması gerektiği durumlarda kullanılan yapılardır
        İstediğimiz kadar ELSE IF ifadesi kullanabiliriz

         if(koşul)
        {
        
        }
        else if(koşul 2)
        {
        
        }
        else if(koşul 3)
        {
        
        }
         
        not: Burada sadece bir koşulun sağlanması yeter. "else if" "if" e alternatif olarak doğmuştur 
 */

/*int sayi = 70;

if (sayi > 100)
{
    Console.WriteLine("Sayı 100'den büyüktür.");
}
else if (sayi > 80)
{
    Console.WriteLine("Sayı 80'den büyüktür.");
}
else if (sayi > 50)
{
    Console.WriteLine("Sayı 50'den büyüktür.");
}
else if (sayi > 40)
{
    Console.WriteLine("Sayı 40'den büyüktür.");
}

Console.WriteLine("Koşul sağlandı mı?");
string yes = Console.ReadLine();
Console.WriteLine(yes);
//Çıktı: Sayı 50'den büyüktür*/


//1-Ehliyet alır almaz kontrolü

/*Console.WriteLine("Yaşınızı Giriniz: ");
int yas = int.Parse(Console.ReadLine()); //kullanıcıdan gelen string değeri int tipine çevirdikten sonra değeri "yas" değişkenine atayacaktır

if (yas >= 25)
{
    Console.WriteLine("Tır, Kamyon ve araba ehliyeti alabilir");
}
else if (yas > 20)
{
    Console.WriteLine("Kamyon ve araba ehliyeti alabilir");
}
else if (yas >= 18)
{
    Console.WriteLine("Sadece araba ehliyeti alabilir");
}
else
{
    Console.WriteLine("Ehliyet alamaz.");
}*/ //Çıktı: Kullanıcının gireceği değere göre kod bloklarından herhangi bir tanesi çalışır

//2-Öğrencinin harf notuyla geçip geçmediğini sorgulayan kontrol mekanizmasının kodlarını yazın

//1-Kullanıcıdan 3 sayısal değer isteyin
//2-Öğrencinin not ortalamasını hesaplayın
//3-harfNotu adında bir değişken tanımlayalım
//4-Koşullara göre öğrencinin alabileceği notlar: A,B,C,D,F olsun


Console.Write("1.Vize Notununuzu Girin: ");
int not1 = int.Parse(Console.ReadLine());
Console.Write("2.Vize Notunuzu Girin: ");
int not2 = int.Parse(Console.ReadLine());
Console.Write("Final Notunuzu Girin: ");
int not3 = int.Parse(Console.ReadLine());

double notOrt = (not1 + not2 + not3) / 3;
string harfNotu;

if ( notOrt >= 90 && notOrt <=100)
{
    harfNotu = "A";  
}
else if ( notOrt >= 70 && notOrt <= 89)
{
    harfNotu = "B";
}
else if (notOrt >= 60 && notOrt <= 69)
{
    harfNotu = "C";
}
else
{
    harfNotu = "F";
}

Console.WriteLine("Notların Ortalaması: " + notOrt);
Console.WriteLine("Notunuz: " +  harfNotu);
Console.ReadLine(); //programın sonlanmasını bekle


Console.Write("1. Sayı Girin: ");
int sayi1 = Convert.ToInt32(Console.ReadLine());

if ( sayi1 < 0 && sayi1 % 2 == 0)
{
    Console.WriteLine("Negatif ve çifttir");
}
else if ( sayi1 > 0 && sayi1 % 2 != 0)
{
    Console.WriteLine("Pozitif ve tektir");
}
else if ( sayi1 < 0 && sayi1 % 2 != 0)
{
    Console.WriteLine("Negatif ve tektir");
}
else if (sayi1 > 0 && sayi1 % 2 == 0)
{
    Console.WriteLine("Pozitif ve çifttir");
}
else if (sayi1 == 0)
{
    Console.WriteLine("Nötr ve çifttir");
}


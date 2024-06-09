/*
    BÜYÜK VE BÜYÜK EŞİTTİR OP

    büyüktür op: >
    büyük eşittir op: >=


 */

//Kullanıcıdan sayı iste
Console.WriteLine("1.Sayıyı giriniz: ");
int sayi1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("2.Sayıyı Giriniz: ");
int sayi2 = Convert.ToInt32(Console.ReadLine());
//Büyüktür op. kullanımı
if (sayi1 > sayi2)
{
    Console.WriteLine("1.Sayı 2.Sayıdan Büyüktür.");
}
else
{
    Console.WriteLine("1.Sayı 2.Sayıdan Küçüktür.");
}

//Büyüktür eşittir op. kullanımı
int sayi3 = 3;
int sayi4 = 6;
if (sayi3 >= sayi4)
{
    Console.WriteLine("3.Sayı 4.Sayıdan Büyüktür.");
}
else
{
    Console.WriteLine("3.Sayı 4.Sayıdan Küçüktür.");
}

//true&false kontrolü

if(sayi3 >= sayi4)
{
    Console.WriteLine()
}


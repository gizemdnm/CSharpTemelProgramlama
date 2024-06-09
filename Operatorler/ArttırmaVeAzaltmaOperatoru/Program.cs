/*
----Artırma ve Azaltma Operatörü------

Artırma Operatörü (++) ve Azaltma Operatörü (--)
Bir değişkenin değerini 1 artırmak ve 1 azaltmak için kullanılır

Bu operatörler, ön ek (++a veya --a) veya son ek (a++ ve a--) olarak kullanılabilir.Aralarındaki fark işlemin yapılma sırasıdır.

 */

//1-Artırma(++) Operatörü

// Ön ek artırma

int a = 5;
Console.WriteLine(++a); //Çıktı: 6
Console.WriteLine(a); //Çıktı: 6

//Son ek artırma(a++)

int b = 6;
Console.WriteLine(b++); //Çıktı: 6
Console.WriteLine(b); //Çıktı: 7

//b++ ifadesi, b değişkenin ilk haldeki değerini kullanır sonra bu değeri 1 artırır.
//Yani b'nin değeri önce ilk hali ekrana yazdırılır (6), sonra 1 artırılarak 7 yapılır


//2-Azaltma(--) Operatörü

int c = 5;
Console.WriteLine(--c); //Çıktı: 4
Console.WriteLine(c); //Çıktı: 4

//Son ek azaltma(a--)

int b2 = 8;
Console.WriteLine(b2--); //Çıktı:8
Console.WriteLine(b2); //Çıktı:7





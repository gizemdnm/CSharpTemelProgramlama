/*
 -----Veya Operatorü : ||

        -C# da "veya" operatörü, mantıksal OR operatörüdür. || sembolü ile temsil edilir
        -Bu operatör koşuldan en az bir tanesi sağlandığı durumlarda ilk if bloğu çalışır
        -Yani iki koşuldan en az birinin sağlanması yeterli olacaktır
        -Eğer herhangi bir koşul doğruysa true döndürür
        -Her iki koşul sağlanmazsa durum false döndürür
  
 */

//Örnek 1:

/*bool a = true;
bool b = false;

bool result = a || b; // Çıktı: True
Console.WriteLine("Sonuç: " + result);*/


//Örnek 2

int yas = 25;
bool ogrenci = false;

if (yas < 30 || ogrenci)
{
    Console.WriteLine("Koşullardan en az biri sağlanıyor");

}
else
{
    Console.WriteLine("Koşullardan her ikisi de sağlanmıyor");

}


// Ve Operatörü : &&, birden fazla koşulun tümünün doğru (true) olmasını kontrol etmek için kullanılır


/*
if(a==b && a!=c)
{
    eğer koşul sağlanıyorsa bu kod bloğu çalışacak 
}
else
{
    iki koşuldan en az biri sağlanmazsa burası çalışacak
}
*/


int yas = 19;
bool ogrenci = true;

if(yas < 20 && ogrenci) //yaşı 20 den küçük ve öğrenci ise
{
    Console.WriteLine("Öğrenci indirimi uygulandı"); //hdr koşul sağlanırsa burası çalışacak
}
else
{
    Console.WriteLine("İndirim uygulanamaz, çünkü öğrenci değilsiniz"); //iki koşuldan en az biri sağlanmazsa burası çalışacak
}


/*
        IF, ELSE YAPISI

        Sadece IF koşulunun sağlanmadığı durumda çalışmasını istediğimiz kodları, 
        IF ifadesi kapandıktan sonra ELSE ifadesinin içine yazarız

        if(koşul)
        {
        koşulun sağlanması durumunda bu blok çalışacak
        }
        else
        {
        koşul sağlanmazsa buradaki kodlar çalışacak
        }
 
 */

int sayi = -99;

if (sayi > 5) //false
{
    Console.WriteLine("Sayı 5'ten büyüktür.");
}
else
{
    Console.WriteLine("Sayı 5'ten küçüktür.");
}



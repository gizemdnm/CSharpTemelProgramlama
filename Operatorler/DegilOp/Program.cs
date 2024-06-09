// Değildir Op: !
//

//Örnek 1

bool a = true;
bool result = !a;

Console.WriteLine("a nın durumu: " + result); //Çıktı: False

//Örnek 2
bool havaYagmurlu = false;
if(!havaYagmurlu)
{
    Console.WriteLine("Hava Güneşli");
}
else
{
    Console.WriteLine("Hava Yağmurlu, Lütfen Şemsiye alınız!");
}


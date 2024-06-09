/*    -------ObjectDataType-------

        --C# dili object veri tipi, System.Object sınıfından türetilmiş olup tüm diğer veri türlerinin temel sınıfıdır.

        --C# dilinde her türdeki değişkeni saklayabilen bir veri türüdür.

        TEMEL ÖZELLİKLER
        --Tüm Türlerin Temeli: Object tipi, tüm diğer türlerin temel sınıfıdır. 
                               Bu nedenle her türdeki değişken bir object türüne dönüştürülebilir.

        BOXING AND UNBOXING NEDİR?

        -Boxing: Değer türündeki (value type) bir değişkenin referans türüne (reference type) dönüştürülmesidir.
                 örn: Bir int değişkenini object türüne atamak.
        --Unboxing: Object türündeki bir değişkenin özgün değer türüne dönüştürülmesidir.
        
*/

/*int kutu = 34; // Değer türü
object obj = kutu; // kutu object türüne dönüştürüldü.
Console.WriteLine(obj); // Çıktı: 34*/

//Unboxing Örneği
/*
int unboxingKutu = (int)obj; // Tekrar int türüne dönüştürüldü.
Console.WriteLine(unboxingKutu);*/


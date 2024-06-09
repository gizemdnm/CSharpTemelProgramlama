/* 
 

---------ShortDataType-------

    - Short değişkeni -32768 ile 32767 arasında veri depolayabilmektedir
    - Tam sayıları tutar
*/

//1-Eğer şartlar sağlanırsa alabileceği değerler

short number1 = -900;
short number2 = 0;
short number3 = 32767;
Console.WriteLine("Sayı 1: " + number1);
Console.WriteLine("Sayı 2: " + number2);
Console.WriteLine("Sayı 3: " + number3);

//2-Eğer şartlar sağlanmazsa

short number4 = 32767; 

//3-MaxValue Değerini Hesaplama

short maxValue  = short.MaxValue;
Console.WriteLine("Short veri tipinin max değer: " + maxValue);

//4-MinValue Değerinin Hesaplama

short minValue  = short.MinValue;
Console.WriteLine("Short veri tipinin min değeri: " + minValue);


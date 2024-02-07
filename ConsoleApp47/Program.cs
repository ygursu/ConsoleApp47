
int s1, s2, s3, buyuk, kucuk;

Console.Write("Bir sayı girin");
s1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Bir sayı girin");
s2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Bir sayı girin");
s3 = Convert.ToInt32(Console.ReadLine());


if (s1 > s2 && s1 > s3)
    buyuk = s1;
else if (s2 > s3)
    buyuk = s2;
else
    buyuk = s3;

if (s1 < s2 && s1 < s3)
    kucuk = s1;
else if (s2 < s3)
    kucuk = s2;
else
    kucuk = s3;


Console.WriteLine("en büyük ile en küçük toplamı={0}", kucuk + buyuk);
Console.ReadLine();
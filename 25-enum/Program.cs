Console.WriteLine(Gunler.Pazar);

Console.WriteLine((int)Gunler.Cumartesi);

int sicaklik = 32;

if(sicaklik <= (int)HavaDurumu.Normal)
{
    Console.WriteLine("Dışarıya çıkmak için havanın ısınmasını bekleyin.");
}
else if (sicaklik >= (int)HavaDurumu.Sıcak)
{
    Console.WriteLine("Dışarıya çıkmak için çok sıcak.");
}
else if (sicaklik >= (int)HavaDurumu.Normal && sicaklik < (int)HavaDurumu.CokSıcak)
{
    Console.WriteLine("Dışarı çıkabilirsiniz.");
}

enum Gunler
{
    Pazartesi = 1,
    Salı,
    Çarşamba,
    Perşembe,
    Cuma = 23,
    Cumartesi,
    Pazar
}

enum HavaDurumu
{
    Soguk = 5,
    Normal = 20,
    Sıcak = 25,
    CokSıcak = 30
}
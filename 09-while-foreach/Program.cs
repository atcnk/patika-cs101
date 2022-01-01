Console.WriteLine("Lutfen bir sayi giriniz: ");

int sayi = Convert.ToInt32(Console.ReadLine());
int sayac = 1;
int toplam = 0;

while (sayac <= sayi){
    toplam += sayac;
    sayac++;
}

Console.WriteLine(toplam/sayi);

char c = 'a';

while(c < 'z'){
    Console.WriteLine(c);
    c++;
}

string[] arabalar = {"BMW","Ford","Toyota", "Nissan"};

foreach (var araba in arabalar)
{
    Console.WriteLine(araba);
}
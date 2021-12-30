string[] renkler = new string[5];
string[] hayvanlar = {"Kedi", "Maymun", "At"};

int[] dizi = new int[5];

renkler[0] = "Mavi";
dizi[3] = 10;

Console.WriteLine(hayvanlar[1]);
Console.WriteLine(dizi[3]);
Console.WriteLine(renkler[0]);

Console.Write("lutfen dizinin eleman sayisini giriniz: ");
int diziUzunlugu = Convert.ToInt32(Console.ReadLine());
int[] sayiDizisi = new int[diziUzunlugu];

for(int i = 0; i<diziUzunlugu; i++) {
    Console.Write("Lutfen {0}. sayisi giriniz: ", i+1);
    sayiDizisi[i] = Convert.ToInt32(Console.ReadLine());
}

int toplam = 0;

foreach(var sayi in sayiDizisi){
    toplam += sayi;
}

Console.WriteLine("Ortalama: " + toplam/diziUzunlugu);
List<int> sayiListesi = new List<int>();
sayiListesi.Add(23);
sayiListesi.Add(10);
sayiListesi.Add(4);
sayiListesi.Add(5);
sayiListesi.Add(92);
sayiListesi.Add(34);

List<string> renkListesi = new List<string>();
renkListesi.Add("Kirmizi");
renkListesi.Add("Mavi");
renkListesi.Add("Turuncu");
renkListesi.Add("Sari");
renkListesi.Add("Yesil");

Console.WriteLine(renkListesi.Count);
Console.WriteLine(sayiListesi.Count);

foreach (var sayi in sayiListesi)
{
    Console.WriteLine(sayi);
}
foreach (var renk in renkListesi)
{
    Console.WriteLine(renk);
}

sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
renkListesi.ForEach(renk => Console.WriteLine(renk));

sayiListesi.Remove(4);
renkListesi.Remove("Yesil");

sayiListesi.RemoveAt(4);
renkListesi.RemoveAt(1);

sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
renkListesi.ForEach(renk => Console.WriteLine(renk));

if(sayiListesi.Contains(10)) {
    Console.WriteLine("10 listes icerisinde bulundu!");
}

Console.WriteLine(renkListesi.BinarySearch("Sari"));

string[] hayvanlar = {"Kedi","Kopek","Kus"};
List<string> hayvanListesi = new List<string>(hayvanlar);

hayvanListesi.Clear();

List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();

Kullanicilar kullanici1 = new Kullanicilar();
kullanici1.Isim = "Ayse";
kullanici1.Soyisim = "Yilmaz";
kullanici1.Yas = 25;

Kullanicilar kullanici2 = new Kullanicilar();
kullanici2.Isim = "Ozcan";
kullanici2.Soyisim = "Caliskan";
kullanici2.Yas = 26;

kullaniciListesi.Add(kullanici1);
kullaniciListesi.Add(kullanici2);

List<Kullanicilar> yeniListe = new List<Kullanicilar>();

yeniListe.Add(new Kullanicilar() {
    Isim = "Deniz",
    Soyisim = "Arda",
    Yas = 24
});

foreach (var kullanici in kullaniciListesi) {
    Console.WriteLine("Kullanici adi: " + kullanici.Isim);
    Console.WriteLine("Kullanici soyadi: " + kullanici.Soyisim);
    Console.WriteLine("Kullanici yas: " + kullanici.Yas);
}

yeniListe.Clear();

class Kullanicilar {
    private string isim;
    private string soyIsim;
    private int yas;

    public string Isim { get => isim; set => isim = value; }
    public string Soyisim { get => soyIsim; set => soyIsim = value; }
    public int Yas { get => yas; set => yas = value; }
}
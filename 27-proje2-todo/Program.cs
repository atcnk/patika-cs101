List<Kart> todo = new List<Kart>();
List<Kart> inp = new List<Kart>();
List<Kart> done = new List<Kart>();
List<Kisi> kisiler = new List<Kisi>();

VarsayilanKisiler();
MenuGoster();

void VarsayilanKisiler() {
    kisiler.Add(new Kisi("1", "atacan simsek"));
    kisiler.Add(new Kisi("2", "ahu kilic"));
    kisiler.Add(new Kisi("3", "hatica bane"));
    kisiler.Add(new Kisi("4", "ahmet gamyemez"));
    kisiler.Add(new Kisi("5", "murat ucar"));
}

void Ekle() {

    Console.WriteLine("Lutfen baslik giriniz:");
    string baslik = Convert.ToString(Console.ReadLine());

    Console.WriteLine("Lutfen icerik giriniz:");
    string icerik = Convert.ToString(Console.ReadLine());

    Console.WriteLine("Lutfen kisi id giriniz:");
    string id = Convert.ToString(Console.ReadLine());

    Console.WriteLine("Lutfen buyukluk giriniz: -> XS(1),S(2),M(3),L(4),XL(5)");
    int buyukluk = Convert.ToInt32(Console.ReadLine());
    
    for(int i = 0; i < kisiler.Count(); i++) {
        if(id == kisiler[i].id) {
            todo.Add(new Kart(baslik, icerik, id, (SizeEnum)buyukluk));
            Console.WriteLine("Basariyla eklendi, ana menuye yonlendiriliyorsunuz");
            MenuGoster();
        }
        else if(i == kisiler.Count - 1) {
            Console.WriteLine("Hatali giris yaptiniz!");
            MenuGoster();
        }
    } 
}

void MenuGoster() {
    Console.WriteLine("Lutfen yapmak istediginiz islemi seciniz");
    Console.WriteLine("*****************************************");
    Console.WriteLine("1- Board Listelemek");
    Console.WriteLine("2- Board'a Kart Eklemek");
    Console.WriteLine("3- Board'dan Kart Silmek");
    Console.WriteLine("4- Kart Tasimak");

    int secim = Convert.ToInt32(Console.ReadLine());

    switch(secim) {
        case 1:
            Listele();
            break;
        case 2:
            Ekle();
            break;
        case 3:
            Sil();
            break;
        case 4:
            TasiAra();
            break;
        default:
            Console.WriteLine("Yanlis deger girdiniz, ana menuye yonlendiriliyorsunuz.");
            MenuGoster();
            break;
    }
}

void Tasi(List<Kart> kartListesi, int index, string lineAdi) {

    Console.WriteLine("Bulunan kart bilgileri");
    Console.WriteLine("Baslik: {0}", kartListesi[index].baslik);
    Console.WriteLine("Icerik: {0}", kartListesi[index].icerik);
    Console.WriteLine("Atanan Kisi ID: {0}", kartListesi[index].atananKisi);
    Console.WriteLine("Line adi: {0}", lineAdi);

    Console.WriteLine("Lutfen tasimak istediginiz line'i secin");
    Console.WriteLine("1 - TODO");
    Console.WriteLine("2 - IN PROGRESS");
    Console.WriteLine("3 - DONE");

    int secim = Convert.ToInt32(Console.ReadLine());
    if (secim == 1) {
        if(lineAdi != "TODO") {
            todo.Add(kartListesi[index]);
            kartListesi.RemoveAt(index);
        }
        else{
            Console.WriteLine("Hatali bir secim yaptiniz");
            MenuGoster();
        }
    }
    else if(secim == 2) {
        if(lineAdi != "IN PROGRESS") {
            inp.Add(kartListesi[index]);
            kartListesi.RemoveAt(index);
        }
        else{
            Console.WriteLine("Hatali bir secim yaptiniz");
            MenuGoster();
        }
    }
    else if(secim == 3) {
        if(lineAdi != "DONE") {
            done.Add(kartListesi[index]);
            kartListesi.RemoveAt(index);
        }
        else{
            Console.WriteLine("Hatali bir secim yaptiniz");
            MenuGoster();
        }
    }

}

void TasiAra() {
    Console.WriteLine("Tasimak istediginiz kartin basligini giriniz:");
    string kartBilgisi = Convert.ToString(Console.ReadLine());

    for(int i = 0; i < todo.Count(); i++) {
    
        if(kartBilgisi == todo[i].baslik) {
            Tasi(todo, i, "TODO");
        }
    }

    for(int i = 0; i < inp.Count(); i++) {
        if(kartBilgisi == inp[i].baslik){
            Tasi(inp, i, "IN PROGRESS");
        }
    }

    for(int i = 0; i < done.Count(); i++) {
        if(kartBilgisi == done[i].baslik){
            Tasi(done, i, "DONE");
        }
    }

    Console.WriteLine("Uygun kart bulunamadi lutfen bir secim yapiniz");
    Console.WriteLine("Tasimayi sonlandirmak icin : (1)");
    Console.WriteLine("Yeniden denemek icin : (2)");
    int secim2 = Convert.ToInt32(Console.ReadLine());

    if (secim2 == 1) {
         MenuGoster();
     }
     else if(secim2 == 2) {
         TasiAra();
     }
     else {
         Console.WriteLine("Yanlis bir secim yaptiniz ana menuye yonlendiriliyorsunuz");
         MenuGoster();   
     }

}

void Listele() {

    Console.WriteLine("TODO LINE");
    Console.WriteLine("************************");

    if(todo.Count() == 0) {
        Console.WriteLine("BOS");
    }
    else {
        for(int i = 0; i < todo.Count(); i++) {
            Console.WriteLine("Baslik: {0}", todo[i].baslik);
            Console.WriteLine("Icerik: {0}", todo[i].icerik);
            Console.WriteLine("Atanan Kisi: {0}", todo[i].atananKisi);
            Console.WriteLine("Buyukluk: {0}", todo[i].buyukluk);
            Console.WriteLine("--");
        }
    }

    Console.WriteLine("IN PROGRESS LINE");
    Console.WriteLine("************************");

    if(inp.Count() == 0) {
        Console.WriteLine("BOS");
    }
    else {
        for(int i = 0; i < inp.Count(); i++) {
            Console.WriteLine("Baslik: {0}", inp[i].baslik);
            Console.WriteLine("Icerik: {0}", inp[i].icerik);
            Console.WriteLine("Atanan Kisi: {0}", inp[i].atananKisi);
            Console.WriteLine("Buyukluk: {0}", inp[i].buyukluk);
            Console.WriteLine("--");
        }
    }

    Console.WriteLine("DONE LINE");
    Console.WriteLine("************************");

    if(done.Count() == 0) {
        Console.WriteLine("BOS");
    }
    else {
        for(int i = 0; i < done.Count(); i++) {
            Console.WriteLine("Baslik: {0}", done[i].baslik);
            Console.WriteLine("Icerik: {0}", done[i].icerik);
            Console.WriteLine("Atanan Kisi: {0}", done[i].atananKisi);
            Console.WriteLine("Buyukluk: {0}", done[i].buyukluk);
            Console.WriteLine("--");
        }
    }
}

void Sil() {

    Console.WriteLine("Silmek istediginiz kartin basligini giriniz:");
    string kartBilgisi = Convert.ToString(Console.ReadLine());

    for(int i = 0; i < todo.Count(); i++) {
    
        if(kartBilgisi == todo[i].baslik) {
            todo.RemoveAt(i);
            Console.WriteLine("Kart silindi, ana menuye donuluyor");
            MenuGoster();
        }
    }

    for(int i = 0; i < inp.Count(); i++) {
        if(kartBilgisi == inp[i].baslik){
            inp.RemoveAt(i);
            Console.WriteLine("Kart silindi, ana menuye donuluyor");
            MenuGoster();
        }
    }

    for(int i = 0; i < done.Count(); i++) {
        if(kartBilgisi == done[i].baslik){
            done.RemoveAt(i);
            Console.WriteLine("Kart silindi, ana menuye donuluyor");
            MenuGoster();
        }
    }

    Console.WriteLine("Uygun kart bulunamadi lutfen bir secim yapiniz");
    Console.WriteLine("Silmeyi sonlandirmak icin : (1)");
    Console.WriteLine("Yeniden denemek icin : (2)");
    int secim2 = Convert.ToInt32(Console.ReadLine());

    if (secim2 == 1) {
         MenuGoster();
     }
     else if(secim2 == 2) {
         Sil();
     }
     else {
         Console.WriteLine("Yanlis bir secim yaptiniz ana menuye yonlendiriliyorsunuz");
         MenuGoster();   
     }
}


class Kart {

    public Kart(string baslik, string icerik, string atananKisi, SizeEnum buyukluk){

        this.baslik = baslik;
        this.icerik = icerik;
        this.atananKisi = atananKisi;
        this.buyukluk = buyukluk;
    }

    public string baslik;
    public string icerik;
    public string atananKisi;
    public SizeEnum buyukluk;
}

class Kisi {

    public Kisi(string id, string isim) {
        this.id = id;
        this.isim = isim;
    }
    public string id;
    public string isim;
}

enum SizeEnum {
    XS=1,
    S,
    M,
    L,
    XL
}
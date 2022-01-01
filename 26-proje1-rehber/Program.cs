List<Kisi> kisiler = new List<Kisi>();

varsayilanNumara();
MenuGoster();


void MenuGoster() {
    Console.WriteLine("Lutfen yapmak istediginiz islemi seciniz");
    Console.WriteLine("*****************************************");
    Console.WriteLine("1- Telefon Numarasi Kaydet");
    Console.WriteLine("2- Telefon Numarasi Sil");
    Console.WriteLine("3- Telefon Numarasi Guncelle");
    Console.WriteLine("4- Rehber Listeleme");
    Console.WriteLine("5- Rehberde Arama");

    int secim = Convert.ToInt32(Console.ReadLine());

    switch(secim) {
        case 1:
            YeniNumara();
            break;
        case 2:
            NumaraSil();
            break;
        case 3:
            NumaraGuncelle();
            break;
        case 4:
            RehberListele();
            break;
        case 5:
            AramaYap();
            break;
        default:
            Console.WriteLine("Yanlis deger girdiniz, ana menuye yonlendiriliyorsunuz.");
            MenuGoster();
            break;
    }
}

void YeniNumara() {

    Console.WriteLine("Lutfen isim giriniz:");
    string adi = Convert.ToString(Console.ReadLine());

    Console.WriteLine("Lutfen soyismini giriniz:");
    string soyadi = Convert.ToString(Console.ReadLine());

    Console.WriteLine("Lutfen numarayi giriniz:");
    string  numara = Convert.ToString(Console.ReadLine());

    kisiler.Add(new Kisi(adi,soyadi,numara));

    Console.WriteLine("Numara basariyla eklendi. Ana Menuye yonlendiriliyorsunuz");
    MenuGoster();
}

void NumaraSil() {

    Console.WriteLine("Lutfen silmek istediginiz kisinin adini veya soyadini giriniz.");
    string kisiBilgisi = Convert.ToString(Console.ReadLine());

    for(int i = 0; i < kisiler.Count(); i++) {
        
        if(kisiBilgisi == kisiler[i].adi || kisiBilgisi == kisiler[i].soyadi) {
            Console.WriteLine(kisiler[i].adi + " " + kisiler[i].soyadi + " isimli kisiyi rehberden silmeyi onayliyor musunuz? (y/n)");
            string secim = Convert.ToString(Console.ReadLine());

            if(secim == "y" || secim == "Y"){
                kisiler.RemoveAt(i);
                Console.WriteLine("Kisi silindi.");
            }
            else {
                MenuGoster();
            }
        }
        else if(i == kisiler.Count() - 1) {
            Console.WriteLine("Aradiginiz kriterde bir kayit bulunamadi. Lutfen bir secim yapiniz.");
            Console.WriteLine("Silmeyi sonlandirmak icin (1)");
            Console.WriteLine("Yeniden denemek icin (2)");
            int secim2 = Convert.ToInt32(Console.ReadLine());

            if (secim2 == 1) {
                MenuGoster();
            }
            else if(secim2 == 2) {
                NumaraSil();
            }
            else {
                Console.WriteLine("Yanlis bir secim ypatiniz ana menuye yonlendiriliyorsunuz");
                MenuGoster();   
            }
        }
    }
}

void NumaraGuncelle() {

    Console.WriteLine("Lutfen guncellemek istediginiz kisinin adini veya soyadini giriniz.");
    string kisiBilgisi = Convert.ToString(Console.ReadLine());

    for(int i = 0; i < kisiler.Count(); i++) {
        
        if(kisiBilgisi == kisiler[i].adi || kisiBilgisi == kisiler[i].soyadi) {
            Console.WriteLine(kisiler[i].adi + " " + kisiler[i].soyadi + " isimli kisinin yeni numarasini giriniz");
            string yeniNumara = Convert.ToString(Console.ReadLine());
            
            kisiler[i].numara = yeniNumara;
            Console.WriteLine("Numara basirili bir sekilde guncellendi ana menuye gonderiliyorsunuz");
            MenuGoster();
        }
        else if(i == kisiler.Count() - 1){
            Console.WriteLine("Aradiginiz kriterde bir kayit bulunamadi. Lutfen bir secim yapiniz.");
            Console.WriteLine("Guncellemeyi sonlandirmak icin (1)");
            Console.WriteLine("Yeniden denemek icin (2)");
            int secim2 = Convert.ToInt32(Console.ReadLine());

            if (secim2 == 1) {
                MenuGoster();
            }
            else if(secim2 == 2) {
                NumaraGuncelle();
            }
            else {
                Console.WriteLine("Yanlis bir secim yaptiniz ana menuye yonlendiriliyorsunuz");
                MenuGoster();   
            }
        }
    }
}

void RehberListele() {

    Console.WriteLine("Telefon Rehberi");
    Console.WriteLine("************************************");

    for(int i = 0; i < kisiler.Count(); i++) {
        Console.WriteLine("Adi: {0}", kisiler[i].adi);
        Console.WriteLine("Soyadi: {0}", kisiler[i].soyadi);
        Console.WriteLine("Numara: {0}", kisiler[i].numara);
        Console.WriteLine("--");
    }

    Console.WriteLine("Rehber basirili bir sekilde gosterildi ana menuye gonderiliyorsunuz");
    MenuGoster();
}

void AramaYap() {

    Console.WriteLine("Arama yapmak istediginiz tipi seciniz");
    Console.WriteLine("************************************");
    Console.WriteLine("Isim veya soyisme gore arama yapmak icin (1)");
    Console.WriteLine("Telefon numarasina gore arama yapmak icin (2)");
    int secim = Convert.ToInt32(Console.ReadLine());
    
    if (secim == 1) {
        Console.WriteLine("Lutfen aramak istediginiz kisinin adini veya soyadini giriniz.");
        string kisiBilgisi = Convert.ToString(Console.ReadLine());

        for(int i = 0; i < kisiler.Count(); i++) {
        
            if(kisiBilgisi == kisiler[i].adi || kisiBilgisi == kisiler[i].soyadi) {
                Console.WriteLine("Arama sonuclariniz");
                Console.WriteLine("************************************");

                Console.WriteLine("Adi: {0}", kisiler[i].adi);
                Console.WriteLine("Soyadi: {0}", kisiler[i].soyadi);
                Console.WriteLine("Numara: {0}", kisiler[i].numara);
                Console.WriteLine("--");
            }
            else if(i == kisiler.Count() - 1){
                Console.WriteLine("Aradiginiz kriterde bir kayit bulunamadi. Lutfen bir secim yapiniz.");
                Console.WriteLine("Aramayi sonlandirmak icin (1)");
                Console.WriteLine("Yeniden denemek icin (2)");
                int secim2 = Convert.ToInt32(Console.ReadLine());

                if(secim2 == 1) {
                    MenuGoster();
                }
                else if(secim2 == 2) {
                    AramaYap();
                }
                else {
                    Console.WriteLine("Yanlis bir secim yaptiniz ana menuye yonlendiriliyorsunuz");
                    MenuGoster();   
                }
            }
        }
    }
    else if(secim == 2) {
        Console.WriteLine("Lutfen aramak istediginiz kisinin numarasini giriniz.");
        string kisiNumarasi= Convert.ToString(Console.ReadLine());

        for(int i = 0; i < kisiler.Count(); i++) {
            
            if(kisiNumarasi == kisiler[i].numara) {
                Console.WriteLine("Arama sonuclariniz");
                Console.WriteLine("************************************");

                Console.WriteLine("Adi: {0}", kisiler[i].adi);
                Console.WriteLine("Soyadi: {0}", kisiler[i].soyadi);
                Console.WriteLine("Numara: {0}", kisiler[i].numara);
                Console.WriteLine("--");
            }
            else if(i == kisiler.Count() - 1){
                Console.WriteLine("Aradiginiz kriterde bir kayit bulunamadi. Lutfen bir secim yapiniz.");
                Console.WriteLine("Aramayi sonlandirmak icin (1)");
                Console.WriteLine("Yeniden denemek icin (2)");
                int secim2 = Convert.ToInt32(Console.ReadLine());

                if(secim2 == 1) {
                    MenuGoster();
                }
                else if(secim2 == 2) {
                    AramaYap();
                }
                else {
                    Console.WriteLine("Yanlis bir secim yaptiniz ana menuye yonlendiriliyorsunuz");
                    MenuGoster();   
                }
            }
        }
    }
    else {
        Console.WriteLine("Yanlis bir secim yaptiniz basa yonlendiriliyorsunuz");
        AramaYap();   
    }
}

void varsayilanNumara() {

    kisiler.Add(new Kisi("atacan", "kilic", "123"));
    kisiler.Add(new Kisi("anil", "kilic", "345"));
    kisiler.Add(new Kisi("ayse", "bane", "456"));
    kisiler.Add(new Kisi("meryem", "gamyemez", "011"));
    kisiler.Add(new Kisi("murat", "ucar", "145"));
}
class Kisi {

    public Kisi(string adi, string soyadi, string numara){

        this.adi = adi;
        this.soyadi = soyadi;
        this.numara = numara;
    }
    public string adi;
    public string soyadi;
    public string numara;
}
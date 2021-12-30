Console.WriteLine("Cevabina ulasmak istediginiz sorunun numarasini girin");
int secenek = Convert.ToInt32(Console.ReadLine());

switch(secenek){
    case 1:
        Soru1();
        break;
    case 2:
        Soru2();
        break;
    case 3:
        Soru3();
        break;
    case 4:
        Soru4();
        break;
    default:
        Console.WriteLine("yanlis bi deger girdiniz");
        break;
}

void Soru1() {
    Console.WriteLine("Pozitif bir sayi giriniz: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int[] arr = new int[n];

    Console.WriteLine("Lutfen" + n + " adet sayi giriniz: ");

    for(int i = 0; i < n; i++) {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }

    Console.WriteLine("Girdikleriniz arasindan cift olan sayilar: ");

    for(int i = 0; i < n; i++) {

        if(arr[i] % 2 == 0) {

            Console.WriteLine(arr[i]);
        }
    }
}

void Soru2() {
    Console.WriteLine("Pozitif bir sayi giriniz: ");
    int n = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Pozitif bir sayi daha giriniz: ");
    int m = Convert.ToInt32(Console.ReadLine());

    int[] arr = new int[n];

    Console.WriteLine("Lutfen " + n + " adet sayi giriniz: ");

    for(int i = 0; i < n; i++) {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }

    Console.WriteLine("Girdikleriniz arasindan " + m + " sayisina tam bolunebilen sayilar: ");

    for(int i = 0; i < n; i++) {

        if(arr[i] % m == 0) {

            Console.WriteLine(arr[i]);
        }
    }
}

void Soru3() {
    Console.WriteLine("Pozitif bir sayi giriniz: ");
    int n = Convert.ToInt32(Console.ReadLine());

    string[] arr = new string[n];

    Console.WriteLine("Lutfen " + n + " adet kelime giriniz: ");

    for(int i = 0; i < n; i++) {
        arr.SetValue(Console.ReadLine(), i);
    }

    Array.Reverse(arr);

    Console.WriteLine("Girdiginiz kelimelerin ters sirada gosterimi: ");

    for(int i = 0; i < n; i++) {
        Console.WriteLine(arr[i]);
    }
}

void Soru4() {
    Console.WriteLine("Bir cumle giriniz: ");
    string cumle = Console.ReadLine();

    bool boslukMu = true;
    int kelimeSayaci = 0;

    for(int i = 0; i < cumle.Count(); i++) {
        if(cumle.ElementAt(i) == ' ') {
            boslukMu = true;
        }
        else {
            if(boslukMu) {
                kelimeSayaci++;
                boslukMu = false;
            }
        }
    }

    string bosluksuzCumle = cumle.Replace( " ", "" );

    Console.WriteLine("Girdiginiz cumle toplam " + kelimeSayaci + " kelime ve " + bosluksuzCumle.Count()  + " harften olusmaktadir.");
}
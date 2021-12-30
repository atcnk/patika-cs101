Console.WriteLine("Enter a number: ");
int counter = Convert.ToInt32(Console.ReadLine());

for (int i = 1;i<= counter; i++) {
    if (i%2 == 1) {
        Console.WriteLine(i);
    }
}

int tekToplam = 0;
int ciftToplam = 0;

for (int i = 1; i <= 100; i++) {
    if (i%2 == 1) {
        tekToplam += i;
    }
    else {
        ciftToplam += i;
    }

    Console.WriteLine("Tek Toplam: " + tekToplam);
    Console.WriteLine("Cift Toplam: " + ciftToplam);
}

for (int i = 1; i < 10; i++) {
    if (i==4){
        break;
    }
    Console.WriteLine(i);
}
Calisan calisan1 = new Calisan();
calisan1.Ad = "Ayşe";
calisan1.Soyad = "Kara";
calisan1.No = 23425634;
calisan1.Departman = "İnsan Kaynakları";
calisan1.CalisanBilgileri();

Calisan calisan2 = new Calisan();
calisan2.Ad = "Deniz";
calisan2.Soyad = "Arda";
calisan2.No = 25646789;
calisan2.Departman = "Satın Alma";
calisan2.CalisanBilgileri();

class Calisan 
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;    
    public void CalisanBilgileri()
    {
        Console.WriteLine("Çalışan Adı: {0}", Ad);
        Console.WriteLine("Çalışan Soyadı: {0}", Soyad);
        Console.WriteLine("Çalışan No: {0}", No);
        Console.WriteLine("Çalışan Departmanı: {0}", Departman);
    }
}
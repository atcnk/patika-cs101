int month = DateTime.Now.Month;

switch(month){
    case 1:
        Console.WriteLine("Ocak ayindasiniz");
        break;
    case 2:
        Console.WriteLine("Subat ayindasiniz");
        break;
    case 3:
        Console.WriteLine("Mart ayindasiniz");
        break;
    case 12:
        Console.WriteLine("Aralik ayindasiniz");
        break;
    default:
        Console.WriteLine("Yanlis veri girdiniz");
        break;
}

switch(month){
    case 12:
    case 1:
    case 2:
        Console.WriteLine("kis ayindasiniz");
        break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine("ilkbahar ayindasiniz");
        break;
    case 6:
    case 7:
    case 8:
        Console.WriteLine("yaz ayindasiniz");
        break;
    case 9:
    case 10:
    case 11:
        Console.WriteLine("sonbahar ayindasiniz");
        break;
    default:
        break;
}
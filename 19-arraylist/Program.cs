using System.Collections;

ArrayList liste = new ArrayList();
// liste.Add("Ayse");
// liste.Add(2);
// liste.Add(true);
// liste.Add('A');

// Console.WriteLine(liste[1]);

// foreach(var item in liste) { Console.WriteLine(item);}

List<int> sayilar = new List<int>(){1,8,4,7,9,92,5};

liste.AddRange(sayilar);

foreach (var item in liste)
{
    Console.WriteLine(item);
}

liste.Sort();

foreach (var item in liste) {
    Console.WriteLine(item);
}

Console.WriteLine(liste.BinarySearch(9));

liste.Reverse();

foreach (var item in liste)
{
    Console.WriteLine(item);
}

liste.Clear();

foreach(var item in liste) {
    Console.WriteLine(item);
}
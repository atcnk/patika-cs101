using System.Collections;

int[] numbersArr = new int[20];
int smallestAverage = 0, largestAverage = 0, totalAverage = 0;

for(int i = 0; i < 20; i++) {

    Console.WriteLine("Please enter a number: ");
    numbersArr[i] = Convert.ToInt32(Console.ReadLine());
}

Array.Sort(numbersArr);

smallestAverage = (numbersArr[0] + numbersArr[1] + numbersArr[2]) / 3;
largestAverage = (numbersArr[17] + numbersArr[18] + numbersArr[19]) / 3;
totalAverage = smallestAverage + largestAverage;

Console.WriteLine("Average of the 3 smallest numbers is: " + smallestAverage);
Console.WriteLine("Average of the 3 largest numbers is: " + largestAverage);
Console.WriteLine("Total of these averages is; " + totalAverage);
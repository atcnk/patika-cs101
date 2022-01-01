using System.Collections;

ArrayList primeNumbers = new ArrayList();
ArrayList nonPrime = new ArrayList();

for(int i = 0; i < 20; i++) {

    Console.WriteLine("Please enter a positive number: ");

    int newNumber = Convert.ToInt32(Console.ReadLine());

    if(NumberCheck(newNumber)) {
        
        if(newNumber == 0 || newNumber == 1) {

            nonPrime.Add(newNumber);
            continue;
        }

        if(newNumber == 2) {

            primeNumbers.Add(newNumber);
            continue;
        }

        for(int k = 2; k < newNumber; k++) {

            if(newNumber % k == 0) {

                nonPrime.Add(newNumber);
                break;
            }
            else {

                if (k == (newNumber / 2) - 1){
                    
                    primeNumbers.Add(newNumber);
                }
            }
        }
    }
    else {

        Console.WriteLine("You did not enter a positive number.");
        i -= 1;
    }
}

Console.WriteLine("Prime numbers in ascending order: ");
PrintNumbers(primeNumbers);

Console.WriteLine("Non-prime numbers in ascending order: ");
PrintNumbers(nonPrime);

Console.WriteLine("For prime numbers: ");
PrintLengthCount(primeNumbers);

Console.WriteLine("For non-prime numbers: ");
PrintLengthCount(nonPrime);

bool NumberCheck(int number) {

    bool isNumber= true;

    if(number < 0) {
        isNumber = false;
    }

    return isNumber;
}

void PrintNumbers(ArrayList al) {

    al.Sort();
    al.Reverse();

    foreach (var number in al)
    {
        Console.WriteLine(number);
    }
}

void PrintLengthCount(ArrayList al) {

    int average = 0;

    foreach (int number in al)
    {
        average += number;
    }

    Console.WriteLine("---> number of elements is " +al.Count);
    Console.WriteLine("---> average is " + (average / al.Count));
}
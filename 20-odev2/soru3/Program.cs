using System.Collections;

ArrayList vowelsInSentence = new ArrayList();
string vowels = "aeiouAEIOU";

Console.Write("Please enter a sentence: ");
string sentence = Console.ReadLine();

for(int i = 0; i < sentence.Length; i++) {

    if(vowels.Contains(sentence[i])) {

        vowelsInSentence.Add(sentence[i]);
    }
}

Console.WriteLine("Vowels in this sentence are: ");

foreach (var vowel in vowelsInSentence)
{
    Console.WriteLine(vowel);
}
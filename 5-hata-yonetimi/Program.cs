try {
    Console.WriteLine("Enter a number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("The number you entered: " + number); 
}

catch(Exception e){
    Console.WriteLine("Error: " + e.Message.ToString());
}

finally {
    Console.WriteLine("Finished");
}

try{
    //int a = int.Parse(null);
    //int a = int.Parse("test");
    int a = int.Parse("-20000000000000");
}
catch (ArgumentNullException e){
    Console.WriteLine("You entered null value");
    Console.WriteLine(e.Message.ToString());
}
catch (FormatException e){
    Console.WriteLine("Data type is not well formatted");
    Console.WriteLine(e.Message.ToString());
}
catch (OverflowException e){
    Console.WriteLine("You entered too small or too big number");
    Console.WriteLine(e.Message.ToString());
}

finally{
    Console.WriteLine("Finished");
}
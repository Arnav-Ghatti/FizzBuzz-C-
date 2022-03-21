// All numbers from 1 to 100
for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 != 0) // Checking if number is divisible by 3 and not by 5
    {
        Console.WriteLine("Fizz");
    } else if (i % 5 == 0 && i % 3 != 0) // Checking if number is divisible by 5 and not by 3
    {
        Console.WriteLine("Buzz");
    } else if (i % 15 == 0) // Checking if number is divisible by 15 (Both by 3 and 5)
    {
        Console.WriteLine("FizzBuzz");
    } else
    {
        Console.WriteLine(i);
    }
}

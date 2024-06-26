/*
            //La console genera un numero
Console.WriteLine("Hello, I will generate a number!");

Random random = new Random();
int number = random.Next(1,101);
            //La console stampa una risposta a seconda del numero generato e del/i suo/i divisore/i (3;5)
if (number % 3 == 0 && number % 5 == 0)
{
    Console.WriteLine($"{number} Fizz Buzz");
}
else if ( number % 3 == 0 )
{
    Console.WriteLine($"{number} Fizz");
}
else if ( number % 5 == 0 )
{
    Console.WriteLine($"{number} Buzz");
}
else
{
    Console.WriteLine(number);
}
*/
int number = 1;

while (number <= 100 )
{
    if (number % 3 == 0 && number % 5 == 0)
    {
        Console.WriteLine($"{number} FizzBuzz");
        number++;
    }
    else if ( number % 3 == 0 )
    {
        Console.WriteLine($"{number} Fizz");
        number++;
    }
    else if ( number % 5 == 0 )
    {
        Console.WriteLine($"{number} Buzz");
        number++;
    }
    else
    {
        Console.WriteLine(number);
        number++;
    }
    Thread.Sleep(300);
}


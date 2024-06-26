            //Eseguiamo la pulizia della console

Console.Clear();

            //La console genera un numero
/*
Random random = new Random();
int number = random.Next(1,11);

            //La console ci chiede di indovinare se è pari o dispari

Console.WriteLine("Guess if the number is even or odd");

            //Diamo la nostra risposta

string answer = Console.ReadLine();
*/
            /*
            Creiamo il bool che verifica se il numero è pari (per indicare il suo opposto quindi dispari
            mettiamo ! prima del nome che diamo al bool)
            */
/*
bool even = number % 2 == 0;
*/
            /*
            Indichiamo i possibili risultati comparando la nostra risposta con la condizione del numero 
            estratto
            */
/*
if (even && answer == "even")
{
    Console.WriteLine("You are right");
}
else if (!even && answer == "odd")
{
    Console.WriteLine("You are right");
}
else
{
    Console.WriteLine("You are wrong");
}

            //Diciamo alla console di scrivere il numero estratto per verifica

Console.WriteLine($"The number was: {number}");
*/

Random random = new Random();
int number = random.Next(1,11);

Console.WriteLine("Guess if the number is even or odd");

string answer = Console.ReadLine();

if ((number % 2 == 0 && answer == "even") || (number % 2 != 0 && answer == "odd"))
{
    Console.WriteLine($"The number was: {number}, you were right!");
}
else
{
    Console.WriteLine($"The number was: {number}, you were wrong!");
}

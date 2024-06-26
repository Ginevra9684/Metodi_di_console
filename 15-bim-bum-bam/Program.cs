            //Il computer ci chiede di scegliere tra pari e dispari

Console.WriteLine($"Bim Bum Bam: even or odd?");

            //Creiamo la stringa per la scelta, che corrisponde al testo inserito

string choice = Console.ReadLine()!;

            //Il computer genera il numero random

Random random = new Random();
int randomNumber = random.Next(1,11);

            //L'utente sceglie il proprio numero 

Console.WriteLine("Choose your number");

int ownNumber = int.Parse(Console.ReadLine()!);

            //viene eseguita la somma dei due numeri

int result = randomNumber + ownNumber;

Console.WriteLine($"The random number is:{randomNumber}");

Console.WriteLine($"The result is:{result}");

if (( result % 2 == 0 && choice == "even") || ( result % 2 != 0 && choice == "odd"))
{
    Console.WriteLine($"You won the computer chose {result}");
}
else
{
    Console.WriteLine("You lost");
}

            //Il programma genera un numero casuale tra 1 - 100

Random random = new Random();
int number = random.Next(1,101);    

            //Il programma chiede all'utente di inserire un numero

Console.Write("Guess one number included between 1 and 100:\t");

            //comparare il numero casuale con il numero scritto

int chances = 0;

while (chances < 5 )
{   
    Console.Write("Guess the number:");
    int guess = Convert.ToInt32(Console.ReadLine());

        if (guess == number)
    {
    Console.WriteLine("Compliments!");
    }
        else if (guess < number)
    {
        Console.WriteLine("Try a bigger number");
    }
        else 
    {
        Console.WriteLine("Try a smaller number");
    }

    chances++;
}

            //
















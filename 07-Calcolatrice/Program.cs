<<<<<<< HEAD
﻿﻿//pulizia della console
=======
﻿//pulizia della console
>>>>>>> a893bc7db2aacf1f9fb8aaf7edb502c0434d8aee

Console.Clear();

            //richiesta degli operatori

Console.WriteLine("Enter first number");

double firstNumber = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter second number");

double secondNumber = Convert.ToDouble(Console.ReadLine());

            //scelta dell'operatore

Console.WriteLine("choose an operator");

string op = Console.ReadLine();

switch (op)
    {
        case "+":
            double sum = firstNumber + secondNumber;
            Console.WriteLine($"The result is: {sum}");
            break;

        case "-":
            double sub = firstNumber - secondNumber;
            Console.WriteLine($"The result is: {sub}");
            break;

        case "*":
            double product = firstNumber * secondNumber;
            Console.WriteLine($"The result is: {product}");
            break;

        case "/":
            if (secondNumber != 0)
            {
                double division = firstNumber / secondNumber;
                Console.WriteLine($"The result is: {division}");
            }
            else
            {
                Console.WriteLine("It's impossible to divide by 0, try again!");
            }
            break;

        default:
            Console.WriteLine("You didn't enter a valid operator, try again!");
            break;
    }
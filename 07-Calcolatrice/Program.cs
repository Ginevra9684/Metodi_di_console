/*
a  b  c 
a è un numero
b è un operatore
c è un numero
*/
int minuendo = Convert.ToInt32(Console.ReadLine())!;

Convert.ToInt32(minuendo);

Console.Write("Inserire il minuendo \t");

Convert.ToInt32(Console.ReadLine());

int operatore = Convert.ToInt32(Console.ReadLine())!;

Convert.ToInt32(operatore);

switch (operatore)
{
    case 1:
        Console.Write("+");
        break;                                          
    case 2:
        Console.Write("-");
        break;
    case 3:
        Console.Write("*");
        break;
    case 4:
        Console.Write("/");
        break;
}

Console.Write("Inserire l'operatore \t");

Convert.ToInt32(Console.ReadLine())!;

int sottraendo = Convert.ToInt32(Console.ReadLine())!;

Convert.ToInt32(sottraendo);

Console.Write("Inserire il sottraendo \t");

Convert.ToInt32(Console.ReadLine())!;

Console.Write($"L'operazione è: {minuendo} {operatore} {sottraendo}");

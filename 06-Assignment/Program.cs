Console.Write("Inserire un numero compreso tra 1 e 7 \t");

int giorno = Convert.ToInt32(Console.ReadLine());                   // Converte il valore inserito in un intero utilizzando il metodo Convert.ToInt32
    // oppure int.Parse      il primo restituisce 0 se il valore inserito non è un numero e il secondo restituisce un'eccezione

switch (giorno)
{
    case 1:
        Console.WriteLine("Lunedì");
        break;                                           
    case 2:
        Console.WriteLine("Martedì");
        break;
    case 3:
        Console.WriteLine("Mercoledì");
        break;
    case 4:
        Console.WriteLine("Giovedì");
        break;
    case 5:
        Console.WriteLine("Venerdì");
        break;
    case 6:
        Console.WriteLine("Sabato");
        break;
    case 7:
        Console.WriteLine("Domenica");
        break;
    default:
        Console.WriteLine("Il numero non corrisponde a nessun giorno della settimana");
        break;
}



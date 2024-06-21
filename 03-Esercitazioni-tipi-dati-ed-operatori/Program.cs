// Pulire il terminale

Console.Clear();

// Stampare il valore di una variabile

int numero;                                              // Dichiaro una variabile di tipo intero

numero = 10;                                             // Inizializzo la variabile numero con il valore 10

Console.WriteLine(numero);                               // Stampo il valore della variabile numero

// Stampare il valore di una variabile con un messaggio

int età = 20;                                            // Dichiaro ed inizializzo la variabile età con il valore 20

Console.WriteLine("L'età è: " + età);                    // Stampo il valore della variabile età con un messaggio

//oppure con interpolazione

Console.WriteLine($"L'Età è: {età}");

//Incrementare il valore di età di una unità

età++;                                                    // incremento il valore della variabile di un'unità

Console.WriteLine($"L'età è: {età}");                     // Stampo il valore della variabile età con un messaggio

//Incrementare l'età di 5 unità

età += 5;                                                 // Incremento il valore della variabile di 5 unità

Console.WriteLine($"L'età è: {età}");                     // Stampo il valore della variabile con un messaggio

// Decrementare l'età di 5 unità

età -= 5;                                                 // Decremento il valore della variabile di 5 unità

Console.WriteLine($"L'età è: {età}"); 

// Stampare due variabili una stringa ed una int

string nome = "Mario";                                    // Dichiaro ed inizializzo la variabile nome con il valore "Mario"

Console.WriteLine($"Il nome è: {nome} e l'età è: {età}"); // Stampo il valore della variabile nome ed età con un messaggio
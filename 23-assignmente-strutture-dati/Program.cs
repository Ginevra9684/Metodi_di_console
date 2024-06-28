/*
string[] nomi = new string[8];
        nomi[0] = "Allison";
        nomi[1] = "Sharon";
        nomi[2] = "Ginevra";
        nomi[3] = "Daniele";
        nomi[4] = "Serghej";
        nomi[5] = "Mattia";
        nomi[6] = "Matteo";
        nomi[7] = "Silvano";

Random random = new Random();
int numero = random.Next(nomi.Length);
        
        Console.WriteLine($"Ciao {nomi[numero]}");
*/
// il metodo RemoveAt(numero) ci permette di eliminare un nome una volta che è stato estratto

/*
List<string> nomi = new List<string> {"Allison", "Sharon", "Ginevra", "Daniele", "Serghej", "Mattia", "Matteo","Silvano"};

Random random = new Random();
int numero = random.Next(nomi.Count);

Console.WriteLine($"Ciao {nomi[numero]}");

nomi.RemoveAt(numero);

Console.WriteLine("I rimanenti sono:");

foreach (string nome in nomi)
        {
            Console.WriteLine(nome);
        }
*/
/*
List<string> nomi = new List<string> {"Allison", "Sharon", "Ginevra", "Daniele", "Serghej", "Mattia", "Matteo","Silvano"};

while(nomi.Count>0)
{
    Random random = new Random();
    int numero = random.Next(nomi.Count);

    Console.WriteLine($"Ciao {nomi[numero]}");
    
    nomi.RemoveAt(numero);

    Console.WriteLine($"I rimanenti sono:");

    foreach (string nome in nomi)
        {
            Console.WriteLine(nome);
        }
}
*/

/*
//Creiamo una lista
List<string> nomi = new List<string> {"Allison", "Sharon", "Ginevra", "Daniele", "Serghej", "Mattia", "Matteo","Silvano"};

//Generiamo un numero casuale
Random random = new Random(); //va generato una sola volta

//assegnamo un ciclo al conteggio
while(nomi.Count>0)
{
    int indice = random.Next(nomi.Count);

    Console.WriteLine($"Il sorteggiato è {nomi[indice]}");
        
    nomi.RemoveAt(indice);

    Console.WriteLine($"Elenco partecipanti:");

    foreach (string nome in nomi)
        {
            Console.WriteLine(nome);
        }
}
*/
//------------------------------------------------------------------------------------------------------------
//Creiamo una lista di partecipanti e una di sorteggiati
List<string> partecipanti = new List<string> {"Allison", "Sharon", "Ginevra", "Daniele", "Serghej", "Mattia", "Matteo","Silvano"};

List<string> sorteggiati = new List<string>();
//Generiamo un'oggetto casuale
Random random = new Random(); //va generato una sola volta
//------------------------------------------------------------------------------------------------------------
//assegnamo un ciclo al conteggio
while(partecipanti.Count>0)
{
    int indice = random.Next(partecipanti.Count);
    string sorteggiato = partecipanti[indice];

    Console.WriteLine($"Il sorteggiato è {sorteggiato}");
//--------------------------------------------------------------------------------------------------------        
    partecipanti.RemoveAt(indice);
    sorteggiati.Add(sorteggiato);
//-----------------------------------------------------
    Console.WriteLine($"Elenco partecipanti:");

    foreach (string partecipante in partecipanti)
        {
            Console.WriteLine(partecipante);
        }
    
    Console.WriteLine($"Elenco sorteggiati:");
    foreach (string partecipante in sorteggiati)
        {   
            Console.WriteLine(partecipante);
        }
    Thread.Sleep(3000);
}
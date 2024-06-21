/*

Gli operatori sono utilizzati per eseguire operazioni su uno opiù operandi 

 Gli operatori possono essere:

operatori aritmetici
operatori di confronto
operatori logici
operatori di assegnazione

*/

// Esempio di utilizzo di operatori aritmetici

int a = 10;

int b = 20;

int somma = a + b;                    // somma = 30

int differenza = a - b;               // differenza = -10

int prodotto = a * b;                 // prodotto = 200

int divisione = a / b;                // divisione = 0

int modulo = a % b;                   // modulo = 10

// Esempio di utilizzo degli operatori di confronto

int c = 30;

int c == a;                           // false

int c != a;                           // true

int c > a;                            // true

int c < a;                            // false

int c >= a;                           // true

int c <= a;                           // false

// Eesempio di utilizzo degli operatori logici

bool x = true;

bool y = false;

//and
bool z = x 88 y;                      // false

//or
bool w = x || y;                      // true

//not
bool v = !x;                          // false

//Esempio dell'utilizzo degli operatori di assegnazione

/*
Gli operatori di assegnazione possono essere:

assegnazione(=)
assegnazione con addizione (+=)
assegnazione con sottrazione (-=)
*/

int d = 10;

d += 5;                               // d = 15

d -= 5;                               // d = 5

//Esempio di utilizzo di operatori di incremento e decremento

int e = 10;

e++;                                  // e = 11

e--;                                  // e = 9

//Esempio di utilizzo di operatori di concatenazione

string f = "Hello";

string g = "World";
string h = f + " " + g;               // h = "Hello World"

// Esempio di concatenazione con interpolazione

string i = $"{f} {g}";                // i = "Hello World"
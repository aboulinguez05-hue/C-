// Programme principal
Console.WriteLine("Entrez le premier nombre : ");  // Affiche un message
double nombre1 = double.Parse(Console.ReadLine()); // Lit et convertit en nombre

Console.WriteLine("Entrez le deuxième nombre : "); // Affiche un message
double nombre2 = double.Parse(Console.ReadLine()); // Lit et convertit en nombre

Console.WriteLine("Opération (+, -, *, /) : ");    // Affiche un message
string operation = Console.ReadLine();              // Lit l'opération (pas besoin de convertir)

double resultat = 0; // On crée une variable pour stocker le résultat

switch (operation) // On vérifie quelle opération l'utilisateur a choisie
{
    case "+":
        resultat = nombre1 + nombre2; // Addition
        break; // On sort du switch
    case "-":
        resultat = nombre1 - nombre2; // Soustraction
        break;
    case "*":
        resultat = nombre1 * nombre2; // Multiplication
        break;
    case "/":
        if (nombre2 == 0) // On vérifie qu'on ne divise pas par 0
        {
            Console.WriteLine("Erreur : division par zéro impossible !");
            return; // On arrête le programme
        }
        resultat = nombre1 / nombre2; // Division
        break;
    default:
        Console.WriteLine("Opération inconnue !"); // Si l'utilisateur tape autre chose
        return;
}

Console.WriteLine("Résultat : " + resultat); // Affiche le résultat
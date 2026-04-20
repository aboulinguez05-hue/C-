
Console.WriteLine("Entrez le premier nombre : ");  
double nombre1 = double.Parse(Console.ReadLine()); 

Console.WriteLine("Entrez le deuxième nombre : "); 
double nombre2 = double.Parse(Console.ReadLine()); 

Console.WriteLine("Opération (+, -, *, /) : ");   
string operation = Console.ReadLine();             

double resultat = 0; 

switch (operation) 
{
    case "+":
        resultat = nombre1 + nombre2; //hello
        break; 
    case "-":
        resultat = nombre1 - nombre2; 
        break;
    case "*":
        resultat = nombre1 * nombre2; 
        break;
    case "/":
        if (nombre2 == 0) 
        {
            Console.WriteLine("Erreur : division par zéro impossible !");
            return; 
        }
        resultat = nombre1 / nombre2; 
        break;
    default:
        Console.WriteLine("Opération inconnue !"); 
        return;
}

Console.WriteLine("Résultat : " + resultat); 
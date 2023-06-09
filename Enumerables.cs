namespace Enumerable;

using System;
using System.Collections.Generic;
using System.Linq;

public class Enumerables
{
    List<int> tableau;
    int n;
    public void Moyenne(int n){
        this.n = n;
        IEnumerable<int> inferiorEqual = tableau.Where(x => x <= this.n);
        double moyenne = inferiorEqual.Aggregate((x,y) => x + y) / Convert.ToDouble(inferiorEqual.Count());
        AfficheTableauFinal();
        Console.WriteLine("Average of the list of elements inferior or equal to n is equal to: " + moyenne);
    }
    public void AfficheTableau(){
        Console.WriteLine("Display the initial list of elements: ");
        for(int i = 0; i < tableau.Count; i++){
            Console.WriteLine(tableau[i]);
        }
    }
    public void AfficheTableauFinal(){
        Console.WriteLine("Display list of elements inferior or equal to n: ");
        IEnumerable<int> inferiorEqual = tableau.Where(x => x <= this.n);
        foreach(int v in inferiorEqual){
            Console.WriteLine(v);
        }
        string tableauFinal = "[" + string.Join(",", inferiorEqual) + "]";
        Console.WriteLine(tableauFinal);
    }
    public void Menu(){
        Console.Clear();
        Console.WriteLine("This program does an average calculation for any number inside a list inferior or equal to a variable n\nEnter that variable");
        string value = Console.ReadLine();
        AfficheTableau();
        Moyenne(Convert.ToInt32(value));
        Console.ReadLine();
        Menu();
    }
    public static void Main(string[] args)
    {
        Enumerables e = new Enumerables();
        e.tableau = new List<int> { 7, 1, 9, 4 };
        e.Menu();
    }
}
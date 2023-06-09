namespace Enumerable;

using System;
using System.Collections.Generic;
using System.Linq;

public class Enumerables
{
    List<int> tableau;
    public void Moyenne(int n){
        IEnumerable<int> inferiorEqual = tableau.Where(x => x <= n);
        int moyenne = tableau.Where(x => x <= n).Aggregate((x,y) => x + y) / inferiorEqual.Count();
        Console.WriteLine(moyenne);
    }
    public static void Main(string[] args)
    {
        Enumerables e = new Enumerables();
        e.tableau = new List<int> { 7, 1, 9, 4 };
        Console.Clear();
        Console.WriteLine("This program does an average calculation for any number inside a list inferior or equal to a variable n\nEnter that variable");
        string value = Console.ReadLine();
        e.Moyenne(Convert.ToInt32(value));
    }
}
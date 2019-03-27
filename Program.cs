using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        var catalog = new Catalog();
        catalog.Add(Divisor: 15, Output: "FizzBuzz");
        catalog.Add(Divisor: 3, Output: "Fizz");
        catalog.Add(Divisor: 5, Output: "Buzz");

        var counter = new Counter(Min: 1, Max: 100, Catalog: catalog);
        counter.Output();
        Console.ReadLine();
    }
}

internal class Counter
{
    private int min;
    private int max;
    private Catalog catalog;

    internal Counter(int Min, int Max, Catalog Catalog)
    {
        this.min = Min;
        this.max = Max;
        this.catalog = Catalog;
    }
    internal void Output()
    {
        for (int i = min; i <= max; i++)
        {
            Console.WriteLine(catalog.ToString(i));
        }
    }
}

internal class Catalog
{
    private List<Spec> specs;
    internal class Spec
    {
        internal int divisor;
        internal string output;
    }
    internal Catalog()
    {
        this.specs = new List<Spec>();
    }
    internal void Add(int Divisor, string Output)
    {
        this.specs.Add(new Spec() { divisor = Divisor, output = Output });
    }
    internal string ToString(int Number)
    {
        string outputstring = "";
        foreach (var x in specs)
        {
            outputstring += Number % x.divisor == 0 ? x.output : "";
        }
        return String.IsNullOrWhiteSpace(outputstring) ? Number.ToString() : outputstring;
    }
}

﻿class App
{
    static void Main()
    {
        Random random = new Random();
        //Lista
        List<int> Lista1 = new List<int>();
        for (int i = 0; i < 10; i++)
        {
            Lista1.Add(random.Next(10));
        }

        foreach (var item in Lista1)
        {
            Console.Write($"{item}, ");
        }
        Console.WriteLine();

        for (int i = 0; i < Lista1.Count; i++)
        {
            Console.Write($"{Lista1[i]}, ");
        }
        Console.WriteLine();

        Lista1.RemoveAt(5);        
        Console.WriteLine(string.Join(", ", Lista1));
        Lista1.Insert(0,123);
        Console.WriteLine(string.Join(", ", Lista1));

        List<object> Lista2 = new List<object>();
        Lista2.Add(1);
        Lista2.Add(2.5);
        Lista2.Add("tekst");
        Lista2.Add(true);

        foreach (var item in Lista2)
        {
            Console.Write($"{item}, ");
        }
        Console.WriteLine();

        //Krotka
        (int, float, string) Krotka1 = (1,3.14f,"tekst");
        Console.WriteLine($"{Krotka1.Item1}, {Krotka1.Item2}, {Krotka1.Item3}");
       
        var Krotka2 = (a:1, b:3.14f, c:"tekst");
        Console.WriteLine($"{Krotka2.a}, {Krotka2.b}, {Krotka2.c}");

        (int a, float b, string c) Krotka3 = (1, 3.14f, "tekst");
        Console.WriteLine($"{Krotka3.a}, {Krotka3.b}, {Krotka3.c}");
       
        var Krotka4 = (1,3.14,"tekst");
        Console.WriteLine($"{Krotka4.Item1}, {Krotka4.Item2}, {Krotka4.Item3}");

        var Krotka5 = new Tuple<int,float,string>(1,3.14f,"tekst");
        Console.WriteLine($"{Krotka5.Item1}, {Krotka5.Item2}");

        Console.WriteLine($"{Krotka1.GetType()}\n{Krotka2.GetType()}\n{Krotka3.GetType()}\n{Krotka4.GetType()}\n{Krotka5.GetType()}");

        Console.WriteLine($"{Krotka1 == Krotka2}");
        // Console.WriteLine($"{Krotka1 == Krotka5}"); //błąd

        //Zbiór
        HashSet<int> Zbior1 = new HashSet<int> {7, 2, 3, 4, 5};
        Zbior1.Add(5);
        Zbior1.Add(5);
        Zbior1.Add(6);
        Zbior1.Remove(3);

        foreach (var item in Zbior1)
        {
            Console.Write($"{item}, ");
        }
        Console.WriteLine();
    }

}
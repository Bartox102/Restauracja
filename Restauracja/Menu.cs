using System;
using System.Collections.Generic;

public class Menu
{
    public List<Danie> Dania { get; set; }

    public Menu()
    {
        Dania = new List<Danie>();
    }

    public void DodajDanie(Danie danie)
    {
        Dania.Add(danie);
    }

    public void WyswietlMenu()
    {
        foreach (var danie in Dania)
        {
            Console.WriteLine($"{danie.Nazwa}: ${danie.Cena} - {string.Join(", ", danie.Składniki)}");
        }
    }
}
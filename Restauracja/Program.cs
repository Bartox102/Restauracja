using System;

class Program
{
    static void Main(string[] args)
    {
        
        var menu = new Menu();
        menu.DodajDanie(new Danie { Nazwa = "Spagetti Carbonara", Cena = 25.99m, Składniki = new List<string> { "makaron", "bekon", "żółtka jajek", "ser" } });
        menu.DodajDanie(new Danie { Nazwa = "Pizza Margherita ", Cena = 25.99m, Składniki = new List<string> { "ciasto", "sos pomidorowy", "ser mozarella", "bazylia" } });
        menu.DodajDanie(new Danie { Nazwa = "Sałatka Cezar", Cena = 25.99m, Składniki = new List<string> { "mix sałat", "grzanki", "parmezan", "dressing" } });
        JSONDB.Zapisz(menu.Dania, "menu.json");

       
        var Menu = JSONDB.Dodaj("menu.json");
        foreach (var danie in Menu)
        {
            Console.WriteLine($"{danie.Nazwa}: {danie.Cena}zł - {string.Join(", ", danie.Składniki)}");
        }
    }
}
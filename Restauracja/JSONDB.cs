using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public class JSONDB
{
    public static List<Danie> Dodaj(string filename)
    {
        using (StreamReader file = File.OpenText(filename))
        {
            JsonSerializer serializer = new JsonSerializer();
            return (List<Danie>)serializer.Deserialize(file, typeof(List<Danie>));
        }
    }

    public static void Zapisz(List<Danie> data, string filename)
    {
        using (StreamWriter file = File.CreateText(filename))
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.Serialize(file, data);
        }
    }
}
using ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Tablice tablice = new Tablice();
        tablice.Powitanie();
        int[] tab = tablice.Stworz_Tablice();
        Console.Clear();
        Console.WriteLine("===============Oto Twoja Tablica===============");
        tablice.Wyswietl_Tablice(tab);
        tablice.Sortowanie(tab);
        Console.WriteLine("==========Oto Twoja Tablica Po Sortowaniu==========");
        tablice.Wyswietl_Tablice(tab);
        tablice.Przeszukiwanie(5, tab);
    }
}
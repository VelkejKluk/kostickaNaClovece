using System;

Console.WriteLine("Toto je hrací kostka! \nKlikněte na enter a kostička se začne točit! ");


while (true)
{
    Random randCisla = new Random();
    int cisla = randCisla.Next(1, 7);
    string input = Console.ReadLine().Trim();
    
    if (input == "")
    {
        Console.Clear();
        Console.WriteLine(cisla);

    }
    else
    {
        Console.WriteLine("Neplatná hodnota... \nzadejte znovu: ");
        break;
    }
}                           
       
// See https://aka.ms/new-console-template for more information

Random coin = new Random();

int flipResult = coin.Next(0,2);

string face = flipResult == 0 ? "Heads" : "Tails";

System.Console.WriteLine(face);
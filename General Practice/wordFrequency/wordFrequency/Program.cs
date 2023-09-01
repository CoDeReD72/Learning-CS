using System;

Console.WriteLine("Please enter a string of words: ");
string paragraph = Console.ReadLine();

Console.WriteLine("Please enter a word to search for: ");
string word = Console.ReadLine();

string[] words = paragraph.Split(' ');

int wordCount = 0;

foreach (string w in words){
    if(w == word){
        wordCount++;
    }
}

System.Console.WriteLine($"{word} was present a total of {wordCount} times!");
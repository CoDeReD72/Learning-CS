
string[] values = { "12.3", "45", "ABC", "11", "DEF" };

// If value is alpha-numeric add it to message
// If value is numeric add it to total

string msg = "";
decimal total = 0;

for(int i = 0; i < values.Length; i++)
{
    decimal result = 0;
    if(decimal.TryParse(values[i], out result)) // Returns true if value is numeric - thats why If is used
    {
        total += result;
    }
    else
    {
        msg += values[i];
    }
}

Console.WriteLine($"Message: {msg}");
Console.WriteLine($"Total: {total}");

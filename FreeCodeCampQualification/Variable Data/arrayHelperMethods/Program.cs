
//Sorting Arrays
string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (string pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

// Reversing Arrays
Console.WriteLine("\nReversed...");
Array.Reverse(pallets);
foreach (string pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}


// Clearing Arrays
Console.WriteLine("\nCleared...");
Array.Clear(pallets, 0, 2); // (array, starting index, number of elements to clear)
foreach (string pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

// Resizing Arrays
Console.WriteLine("\nResized...");
Array.Resize(ref pallets, 6); // Must pass the reference of the array, then the new size
pallets[4] = "C01";
pallets[5] = "C02";
foreach (string pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

//Pangram Reversal Excercise

System.Console.WriteLine("\n\n === Pangram Reversal ===");

string pangram = "The quick brown fox jumps over the lazy dog";

// Step 1
string[] message = pangram.Split(' ');

//Step 2
string[] newMessage = new string[message.Length];

// Step 3
for (int i = 0; i < message.Length; i++)
{
    char[] letters = message[i].ToCharArray();
    Array.Reverse(letters);
    newMessage[i] = new string(letters);
}

//Step 4
string result = String.Join(" ", newMessage);
Console.WriteLine(result);

// Order ID Stream
System.Console.WriteLine("\n\n === Order ID Stream ===c");

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] orders = orderStream.Split(',');

Array.Sort(orders);

foreach(string order in orders){
    if(order.Length != 4){
        Console.WriteLine($"{order}\t - \t Error");
    }
    else{
        Console.WriteLine(order);
        }
}
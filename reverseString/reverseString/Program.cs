static string reverseString(string s)
{
    string finalString = null;

    if (s != "")
    {
        for (int i = s.Length - 1; i >= 0; i--)
        {
            finalString += s[i];
        }


        return finalString;
    }

    else
    {
        return "";
    }

}

static void tests()
{
    // Test 1
    string input1 = "hello world";
    string expected1 = "dlrow olleh";
    Console.WriteLine("Test 1: Hello World");
    Console.WriteLine("\t - Should Equal: " + expected1);
    if (reverseString(input1) == expected1) { Console.WriteLine("[/] - Test Passed"); } else { Console.WriteLine("[X] - Test Failed"); }

    // Test 2 - Empty string
    string input2 = "";
    string expected2 = "";
    Console.WriteLine("Test 2: Empty string");
    Console.WriteLine("\t - Should Equal: " + expected2);
    if (reverseString(input2) == expected2) { Console.WriteLine("[/] - Test Passed"); } else { Console.WriteLine("[X] - Test Failed"); }

    // Test 3 - Single character
    string input3 = "a";
    string expected3 = "a";
    Console.WriteLine("Test 3: Single character");
    Console.WriteLine("\t - Should Equal: " + expected3);
    if (reverseString(input3) == expected3) { Console.WriteLine("[/] - Test Passed"); } else { Console.WriteLine("[X] - Test Failed"); }

    // Test 4 - Mixed case input
    string input4 = "ReVeRsE";
    string expected4 = "EsReVeR";
    Console.WriteLine("Test 4: Mixed case input");
    Console.WriteLine("\t - Should Equal: " + expected4);
    if (reverseString(input4) == expected4) { Console.WriteLine("[/] - Test Passed"); } else { Console.WriteLine("[X] - Test Failed"); }

    // Test 5 - String with spaces
    string input5 = "    hello    world    ";
    string expected5 = "    dlrow    olleh    ";
    Console.WriteLine("Test 5: String with spaces");
    Console.WriteLine("\t - Should Equal: " + expected5);
    if (reverseString(input5) == expected5) { Console.WriteLine("[/] - Test Passed"); } else { Console.WriteLine("[X] - Test Failed"); }

}

tests();


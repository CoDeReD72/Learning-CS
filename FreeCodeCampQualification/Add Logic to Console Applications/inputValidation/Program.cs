
void projectOne()
{
    string? readResult;
    string valueEntered = "";
    int numValue = 0;
    bool validNumber = false;

    Console.WriteLine("Enter an integer value between 5 and 10");

    do
    {
        readResult = Console.ReadLine();
        if (readResult != null)
        {
            valueEntered = readResult;
        }

        validNumber = int.TryParse(valueEntered, out numValue);

        if (validNumber == true)
        {
            if (numValue <= 5 || numValue >= 10)
            {
                validNumber = false;
                Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
            }
        }
        else
        {
            Console.WriteLine("Sorry, you entered an invalid number, please try again");
        }
    } while (validNumber == false);

    Console.WriteLine($"Your input value ({numValue}) has been accepted.");

    readResult = Console.ReadLine();
}

void projectTwo()
{
    string? readResult;
    string roleName = "";
    bool validEntry = false;

    do
    {
        Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
        readResult = Console.ReadLine();
        if (readResult != null)
        {
            roleName = readResult.Trim();
        }

        if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user")
        {
            validEntry = true;
        }
        else
        {
            Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
        }

    } while (validEntry == false);

    Console.WriteLine($"Your input value ({roleName}) has been accepted.");
    readResult = Console.ReadLine();
}
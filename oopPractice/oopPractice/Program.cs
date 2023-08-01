using System;
using oopPractice;

class Program
{
    static void Main()
    {
        runTests(); //application code Goes here
    }

    private double returnDoubleBalance(int intBalance)
    {
        return intBalance / 100;
    }


    public static void runTests()
    {
        TestBankAccountDeposit();
        TestBankAccountWithdraw();
        TestBankAccountGetBalance();
        // Add more test methods here as needed
    }

    private static void DisplayTestResult(string testName, string explanation, int expected, int actual)
    {
        Console.WriteLine($"=== {testName} ===");
        Console.WriteLine($"Test: {explanation}");
        Console.ForegroundColor = (expected == actual) ? ConsoleColor.Green : ConsoleColor.Red;
        Console.WriteLine($"Expected: \t{expected}");
        Console.WriteLine($"Actual: \t{actual}");
        Console.ResetColor();
        Console.WriteLine();
    }


    private static void TestBankAccountDeposit()
    {
        Console.WriteLine("Testing BankAccount Deposit method...");

        // Test case 1: Deposit 20000 pence (200 pounds) to an account with an initial balance of 50000 pence (500 pounds)
        BankAccount account1 = new BankAccount("John Doe", 50000);
        int depositAmount1 = 20000;
        account1.deposit(depositAmount1);
        int expectedBalance1 = 70000; // 700 pounds
        int actualBalance1 = account1.getAccountBalance();
        DisplayTestResult("Deposit Test 1", "Deposit 20000 pence (200 pounds) to an account with an initial balance of 50000 pence (500 pounds)", expectedBalance1, actualBalance1);

        // Test case 2: Deposit 5000 pence (50 pounds) to an account with an initial balance of 0 pence (0 pounds)
        BankAccount account2 = new BankAccount("Jane Smith", 0);
        int depositAmount2 = 5000;
        account2.deposit(depositAmount2);
        int expectedBalance2 = 5000; // 50 pounds
        int actualBalance2 = account2.getAccountBalance();
        DisplayTestResult("Deposit Test 2", "Deposit 5000 pence (50 pounds) to an account with an initial balance of 0 pence (0 pounds)", expectedBalance2, actualBalance2);

        // Add more test cases as needed
    }

    private static void TestBankAccountWithdraw()
    {
        Console.WriteLine("Testing BankAccount Withdraw method...");

        // Test case 1: Withdraw 20000 pence (200 pounds) from an account with an initial balance of 50000 pence (500 pounds)
        BankAccount account1 = new BankAccount("John Doe", 50000);
        int withdrawalAmount1 = 20000;
        bool withdrawResult1 = account1.withdraw(withdrawalAmount1);
        int expectedBalance1 = 30000; // 300 pounds
        int actualBalance1 = account1.getAccountBalance();
        DisplayTestResult("Withdraw Test 1", "Withdraw 20000 pence (200 pounds) from an account with an initial balance of 50000 pence (500 pounds)", expectedBalance1, actualBalance1);

        // Test case 2: Withdraw 60000 pence (600 pounds) from an account with an initial balance of 50000 pence (500 pounds)
        BankAccount account2 = new BankAccount("Jane Smith", 50000);
        int withdrawalAmount2 = 60000;
        bool withdrawResult2 = account2.withdraw(withdrawalAmount2);
        int expectedBalance2 = 50000; // Withdrawal should fail due to insufficient balance
        int actualBalance2 = account2.getAccountBalance();
        DisplayTestResult("Withdraw Test 2", "Withdraw 60000 pence (600 pounds) from an account with an initial balance of 50000 pence (500 pounds)", expectedBalance2, actualBalance2);

        // Add more test cases as needed
    }

    private static void TestBankAccountGetBalance()
    {
        Console.WriteLine("Testing BankAccount GetBalance method...");

        // Test case 1: Get balance from an account with an initial balance of 100000 pence (1000 pounds)
        BankAccount account1 = new BankAccount("John Doe", 100000);
        int expectedBalance1 = 100000; // 1000 pounds
        int actualBalance1 = account1.getAccountBalance();
        DisplayTestResult("GetBalance Test 1", "Get balance from an account with an initial balance of 100000 pence (1000 pounds)", expectedBalance1, actualBalance1);

        // Test case 2: Get balance from an account with an initial balance of 0 pence (0 pounds)
        BankAccount account2 = new BankAccount("Jane Smith", 0);
        int expectedBalance2 = 0; // 0 pounds
        int actualBalance2 = account2.getAccountBalance();
        DisplayTestResult("GetBalance Test 2", "Get balance from an account with an initial balance of 0 pence (0 pounds)", expectedBalance2, actualBalance2);

    }
}
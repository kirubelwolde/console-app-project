using System;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using System.Threading;




public enum SecureMenu
{

    [Description("Check balance")]
    CheckBalance = 1,

    [Description("Place Deposit")]
    PlaceDeposit = 2,

    [Description("Make Withdrawal")]
    MakeWithdrawal = 3,

    [Description("Third Party Transfer")]
    ThirdPartyTransfer = 4,

    [Description("Transaction")]
    ViewTransaction = 5,

    [Description("Logout")]
    Logout = 6
}

public static class ATMScreen
{
    internal static string cur = "Birr ";

    #region ATM UI Forms
    public static VMThirdPartyTransfer ThirdPartyTransferForm()
    {
        var vMThirdPartyTransfer = new VMThirdPartyTransfer();


        
        vMThirdPartyTransfer.RecipientBankAccountNumber = Utility.GetValidIntInputAmt("recipient's account number");

    
        vMThirdPartyTransfer.TransferAmount = Utility.GetValidDecimalInputAmt("amount");

       
        vMThirdPartyTransfer.RecipientBankAccountName = Utility.GetRawInput("recipient's account name");
       
        return vMThirdPartyTransfer;
    }
    #endregion

    #region UIOutput - ATM Menu

    public static void ShowMenu1()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Black;

        Console.WriteLine("              ------------------------                           ");
        Console.WriteLine("|              ***** sky ATM Main Menu *****                    |");
        Console.WriteLine("|                                                               |");
        Console.WriteLine("|                   1. Skybank                                  |");
        Console.WriteLine("|                   2. Skybank                                  |");
        Console.WriteLine("|                                                               |");
        Console.WriteLine("|------- Save your money and the sky's the limit ---------------|");
        Console.WriteLine("|              ------------------------                          ");
    }

    public static void ShowMenu2()
    {
        Console.Clear();
        Console.WriteLine(" ---------------------------");
        Console.WriteLine("|              ***** sky bank *****                                           |");
        Console.WriteLine("|                                                                             |");
        Console.WriteLine("|              1. Balance Status                                              |");
        Console.WriteLine("|              2. Cash Deposit                                                |");
        Console.WriteLine("|              3. Withdrawal                                                  |");
        Console.WriteLine("|              4. Account Transfer                                            |");
        Console.WriteLine("|              5. Transactions                                                |");
        Console.WriteLine("|              6. Logout                                                      |");
        Console.WriteLine("|                                                                             |");
        Console.WriteLine(" -------      Save your money and the sky's the limit     ----------s           ");
        Console.WriteLine("|                                                                             |");
        System.Console.WriteLine("for more information please dial *901#  or go to the nearest sky branch");

    }
    #endregion






}
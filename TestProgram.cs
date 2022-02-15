

using SkybankATMSystem;

class TestProgram
{
    static void Main()
    {
        SkybankATM atm = new SkybankATM();
        atm.Initialization();
        atm.Execute();
    }
}


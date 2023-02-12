namespace ConsoleAppTestClases;

public class DigitWalletsManager
{
    private DigitWallet[] _digitWallets;

    private Random _random;
    private int _globalWalletId;
    private string[] _globalCurrencies;

    public DigitWalletsManager(int countWallets)
    {
        _digitWallets = new DigitWallet[countWallets];

        _random = new Random();
        _globalWalletId = 0;
        _globalCurrencies = new[] { "RU", "EN", "CH" };
    }

    public void GenerateWallets()
    {
        for (int i = 0; i < _digitWallets.Length; i++)
        {
            _globalWalletId++;
            int id = _globalWalletId;
            string number = "ABC" + _random.Next(100, 999 + 1);
            string currency = _globalCurrencies[_random.Next(0, _globalCurrencies.Length)];
            decimal money = _random.Next(0, 1000);

            _digitWallets[i] = new DigitWallet(
                id,
                number,
                currency,
                money
            );
        }
    }

    public void PrintWallets()
    {
        for (int i = 0; i < _digitWallets.Length; i++)
        {
            Console.WriteLine(_digitWallets[i]);
        }
    }
}
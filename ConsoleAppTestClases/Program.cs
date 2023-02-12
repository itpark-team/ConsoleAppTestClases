using ConsoleAppTestClases;

// DigitWallet digitWallet = new DigitWallet(1, "ABC823", "RU", 500);
// digitWallet.Money = 100;
// Console.WriteLine(digitWallet.Money);
//
// digitWallet.AddMoney(345);
//
// Console.WriteLine(digitWallet.Money);
//
// Console.WriteLine(digitWallet);

DigitWalletsManager digitWalletsManager = new DigitWalletsManager(10);
digitWalletsManager.GenerateWallets();
digitWalletsManager.PrintWallets();
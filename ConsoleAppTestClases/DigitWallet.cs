using System.Text.Json;

namespace ConsoleAppTestClases;

public class DigitWallet
{
    private int _id;
    private string _number;
    private string _currency;
    private decimal _money;

    public DigitWallet(int id, string number, string currency, decimal money)
    {
        _id = id;
        _number = number;
        _currency = currency;
        _money = money;
    }

    public void AddMoney(decimal money)
    {
        if (money < 0 || money > 10000)
        {
            throw new Exception("money out of range from 0 to 10000");
        }

        _money += money;
    }

    public decimal Money
    {
        set
        {
            if (value < 0 || value > 10000)
            {
                throw new Exception("money out of range from 0 to 10000");
            }

            _money = value;
        }
        get { return _money; }
    }

    public override string ToString()
    {
        return $"id: {_id} number: {_number} currency: {_currency} money: {_money}";
    }
}
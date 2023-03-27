namespace linq.Data
{
    public class Transaction
    {
        private readonly Trader _trader;
        private readonly int _year;
        private readonly int _value;

        public Transaction(Trader trader, int year, int value)
        {
            _trader = trader;
            _year = year;
            _value = value;
        }
    }
}
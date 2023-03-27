using linq.data;

namespace linq.Data
{
    public class Trader
    {
        private readonly string _name;
        private readonly ECities _city;
        public Trader(string name, ECities city)
        {
            this._name = name;
            this._city = city;
        }
    }
}
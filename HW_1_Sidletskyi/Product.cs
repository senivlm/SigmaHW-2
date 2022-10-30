namespace HW_1_Sidletskyi
{
    public class Product
    {
        public string? Name { get; private set; }
        private decimal price;

        public decimal Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                {
                    price = value;
                }
            }
        }

        private double weight;

        public double Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
            }
        }
        public Product(string? name, decimal price, double weight)
        {
            Name = name;
            Price = price;
            Weight = weight;
        }

        public override string ToString()
        {
            return $"Product name: '{Name}'\n" +
                $"'{Name}' price: '${Price}'\n" +
                $"'{Name}' weight: '{Weight}' kg";
        }
    }
}

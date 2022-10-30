namespace HW_1_Sidletskyi
{
    public class Buy
    {
        private Product product;
        private int productCount;

        public int ProductCount
        {
            get
            {
                return productCount;
            }
            set
            {
                if (value > 0)
                {
                    productCount = value;
                }
            }
        }

        public decimal ProductsPrice
        {
            get
            {
                return product.Price * ProductCount;
            }
        }

        public Buy(Product product, int count)
        {
            this.product = product;
            ProductCount = count;
        }

        public override string ToString()
        {
            return $"'{product.Name}' count: '{ProductCount} pcs'\n" +
                $"Total '{product.Name}' price: '${ProductsPrice}'";
        }
    }
}

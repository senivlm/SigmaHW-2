namespace HW_1_Sidletskyi
{// Чек має бути формою звітності про покупку, яка може включати кілька продуктів.
    public class Check
    {
        public string CreateCheck(Product product, Buy buy)
        {
            return $"\tCheck\n" +
                $"{product}\n" +
                $"{buy}";
        }
        public override string ToString()
        {
            return "This class show shoping сheck";
        }
    }
}

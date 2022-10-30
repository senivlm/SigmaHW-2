namespace HW_1_Sidletskyi
{
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

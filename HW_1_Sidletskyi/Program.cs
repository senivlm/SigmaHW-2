using HW_1_Sidletskyi;
// Вітаю. Все доступно.
Product product = new Product("phone", 399.99m, 0.230);

Buy cart = new Buy(product, 3);

Check check = new Check();
// Дублюється інформація про продукт. Він вже є в cart
Console.WriteLine(check.CreateCheck(product, cart));
Console.WriteLine("-------------------------------------------");

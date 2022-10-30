using HW_1_Sidletskyi;

Product product = new Product("phone", 399.99m, 0.230);

Buy cart = new Buy(product, 3);

Check check = new Check();
Console.WriteLine(check.CreateCheck(product, cart));
Console.WriteLine("-------------------------------------------");

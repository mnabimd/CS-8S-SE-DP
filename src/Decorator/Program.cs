using Decorator.Beverages;
using Decorator.Beverages.Contracts;
using Decorator.Condiments;

IBeverage coffee = new Coffee();

// Check regular price
Console.WriteLine(coffee.Cost());

// Add new condiments to the coffee (flavors)

coffee = new Mocha(new Coffee());

// Price is now higher due to condiment/flavor addition
Console.WriteLine(coffee.Cost());


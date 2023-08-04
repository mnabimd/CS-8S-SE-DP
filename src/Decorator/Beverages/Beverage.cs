namespace Decorator.Beverages;

using Decorator.Beverages.Contracts;

abstract class Beverage : IBeverage {
    protected string description = "Unknown description";

    public abstract double Cost(); 
    public string GetDescription() {
        return description;
    }
}
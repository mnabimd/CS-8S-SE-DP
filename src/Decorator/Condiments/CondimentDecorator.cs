namespace Decorator.Condiments;
using Decorator.Beverages.Contracts;
using Decorator.Beverages;

abstract class CondimentDecorator : IBeverage {
    // Protected instance of beverage
    protected Beverage? beverage;
    public abstract double Cost();
    public abstract string GetDescription();
}
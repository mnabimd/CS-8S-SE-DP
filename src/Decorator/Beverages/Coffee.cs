namespace Decorator.Beverages;

sealed class Coffee : Beverage {

    public Coffee() {
        description = "Coffee";
    }

    public override double Cost() {
        return 0.50;
    }
}
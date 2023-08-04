namespace Decorator.Beverages;

sealed class Milk : Beverage {

     public Milk() {
        description = "Milky";
    }

    public override double Cost() {
        return 0.20;
    }
}
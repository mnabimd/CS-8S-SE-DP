namespace Decorator.Condiments;
using Decorator.Beverages;

sealed class Mocha : CondimentDecorator {
    public Mocha(Beverage payload) {
        this.beverage = payload;
    }

    public override string GetDescription() {
        if(beverage is null) throw new NullReferenceException();
        return beverage.GetDescription() + ", Mocha";
    }

    public override double Cost() {
        if(beverage is null) throw new NullReferenceException();
        return beverage.Cost() + 0.15;
    }
}
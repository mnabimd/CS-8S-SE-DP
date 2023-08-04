sealed class FactoryPizza {
    public IPizza createPizza(string type) {
        if (type is "cheese") {
            return new CheesePizza();
        } else if (type is "afghani") {
            return new AfghaniPizza();
        } 
        // Default
        return new CheesePizza();
        
    }
}
namespace Adapter.Duck;

sealed class MallarDuck : IDuck {
    public void Quack() {
        Console.WriteLine("Duck is quacking...");
    }

    public void Fly() {
        Console.WriteLine("Duck is flying...");
    }
}
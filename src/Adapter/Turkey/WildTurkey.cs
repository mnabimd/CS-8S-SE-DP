namespace Adapter.Turkey;

sealed class WildTurkey : ITurkey {
    public void Gobble() {
        Console.WriteLine("Turkey gobbling...");
    }

    public void Fly() {
        Console.WriteLine("Turkey flying...");
    }
} 
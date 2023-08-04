using Adapter.Duck;
using Adapter.Turkey;

namespace Adapter;


// To make a turkey behave like a Duck, we create its Adapter to adapt the Duck methods and behaviors. 
sealed class TurkeyAdapter : IDuck {
    private ITurkey _turkey;

    public TurkeyAdapter(ITurkey turkey) {
        _turkey = turkey;
    }
    public void Quack() {
        _turkey.Gobble();
    }
    public void Fly() {
        for (int i = 0; i < 5; i++) {
            _turkey.Fly();
        }
    }
}
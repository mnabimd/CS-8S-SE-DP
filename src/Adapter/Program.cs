using Adapter;
using Adapter.Turkey;
using Adapter.Duck;

// Create a turkey
ITurkey turkey = new WildTurkey();

// Convert it to Duck
IDuck adaptedTurkey = new TurkeyAdapter(turkey);

// Test it out
adaptedTurkey.Quack();
adaptedTurkey.Fly();
class StateB : IState {
    public void Handle(Context context) {
        Console.WriteLine("State B: Handling request");

        // Change/Update the state
        context.SetState(new StateA());
    }
}
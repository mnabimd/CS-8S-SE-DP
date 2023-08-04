class StateA : IState {
    public void Handle(Context context) {
        Console.WriteLine("State A: Handling request");

        // Change/Update the state
        context.SetState(new StateB());
    }
}
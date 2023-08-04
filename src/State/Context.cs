class Context {
    private IState state;

    public Context() {
        state = new StateA();
    }
    
    public void SetState(IState newState) {
        state = newState;
    }

    public void Request() {
        state.Handle(this);
    }
}
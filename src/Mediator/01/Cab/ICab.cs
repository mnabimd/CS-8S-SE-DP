namespace Mediator._01;

public interface ICab {
    string Name { get; }
    int CurrentLocation { get; }
    bool IsFree { get; }

    // Params: Name => PassengerName, Address => PassengerAddress
    void Assign(string name, string address);
}
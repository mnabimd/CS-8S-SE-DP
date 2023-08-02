namespace Facade;

public sealed class Socket {
    private int id;
    private string protocol;

    public Socket(string theProtocol) {
        protocol = theProtocol;
    }

    public void BuildSocket() {
        Console.WriteLine("building socket...");
    }
}
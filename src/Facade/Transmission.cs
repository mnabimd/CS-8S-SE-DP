namespace Facade;

public sealed class Transmission {
    private int id;
    private string protocol;

    public Transmission(string theProtocol) {
        protocol = theProtocol;
    }

    public void SendTransmission() {
        Console.WriteLine("Sending transmisison");
        Console.WriteLine("Done");
    }
}
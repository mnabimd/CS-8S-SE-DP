namespace Facade;

public sealed class Pocket {
    private long id;
    private string ip;

    public Pocket(string theIp) {
        ip = theIp;
    }

    public void BuildPacket() {
        Console.WriteLine("Building packet");
    }
};
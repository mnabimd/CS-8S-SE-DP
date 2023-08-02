namespace Facade;

public class FacadeNetwork {
    private Pocket pocket;
    private Socket socket;
    private Transmission transmission;

    public FacadeNetwork(string ip, string protocol) {
        this.pocket = new Pocket(ip);
        this.socket = new Socket(protocol);
        this.transmission = new Transmission(protocol);
    }

    public void BuildNetworkLayer() {
        pocket.BuildPacket();
        socket.BuildSocket();
    }

    // user only needs to see this function
    public void SendPacketOverNetwork() {
        BuildNetworkLayer();
        transmission.SendTransmission();
    }


}
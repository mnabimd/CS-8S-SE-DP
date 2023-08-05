namespace BuilderPattern._1;

public class UrlBuilder {
    private string? _protocol;
    private string? _hostname;
    private string? _port;

    public UrlBuilder() {}

    public string getUrl()
    {
        return _protocol?.ToString() +
                "://" +
               _hostname?.ToString() +
               (_port is not null ? ":" : "") +
               _port?.ToString();
    }

    // Nested builder class
    public class Builder {
        private readonly UrlBuilder url;
        
        public Builder() {
            url = new();
        }

        public Builder WithProtocol(string protocol) {
            url._protocol = protocol;
            return this;
        }

        public Builder WithHostname(string hostname) {
            url._hostname = hostname;
            return this;
        }

        public Builder WithPort(string port) {
            url._port = port;
            return this;
        }

        public UrlBuilder Build() {
            return url;
        }
    }
}
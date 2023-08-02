namespace BuilderPattern._2;

public class UrlBuilder2 {
    private string? protocol;
    private string? hostname;
    private int? port;

    public UrlBuilder2() {}

    public string getUrl() => protocol?.ToString() + "://" + hostname?.ToString() + ":" + port?.ToString();

    public class Builder {
        private readonly UrlBuilder2 url;

        public Builder() {
            url = new UrlBuilder2();
        }

        public Builder WithProtocol(string payload) {
            url.protocol = payload;
            return this;
        }

        public Builder WithHostname(string payload) {
            url.hostname = payload;
            return this;
        }

        public Builder WithPort(int payload) {
            url.port = payload;
            return this;
        }

        public UrlBuilder2 Build() => url;
    }
}
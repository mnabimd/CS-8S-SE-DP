using BuilderPattern._2;

var google = new UrlBuilder2.Builder()
                            .WithProtocol("https")
                            .WithHostname("www.google.com")
                            .WithPort(5000)
                            .Build();


Console.WriteLine(google.getUrl());
namespace IteratorComposition._01;

public sealed class MenuItem {
    public string? name;
    public string? description;
    public double? price;

    public void SetItem(string theName, string theDescription, double thePrice) {
        name = theName;
        description = theDescription;
        price = thePrice;
    }

    public string GetItem() => $"Name: {name}, Description: {description}, Price: {price}"; 
}
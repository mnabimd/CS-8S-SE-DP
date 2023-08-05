using System.Collections;

namespace IteratorComposition._01;

public class DinnerMenu : IEnumerator<MenuItem>, IEnumerable<MenuItem> {
       // represents the maximum number of items the menu can hold
    int maxItems = 0;
    // keeps track of the current number of items in the menu,
    int numberOfItems = 0;
    //  represents the current position of the iterator.
    int position = -1;
    // an array that stores the menu items
    MenuItem[] menuItems;

    // The constructor
    public DinnerMenu(int payload) {
        // Set max limit
        this.maxItems = payload;
        // Init array with max limit
        menuItems = new MenuItem[payload];
    }

    public void AddItem(string name, string description, double price) {
        // Create new menu item and set
        MenuItem newMenuItem = new();
        newMenuItem.SetItem(name, description, price);

        // check validation
        if (numberOfItems >= maxItems) {
            Console.WriteLine("Menu is full");
        } else {
            // add newly added menuItem to the 
            menuItems[numberOfItems] = newMenuItem;
            numberOfItems++;
        }
    }

    // Implementation of IEnumeratable
    public MenuItem Current => new MenuItem() {
        name = menuItems[position].name,
        description = menuItems[position].description,
        price = menuItems[position].price,
    };

    // Let the IEnumerator know our current enumeratable item
    object IEnumerator.Current => Current;

    public bool MoveNext() {
        if (position >= menuItems.Length - 1) {
            return false;
        }
        position++;
        return true;
    }

    public void Reset() {
        position = 0;
    }

    public IEnumerator<MenuItem> GetEnumerator() => this;
    // Now, lets make it enumerable
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public void Dispose(){

    }

}
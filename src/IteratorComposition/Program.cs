using IteratorComposition._01;

DinnerMenu menu = new(6);

menu.AddItem("Pizza", "A good fast food", 12.0);
menu.AddItem("Burger", "A good fast food", 22.0);
menu.AddItem("Meat", "A good fast food", 142.0);
menu.AddItem("Nuts", "A good fast food", 12.5);
menu.AddItem("Biryani", "A good fast food", 13.0);
menu.AddItem("Rice", "A good fast food", 15.23);

foreach (var item in menu)
{
    Console.WriteLine(item.GetItem());
}
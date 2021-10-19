using c_Players_Guide_Inventory;

var playerBackPack = new Pack(10, 10, 10);

List<InventoryItem> items = new List<InventoryItem>();
items.Add(new Arrow());
items.Add(new Bow());
items.Add(new Food());
items.Add(new Rope());
items.Add(new Sword());
items.Add(new Water());

while (true)
{

    Console.Clear();
    Console.WriteLine("Hey add items to your backpack");
    var index = 1;
    foreach (var item in items)
    {
        Console.WriteLine($"{index}-- {item.ToString()}");
        index++;
    }
    Console.WriteLine("\nItems in your bag");
    Console.WriteLine(playerBackPack.ToString());

    int playerInput = int.Parse(Console.ReadLine());

    //playerBackPack.AddOne(items[playerInput]);
    //Console.WriteLine(playerBackPack.CurentWeight);

    if (playerBackPack.AddOne(items[playerInput - 1]) == true)
    {
        Console.WriteLine($"You added {items[playerInput - 1].ToString()} to your bag");
    }
    else
    {
        Console.WriteLine("you can't add that");
        Console.ReadLine();
    }
}
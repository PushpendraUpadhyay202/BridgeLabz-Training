
abstract class WarehouseItem
{
    public string Name { get; set; }

    protected WarehouseItem(string name)
    {
        Name = name;
    }

    public abstract void Display();
}


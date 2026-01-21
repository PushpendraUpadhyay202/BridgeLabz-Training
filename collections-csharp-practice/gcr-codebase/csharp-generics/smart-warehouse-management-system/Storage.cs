using System;
using System.Collections.Generic;


class Storage<T> where T : WarehouseItem
{
    private List<T> items = new List<T>();

    public void AddItem(T item)
    {
        items.Add(item);
    }

    public List<T> GetAllItems()
    {
        return items;
    }
}

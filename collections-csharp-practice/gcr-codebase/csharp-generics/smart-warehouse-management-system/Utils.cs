using System;
using System.Collections.Generic;

static class Utils
{
    public static void DisplayItems<T>(List<T> items) where T : WarehouseItem
    {
        foreach (var item in items)
        {
            item.Display();
        }
    }
}


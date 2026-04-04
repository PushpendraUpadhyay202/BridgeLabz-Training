using System;
using System.Collections;

class SupressWarnings
{
    static void Main()
    {
#pragma warning disable CS0618
        ArrayList list = new ArrayList();
        list.Add(1);
        list.Add("text");
#pragma warning restore CS0618

        Console.WriteLine(list.Count);
    }
}

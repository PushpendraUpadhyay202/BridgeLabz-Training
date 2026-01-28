using System;

class LegacyAPI
{
    [Obsolete]
    public void OldFeature()
    {
        Console.WriteLine("Old feature");
    }

    public void NewFeature()
    {
        Console.WriteLine("New feature");
    }
}

class LegacyAPIObsolete
{
    static void Main()
    {
        LegacyAPI api = new LegacyAPI();
        api.OldFeature();
        api.NewFeature();
    }
}

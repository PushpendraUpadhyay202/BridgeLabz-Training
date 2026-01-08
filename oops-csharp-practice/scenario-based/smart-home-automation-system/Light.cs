internal class Light: Appliance
{
    public Light(string applianceBrand, string applianceModel, int appliancePowerRating, string energyEfficiency, string type) : base(applianceBrand, applianceModel, appliancePowerRating, energyEfficiency, type) { }

    public override void TurnOn()
    {
        if (!Status)
        {
            Console.WriteLine("Truned On the Light\n");
            Status = true;
        }
        else
            Console.WriteLine("Light is already On\n");
    }

    public override void TurnOff()
    {
        if (Status)
        {
            Console.WriteLine("Turned Off the Light\n");
            Status = false;
        }
        else
            Console.WriteLine("Light is already Off\n");
    }
}
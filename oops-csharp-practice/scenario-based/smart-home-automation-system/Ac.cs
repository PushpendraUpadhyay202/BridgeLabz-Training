internal class AC: Appliance
{
    public AC(string applianceBrand, string applianceModel, int appliancePowerRating, string energyEfficiency, string type) : base(applianceBrand, applianceModel, appliancePowerRating, energyEfficiency, type) { }

    public override void TurnOn()
    {
        if (!Status)
        {
            Console.WriteLine("Truned On the AC\n");
            Status = true;
        }
        else
            Console.WriteLine("AC is already On\n");
    }

    public override void TurnOff()
    {
        if (Status)
        {
            Console.WriteLine("Turned Off the AC\n");
            Status = false;
        }
        else
            Console.WriteLine("AC is already Off\n");
    }
}
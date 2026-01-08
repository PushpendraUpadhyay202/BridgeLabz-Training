internal class Fan: Appliance
{
    public Fan(string applianceBrand, string applianceModel, int appliancePowerRating, string energyEfficiency, string type) : base(applianceBrand, applianceModel, appliancePowerRating, energyEfficiency, type) { }

    public override void TurnOn()
    {
        if (!Status)
        {
            Console.WriteLine("Truned On the Fan\n");
            Status = true;
        }
        else
            Console.WriteLine("Fan is already On\n");
    }

    public override void TurnOff()
    {
        if (Status)
        {
            Console.WriteLine("Turned Off the Fan\n");
            Status = false;
        }
        else
            Console.WriteLine("Fan is already Off\n");
    }
}
internal abstract class Appliance: IControllable
{
    protected string ApplianceBrand;
    protected string ApplianceModel;
    protected int AppliancePowerRating;
    protected string ApplianceEnergyEfficiency;
    protected string ApplianceType;
    protected bool Status;

    protected Appliance(string applianceBrand, string applianceModel, int appliancePowerRating, string energyEfficiency, string type)
    {
        ApplianceBrand = applianceBrand;
        ApplianceModel = applianceModel;
        AppliancePowerRating = appliancePowerRating;
        ApplianceEnergyEfficiency = energyEfficiency;
        ApplianceType = type;
        Status = false; // Initially an appliance is off
    }

    public abstract void TurnOn();
    public abstract void TurnOff();

    public string GetApplianceBrand()
    {
        return ApplianceBrand;
    }
    public string GetApplianceModel()
    {
        return ApplianceModel;
    }
    public int GetAppliancePowerRating()
    {
        return AppliancePowerRating; 
    }
    public string GetApplianceEnergyEfficiency()
    {
        return ApplianceEnergyEfficiency;
    }
    public string GetApplianceType()
    {
        return ApplianceType;
    }

    public override string ToString()
    {
        return $"\nAppliance Brand: {ApplianceBrand}\nAppliance Model: {ApplianceModel}\nAppliance Power Rating: {AppliancePowerRating}\nAppliance Energy Efficiency: {ApplianceEnergyEfficiency}\nAppliance Type: {ApplianceType}\n";
    }
}
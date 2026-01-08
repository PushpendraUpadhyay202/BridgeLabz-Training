internal class ApplianceMain
{
    public static Appliance[] Appliances;

    static ApplianceMain()
    {
        Appliances = new Appliance[3];
        Appliances[0] = new Light("Phillips", "LED-Bright-9W", 9, "A++", "Light");
        Appliances[1] = new Fan("Orient", "EcoTech-1200", 75, "5-Star", "Fan");
        Appliances[2] = new AC("LG", "DualCool X18", 1500, "5-Star Inverter", "AC");
    }

    static void Main(string[] args)
    {
        ApplianceMenu applianceMenu = new ApplianceMenu();
        applianceMenu.HomeOwnerChoices();
    }
}
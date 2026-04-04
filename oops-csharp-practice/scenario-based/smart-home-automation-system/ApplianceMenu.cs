sealed class ApplianceMenu
{
    private Appliance appliance;
    public void HomeOwnerChoices()
    {
        Console.WriteLine("\n==== WELCOME TO THE SMART HOME AUTOMATION SYSTEM ====\n");
        int ownerChoice;
        do
        {
            Console.WriteLine("1. Turn on light");
            Console.WriteLine("2. Turn off light");
            Console.WriteLine("3. Turn on Fan");
            Console.WriteLine("4. Turn off Fan");
            Console.WriteLine("5. Turn on AC");
            Console.WriteLine("6. Turn off AC");
            Console.WriteLine("0. Exit");
            Console.Write("Please enter your choice: ");
            ownerChoice = int.Parse(Console.ReadLine());

            switch (ownerChoice)
            {
                case 1:
                    // Light is stored at index 0
                    // Fan is stored at index 1
                    // AC is stored at index 2
                    appliance = ApplianceMain.Appliances[0];
                    appliance.TurnOn();
                    break;

                case 2:
                    appliance = ApplianceMain.Appliances[0];
                    appliance.TurnOff();
                    break;

                case 3:
                    appliance = ApplianceMain.Appliances[1];
                    appliance.TurnOn();
                    break;

                case 4:
                    appliance = ApplianceMain.Appliances[1];
                    appliance.TurnOff();
                    break;

                case 5:
                    appliance = ApplianceMain.Appliances[2];
                    appliance.TurnOn();
                    break;

                case 6:
                    appliance = ApplianceMain.Appliances[2];
                    appliance.TurnOff();
                    break;
            }

        } while (ownerChoice != 0);
    }
}
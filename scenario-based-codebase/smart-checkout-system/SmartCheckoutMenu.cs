using System;

class SmartCheckoutMenu
{
    private ISmartCheckout smartMenu;

    public void ShowCheckoutMenu()
    {
        smartMenu = new SmartCheckoutUtility();
        bool running = true;

        while (running)
        {
            Console.WriteLine("1. Add Customer");
            Console.WriteLine("2. Remove Customer");
            Console.WriteLine("3. Process Next Customer");
            Console.WriteLine("4. Show Queue");
            Console.WriteLine("5. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    smartMenu.AddCustomer();
                    break;
                case 2:
                    smartMenu.RemoveCustomer();
                    break;
                case 3:
                    smartMenu.ProcessNextCustomer();
                    break;
                case 4:
                    smartMenu.ShowQueue();
                    break;
                case 5:
                    running = false;
                    break;
            }
        }
    }
}

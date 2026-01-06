using System;
internal class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.StartApplication();
    }
    private void StartApplication()
    {
        AdminImp admin = new AdminImp();
        Console.WriteLine("\n=== Welcome to the Hospital ===\n");
        if (admin.AuthenticateAdmin())
        {
            while (true)
            {
                Console.WriteLine("\n== ADMIN MENU ===\n");
                Console.WriteLine("1. Recruit Doctor.");
                Console.WriteLine("2. Admit Patient");
                Console.WriteLine("3. Generate Bill.");
                Console.WriteLine("4. Display bill with bill Id");
                Console.WriteLine("5. Show all doctors");
                Console.WriteLine("6. Show all patients");
                Console.WriteLine("7. Show all bills");
                Console.WriteLine("8. Exit");
                Console.Write("\nPlease enter your choice: ");
                int adminChoice = int.Parse(Console.ReadLine());

                switch (adminChoice)
                {
                    case 1:
                        admin.RecruitDoctor();
                        break;
                    case 2:
                        admin.AdmitPatient();
                        break;
                    case 3:
                        admin.GenerateBill();
                        break;
                    case 4:
                        admin.ShowBill();
                        break;
                    case 5:
                        admin.ShowAllDoctors();
                        break;
                    case 6:
                        admin.ShowAllPatients();
                        break;
                    case 7:
                        admin.ShowAllBills();
                        break;
                    case 8:
                        return;
                }
            }
        }
    }
}
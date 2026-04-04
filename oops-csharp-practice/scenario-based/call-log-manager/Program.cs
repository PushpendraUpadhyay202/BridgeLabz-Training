internal class Program
{
    private List<CallLog> callLogs;

    public Program()
    {
        callLogs = new List<CallLog>();
    }
    static void Main(string[] args)
    {
        Program program = new Program();
        program.StartApplication();
    }

    private void StartApplication()
    {
        ILogManagerImp logManager = new ILogManagerImp();

        while (true)
        {
            Console.WriteLine("\n==== Call Log Manager ====\n");
            Console.WriteLine("1. Add a call log");
            Console.WriteLine("2. Search by keyword");
            Console.WriteLine("3. Filter by time");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            int userChoice = int.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    CallLog callLog = logManager.AddCallLog();
                    callLogs.Add(callLog);
                    break;
                case 2:
                    logManager.SearchByKeyword(callLogs);
                    break;
                case 3:
                    logManager.FilterByTime(callLogs);
                    break;
                case 4:
                    return;
            }
        }

    }
}
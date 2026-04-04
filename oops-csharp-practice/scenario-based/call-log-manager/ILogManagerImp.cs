internal class ILogManagerImp: ILogManager
{
    public CallLog AddCallLog()
    {
        Console.WriteLine("\n==== Add Call Log ====\n");
        Console.Write("Please enter the phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Please enter the message: ");
        string message = Console.ReadLine();
        CallLog callLog = new CallLog(phoneNumber, message);

        return callLog;
    }

    public void SearchByKeyword(List<CallLog> callLogs)
    {
        Console.WriteLine("\n==== Call Log Searching with keyword ====\n");
        Console.Write("Please enter the keyword to search the messages: ");
        string keyword = Console.ReadLine();

        foreach(CallLog callLog in callLogs)
        {
            if (callLog.GetMessage().Contains(keyword))
            {
                Console.WriteLine(callLog);
            }
        }
    }

    public void FilterByTime(List<CallLog> callLogs)
    {
        Console.WriteLine("\n==== Fiter Call Logs by Time ====\n");
        Console.WriteLine("Enter from time:");
        Console.Write("\tYear: ");
        int fromYear = int.Parse(Console.ReadLine());
        Console.Write("\tMonth: ");
        int fromMonth = int.Parse(Console.ReadLine());
        Console.Write("\tDay: ");
        int fromDay = int.Parse(Console.ReadLine());
        Console.Write("\tHour: ");
        int fromHour = int.Parse(Console.ReadLine());
        Console.Write("\tMinutes: ");
        int fromMinute = int.Parse(Console.ReadLine());
        Console.Write("\tSeconds: ");
        int fromSeconds = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Enter to time:");
        Console.Write("\tYear: ");
        int toYear = int.Parse(Console.ReadLine());
        Console.Write("\tMonth: ");
        int toMonth = int.Parse(Console.ReadLine());
        Console.Write("\tDay: ");
        int toDay = int.Parse(Console.ReadLine());
        Console.Write("\tHour: ");
        int toHour = int.Parse(Console.ReadLine());
        Console.Write("\tMinutes: ");
        int toMinute = int.Parse(Console.ReadLine());
        Console.Write("\tSeconds: ");
        int toSeconds = int.Parse(Console.ReadLine());

        DateTime fromTime = new DateTime(fromYear, fromMonth, fromDay, fromHour, fromMinute, fromSeconds);
        DateTime toTime = new DateTime(toYear, toMonth, toDay, toHour, toMinute, toSeconds);

        foreach (CallLog callLog in callLogs)
        {
            if(callLog.GetTimestamp() >= fromTime &&  callLog.GetTimestamp() <= toTime)
            {
                Console.WriteLine(callLog);
            }
        }
    }
}
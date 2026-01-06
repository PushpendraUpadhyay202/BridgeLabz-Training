internal interface ILogManager
{
    CallLog AddCallLog();
    void SearchByKeyword(List<CallLog> CallLogs);
    void FilterByTime(List<CallLog> CallLogs);
}
internal class CallLog
{
    private string phoneNumber;
    private string message;
    private readonly DateTime timestamp;

    public CallLog(string phoneNumber, string message)
    {
        this.phoneNumber = phoneNumber;
        this.message = message;
        this.timestamp = DateTime.Now;
    }

    public string GetPhoneNumber()
    {
        return phoneNumber; 
    }

    public string GetMessage()
    {
        return message; 
    }

    public DateTime GetTimestamp()
    {
        return timestamp;
    }

    public override string ToString()
    {
        return $"Phone Number: {phoneNumber}\nMessage: {message}\nTimestamp: {timestamp}";
    }
}
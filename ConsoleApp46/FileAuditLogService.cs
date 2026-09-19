namespace ConsoleApp46;

internal class FileAuditLogService : IAuditLogService
{
    public void Log(string message)
    {
        Console.WriteLine($"Logging to file: {message}");
    }
}

namespace ConsoleApp46;

internal class LedgerEngine<T>
{
    private readonly IAuditLogService _auditLogService;

    public LedgerEngine(IAuditLogService auditLogService)
    {
        _auditLogService = auditLogService;
    }
    [AuditLoggable]
    public void Process(T item)
    {
        Console.WriteLine("Processing...");

        _auditLogService.Log($"Processed item: {item}");
    }
}

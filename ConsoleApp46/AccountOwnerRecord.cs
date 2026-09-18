namespace ConsoleApp46;

internal record AccountOwnerRecord
{
    public int Id { get; init; }
    public string FullName { get; init; } = null!;
    public string TaxId { get; init; } = null!;
    public AccountOwnerRecord(int id, string fullName, string taxId)
    {
        Id = id;
        FullName = fullName;
        TaxId = taxId;
    }

}

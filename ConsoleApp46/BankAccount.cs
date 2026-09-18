namespace ConsoleApp46;

internal class BankAccount
{
    private static int _lastAccountId = 0;
    public int Id { get;}
    public string Owner { get; init; } = null!;
    private static int _transactionCount;
    private readonly List<string> _transactions = new();
    public int TransactionCount => _transactionCount;
    public void AddTransaction(string transaction)
    {
        _transactions.Add(transaction);
        _transactionCount++;
    }
    public string this[int index]
    {
        get
        {
            if (index < 0 || index >= _transactions.Count)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }
            return _transactions[index];
        }
    }
}

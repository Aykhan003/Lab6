namespace ConsoleApp46
{
    public class TransactionDetail
    {
        public int Id { get; set; }

        public TransactionDetail DeepCopy()
        {
            return new TransactionDetail
            {
                Id = Id
            };
        }
    }
}

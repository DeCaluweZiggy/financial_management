namespace Zdc.financial_management.Core.Entities.Generics
{
    public abstract class Transaction : BaseEntity
    {
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public required Catagories Catagory { get; set; }
        public string? Company { get; set; } 
    }
}

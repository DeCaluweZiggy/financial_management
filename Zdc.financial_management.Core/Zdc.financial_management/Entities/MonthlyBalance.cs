using System.Transactions;

namespace Zdc.financial_management.Core.Entities
{
    public class MonthlyBalance
    {
        public DateTime MonthAndYear { get; set; }
        public decimal Balance { get; set; }
        public List<Transaction> Revenues { get; set; }
        public List<Transaction> Expenses { get; set; }
    }
}

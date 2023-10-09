namespace Zdc.financial_management.Core.Entities
{
    public class User: BaseEntity
    {
        public List<MonthlyBalance> ListOfMonthlyBalance { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
    }
}

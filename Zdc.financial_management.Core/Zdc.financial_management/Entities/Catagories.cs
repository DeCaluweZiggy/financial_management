namespace Zdc.financial_management.Core.Entities
{
    public class Catagories: BaseEntity
    {
        public required string NameCatagorie { get; set; }
        public string? Description { get; set; }
    }
}

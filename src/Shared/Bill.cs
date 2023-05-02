namespace Shared;

public class Bill
{
    public decimal Value { get; set; }
    public DateTime DueDate { get; set; }
    

    public Bill(decimal value, DateTime dueDate)
    {
        Value = value;
        DueDate = dueDate;
    }
}

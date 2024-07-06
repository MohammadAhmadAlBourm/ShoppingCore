namespace Domain.Entities;

public class Order
{
    public int Id { get; set; }


    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public DateTime UpdatedDate { get; set; }
}
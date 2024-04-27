using System.ComponentModel.DataAnnotations;

public class Car
{
    public int Id { get; set; }

    [StringLength(50)]
    public string Make { get; set; }

    [StringLength(50)]
    public string Model { get; set; }

    [Range(1900, 2100)]
    public int Year { get; set; }

    [StringLength(20)]
    public string Color { get; set; }

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime PurchaseDate { get; set; }

    [Range(0, 1000000)]
    [DataType(DataType.Currency)]
    public decimal Price { get; set; }
}

namespace MyShopNetSix.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string UnitBrief { get; set; } = null!;
        public double UnitPrice { get; set; }
        public string Image { get; set; } = null!;
        public DateTime ProductDate { get; set; }
        public bool? Available { get; set; }
        public string? Description { get; set; }
        public int CategoryId { get; set; }
        public string SupplierId { get; set; } = null!;
        public int Quantity { get; set; }
        public double Discount { get; set; }
        public bool Special { get; set; }
        public bool Latest { get; set; }
        public int Views { get; set; }
    }
}

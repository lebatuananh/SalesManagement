namespace SalesManagement.ConsoleApp.Application.ViewModel
{
    public class ProductQuantityViewModel
    {
        public int Id { get; set; }
        
        public int ProductId { get; set; }

        public int SizeId { get; set; }

        public int ColorId { get; set; }

        public int Quantity { get; set; }

        public ProductViewModel Product { get; set; }

        public SizeViewMode Size { get; set; }

        public ColorViewModel Color { get; set; }
    }
}
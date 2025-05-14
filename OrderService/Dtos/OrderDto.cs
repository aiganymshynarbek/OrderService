namespace OrderService.Dtos
{
    public class OrderDto
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Product { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }
    }
}

namespace ferreteiaAPI.Models
{
    public class SalesDTO
    {
        public List<Guid> productId { get; set; }
        public Guid discountId { get; set; }
        public Guid userId { get; set; }
        public decimal subTotal { get; set; }
        public DateTime updatedDate { get; set; }
    }
}

using PUNTO_FERRETERO.DATA.MODELS;

namespace ferreteiaAPI.Models
{
    public class SalesDTO
    {
        public List<Guid> productId { get; set; }
        public Guid discountId { get; set; }
        public int salesNumer { get; set; }
        public decimal subTotal { get; set; }
    }
}

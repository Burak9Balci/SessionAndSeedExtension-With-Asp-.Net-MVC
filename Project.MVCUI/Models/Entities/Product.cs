using Project.MVCUI.Models.Interfaces;

namespace Project.MVCUI.Models.Entities
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? CategoryID { get; set; }
        //RS
        public virtual Category Category { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}

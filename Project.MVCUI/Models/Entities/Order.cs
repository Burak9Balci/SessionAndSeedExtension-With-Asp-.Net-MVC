namespace Project.MVCUI.Models.Entities
{
    public class Order : BaseEntity
    {
        public string ShippingAddress { get; set; }
        public int AppUserID { get; set; }
        //RS
        public virtual AppUser AppUser { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}

namespace Project.MVCUI.Models.Entities
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
        //RS
        public virtual ICollection<Product> Products { get; set; }
    }
}

namespace Project.MVCUI.Models.Entities
{
    public class AppUser :BaseEntity
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }
        //RS
        public virtual UserProfile UserProfile { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

    }
}

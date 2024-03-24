namespace Project.MVCUI.Models.Entities
{
    public class UserProfile : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //RS
        public virtual AppUser AppUser { get; set; }
    }
}

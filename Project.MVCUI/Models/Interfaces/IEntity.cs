using Project.MVCUI.Models.Enums;

namespace Project.MVCUI.Models.Interfaces
{
    public interface IEntity
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }
    }
}

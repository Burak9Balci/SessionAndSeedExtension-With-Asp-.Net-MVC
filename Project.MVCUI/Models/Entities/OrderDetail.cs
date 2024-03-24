﻿namespace Project.MVCUI.Models.Entities
{
    public class OrderDetail : BaseEntity
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        //RS
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FitnessClub1.BD
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int IdOrder { get; set; }
        public int IdClient { get; set; }
        public int IdStaff { get; set; }
        public Nullable<System.DateTime> DateAndTime { get; set; }
        public int IdOrderService { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual OrderService OrderService { get; set; }
        public virtual Staff Staff { get; set; }
    }
}

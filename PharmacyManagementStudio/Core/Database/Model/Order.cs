namespace PharmacyManagementStudio.Core.Database.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        public int OrderId { get; set; }

        public int CustomerId { get; set; }

        public int MedicineId { get; set; }

        public int SalerId { get; set; }

        public double Price { get; set; }

        public int Count { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Medicine Medicine { get; set; }

        public virtual Saler Saler { get; set; }
    }
}

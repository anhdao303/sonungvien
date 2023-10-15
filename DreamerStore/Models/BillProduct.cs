namespace DreamerStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BillProduct")]
    public partial class BillProduct
    {
        [Key]
        [Column(Order = 0)]
        public int BillID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DetailedProductID { get; set; }

        public int Amount { get; set; }

        public int? Order { get; set; }

        [StringLength(1)]
        public string Meta { get; set; }

        public bool? Hide { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public virtual Bill Bill { get; set; }

        public virtual DetailedProduct DetailedProduct { get; set; }
    }
}

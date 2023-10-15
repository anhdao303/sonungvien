namespace DreamerStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductImage")]
    public partial class ProductImage
    {
        public int ProductImageID { get; set; }

        [StringLength(1)]
        public string ProductImageLink { get; set; }

        public int ProductID { get; set; }

        public virtual Product Product { get; set; }
    }
}

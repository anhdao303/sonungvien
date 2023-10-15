namespace DreamerStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DetailedProduct")]
    public partial class DetailedProduct
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DetailedProduct()
        {
            BillProducts = new HashSet<BillProduct>();
        }

        public int DetailedProductID { get; set; }

        public int DetailedProductPRICE { get; set; }

        public int DetailedProductQUANTITY { get; set; }

        [Required]
        [StringLength(1)]
        public string DetailedProductName { get; set; }

        public int ProductID { get; set; }

        public int? Order { get; set; }

        [StringLength(1)]
        public string Meta { get; set; }

        [StringLength(1)]
        public string Image { get; set; }

        public bool? Hide { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillProduct> BillProducts { get; set; }

        public virtual Product Product { get; set; }
    }
}

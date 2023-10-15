namespace DreamerStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Discount")]
    public partial class Discount
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Discount()
        {
            DiscountUses = new HashSet<DiscountUse>();
        }

        public int DiscountID { get; set; }

        [Required]
        [StringLength(1)]
        public string DiscountName { get; set; }

        [Required]
        [StringLength(1)]
        public string DiscountCalUnit { get; set; }

        public int DiscountCondition { get; set; }

        public int DiscountMaxValue { get; set; }

        [Required]
        [StringLength(1)]
        public string DiscountRemark { get; set; }

        public DateTime DiscountAvailableFrom { get; set; }

        public DateTime DiscountAvailableUntil { get; set; }

        public int DiscountValue { get; set; }

        public int? Order { get; set; }

        [StringLength(1)]
        public string Meta { get; set; }

        [StringLength(1)]
        public string Image { get; set; }

        public bool? Hide { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiscountUse> DiscountUses { get; set; }
    }
}

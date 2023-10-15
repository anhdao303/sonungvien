namespace DreamerStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bill")]
    public partial class Bill
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bill()
        {
            BillProducts = new HashSet<BillProduct>();
            DiscountUses = new HashSet<DiscountUse>();
        }

        public int BillID { get; set; }

        [Required]
        [StringLength(1)]
        public string BillPhoneNumber { get; set; }

        [Required]
        [StringLength(1)]
        public string BillLastName { get; set; }

        [Required]
        [StringLength(1)]
        public string BillNote { get; set; }

        [Required]
        [StringLength(1)]
        public string BillFirstName { get; set; }

        [Required]
        [StringLength(1)]
        public string BillPostcode { get; set; }

        [Required]
        [StringLength(1)]
        public string BillEmail { get; set; }

        [Required]
        [StringLength(1)]
        public string BillProvince { get; set; }

        [Required]
        [StringLength(1)]
        public string BillWard { get; set; }

        [Required]
        [StringLength(1)]
        public string BillAddress { get; set; }

        public int BillPrice { get; set; }

        public int BillOldPrice { get; set; }

        public int BillTaxAmount { get; set; }

        public DateTime BillUpdatedAt { get; set; }

        public DateTime BillCreatedAt { get; set; }

        public int BillSequenceNumber { get; set; }

        public int BillFinalPrice { get; set; }

        public int BillDiscountAmount { get; set; }

        public int? Order { get; set; }

        [StringLength(1)]
        public string Meta { get; set; }

        public bool? Hide { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public int BillTermOfPayment { get; set; }

        public int BillStatus { get; set; }

        public virtual BillStatu BillStatu { get; set; }

        public virtual TermOfPayment TermOfPayment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillProduct> BillProducts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiscountUse> DiscountUses { get; set; }
    }
}

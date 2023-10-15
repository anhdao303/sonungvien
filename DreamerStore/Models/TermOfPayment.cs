namespace DreamerStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TermOfPayment")]
    public partial class TermOfPayment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TermOfPayment()
        {
            Bills = new HashSet<Bill>();
        }

        [Key]
        public int PaymentID { get; set; }

        [Required]
        [StringLength(1)]
        public string PaymentName { get; set; }

        public int? Order { get; set; }

        [StringLength(1)]
        public string Meta { get; set; }

        [StringLength(1)]
        public string Image { get; set; }

        public bool? Hide { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill> Bills { get; set; }
    }
}

namespace DreamerStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Banner")]
    public partial class Banner
    {
        public int BannerID { get; set; }

        [Required]
        [StringLength(1)]
        public string BannerName { get; set; }

        [Required]
        [StringLength(1)]
        public string BannerMessage { get; set; }

        [Required]
        [StringLength(1)]
        public string BannerDescription { get; set; }

        public int? Order { get; set; }

        [StringLength(1)]
        public string Meta { get; set; }

        [StringLength(1)]
        public string Image { get; set; }

        public bool? Hide { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}

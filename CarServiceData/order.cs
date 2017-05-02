namespace CarServiceData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("carservice.order")]
    [Serializable]
    public partial class order
    {
        [Key]
        public int IdOrder { get; set; }

        [Required]
        [StringLength(45)]
        public string Title { get; set; }

        public DateTime BeginTime { get; set; }

        public DateTime? EndTime { get; set; }

        public float Cost { get; set; }

        public int CarId { get; set; }

        public virtual car car { get; set; }
    }
}

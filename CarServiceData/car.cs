namespace CarServiceData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("carservice.car")]
    [Serializable]
    public partial class car
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public car()
        {
            order = new HashSet<order>();
        }

        [Key]
        public int IdCar { get; set; }

        [Required]
        [StringLength(45)]
        public string Mark { get; set; }

        [Required]
        [StringLength(45)]
        public string Model { get; set; }

        public int Year { get; set; }

        [Required]
        [StringLength(45)]
        public string Transmission { get; set; }

        public float Horsepower { get; set; }

        public int ClientId { get; set; }

        public virtual client client { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<order> order { get; set; }
    }
}

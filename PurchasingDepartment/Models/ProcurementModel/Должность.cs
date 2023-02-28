namespace PurchasingDepartment.Models.ProcurementModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Должность
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Должность()
        {
            Сотрудник = new HashSet<Сотрудник>();
        }

        [Key]
        public int Код { get; set; }

        [Required]
        [StringLength(50)]
        public string Наименование { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Сотрудник> Сотрудник { get; set; }
    }
}

namespace PurchasingDepartment.Models.ProcurementModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Товар
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Товар()
        {
            ЗаказТовар = new HashSet<ЗаказТовар>();
        }

        [Key]
        public int Код { get; set; }

        public int КодЕденицыИзмерения { get; set; }

        [Required]
        [StringLength(50)]
        public string Название { get; set; }

        public int Количество { get; set; }

        public decimal Цена { get; set; }

        public virtual ЕдиницаИзмерения ЕдиницаИзмерения { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ЗаказТовар> ЗаказТовар { get; set; }
    }
}

namespace PurchasingDepartment.Models.ProcurementModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Заказ
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Заказ()
        {
            ЗаказТовар = new HashSet<ЗаказТовар>();
        }

        [Key]
        public int Код { get; set; }

        public int КодСотрудника { get; set; }

        public int КодПоставщика { get; set; }

        public int КодВидаОплаты { get; set; }

        [Required]
        [StringLength(50)]
        public string Номер { get; set; }

        [Required]
        [StringLength(100)]
        public string ОрганизацияЗаказчик { get; set; }

        public virtual ВидОплаты ВидОплаты { get; set; }

        public virtual Поставщик Поставщик { get; set; }

        public virtual Сотрудник Сотрудник { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ЗаказТовар> ЗаказТовар { get; set; }
    }
}

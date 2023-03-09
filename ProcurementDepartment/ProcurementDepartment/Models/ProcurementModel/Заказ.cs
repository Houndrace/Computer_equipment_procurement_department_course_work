namespace ProcurementDepartment.Models.ProcurementModel
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
            Товар = new HashSet<Товар>();
        }

        [Key]
        public int Код { get; set; }

        public int КодСтатуса { get; set; }

        public int КодCклада { get; set; }

        public int КодСотрудника { get; set; }

        public int КодПоставщика { get; set; }

        public bool Оплачено { get; set; }

        [Required]
        [StringLength(50)]
        public string Номер { get; set; }

        [Column(TypeName = "date")]
        public DateTime Дата { get; set; }

        public virtual Поставщик Поставщик { get; set; }

        public virtual Склад Склад { get; set; }

        public virtual Сотрудник Сотрудник { get; set; }

        public virtual Статус Статус { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Товар> Товар { get; set; }
    }
}

namespace ProcurementDepartment.Models.ProcurementModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Поставщик
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Поставщик()
        {
            Заказ = new HashSet<Заказ>();
        }

        [Key]
        public int Код { get; set; }

        public int КодТелефона { get; set; }

        public int КодАдреса { get; set; }

        public int? КодЭлектроннойПочты { get; set; }

        [Required]
        [StringLength(100)]
        public string НаименованиеФирмы { get; set; }

        public virtual Адрес Адрес { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Заказ> Заказ { get; set; }

        public virtual Телефон Телефон { get; set; }

        public virtual ЭлектроннаяПочта ЭлектроннаяПочта { get; set; }
    }
}

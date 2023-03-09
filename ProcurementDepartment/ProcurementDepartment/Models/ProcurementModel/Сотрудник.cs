namespace ProcurementDepartment.Models.ProcurementModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Сотрудник
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Сотрудник()
        {
            Заказ = new HashSet<Заказ>();
        }

        [Key]
        public int Код { get; set; }

        public int КодДолжности { get; set; }

        public int КодУровняДоступа { get; set; }

        public int КодОрганизации { get; set; }

        public int КодТелефона { get; set; }

        public int? КодЭлектроннойПочты { get; set; }

        [Required]
        [StringLength(50)]
        public string Логин { get; set; }

        [Required]
        [StringLength(50)]
        public string Пароль { get; set; }

        [Required]
        [StringLength(50)]
        public string Фамилия { get; set; }

        [Required]
        [StringLength(50)]
        public string Имя { get; set; }

        [StringLength(50)]
        public string Отчество { get; set; }

        public virtual Должность Должность { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Заказ> Заказ { get; set; }

        public virtual Организация Организация { get; set; }

        public virtual Телефон Телефон { get; set; }

        public virtual УровеньДоступа УровеньДоступа { get; set; }

        public virtual ЭлектроннаяПочта ЭлектроннаяПочта { get; set; }
    }
}

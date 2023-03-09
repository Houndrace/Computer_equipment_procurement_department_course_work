namespace ProcurementDepartment.Models.ProcurementModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Товар
    {
        [Key]
        public int Код { get; set; }

        public int КодЕденицыИзмерения { get; set; }

        public int КодЗаказа { get; set; }

        [Required]
        [StringLength(50)]
        public string Название { get; set; }

        public int Количество { get; set; }

        public decimal Цена { get; set; }

        public virtual ЕдиницаИзмерения ЕдиницаИзмерения { get; set; }

        public virtual Заказ Заказ { get; set; }
    }
}

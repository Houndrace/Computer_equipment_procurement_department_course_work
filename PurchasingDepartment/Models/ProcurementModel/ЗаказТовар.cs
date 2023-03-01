namespace PurchasingDepartment.Models.ProcurementModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ЗаказТовар
    {
        [Key]
        public int Код { get; set; }

        public int КодЗаказа { get; set; }

        public int КодТовара { get; set; }

        public virtual Заказ Заказ { get; set; }

        public virtual Товар Товар { get; set; }
    }
}

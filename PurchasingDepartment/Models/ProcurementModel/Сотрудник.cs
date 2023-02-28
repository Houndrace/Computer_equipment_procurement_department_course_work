namespace PurchasingDepartment.Models.ProcurementModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Data.Entity.Spatial;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Web.UI.WebControls;

    public partial class Сотрудник : IUserControl {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Сотрудник()
        {
            Заказ = new HashSet<Заказ>();
        }

        [Key]
        public int Код { get; set; }

        public int КодДолжности { get; set; }

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

        public virtual Телефон Телефон { get; set; }

        public virtual ЭлектроннаяПочта ЭлектроннаяПочта { get; set; }

        public bool Authenticate() {
            if (Логин == null || Логин == "" || Пароль == null || Пароль == "") {
                return false;
            }
 
            using (var db = new ProcurementModel()) {
                db.Сотрудник.Load();
                return db.Сотрудник.Local.ToList().Exists(u => u.Пароль == Пароль && u.Логин == Логин);
            }
        }

        public void checkLogin() {
            if (Логин.Length < 4)
                throw new ArgumentException("Длина логина меньше 4 символов");

            if (Логин.Length > 20)
                throw new ArgumentException("Максимальная длина логина 20 символов");

            if (!Regex.IsMatch(Логин, @"^[a-zA-z]+([-_]?[a-z0-9]+){0,2}$"))
                throw new ArgumentException("Некорректный логин");
        }

        public void checkPassword() {
            if (Пароль.Length < 6)
                throw new ArgumentException("Длина пароля меньше 6 символов");

            if (Пароль.Length > 30)
                throw new ArgumentException("Максимальная длина пароля 30 символов");

            if (!Regex.IsMatch(Пароль, @"(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])"))
                throw new ArgumentException("Слишком легкий пароль");
        }
    }
}

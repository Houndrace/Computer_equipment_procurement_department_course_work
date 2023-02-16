using System;
using System.Data.Entity;
using System.Linq;
using System.Text.RegularExpressions;

namespace PurchasingDepartment.Models.DataBase
{
    public class User : IUserControl
    {
        public int Id { get; set; }
        public string Login { get; set; } = "";
        public string Password { get; set; } = "";
        public string Post { get; set; }

        public bool Authenticate()
        {
            if (Login.Equals("") || Password.Equals(""))
                return false;
            using (var db = new MyDBContext())
            {
                db.Users.Load();
                return db.Users.Local.ToList().Exists(u => u.Password == Password && u.Login == Login);
            }
        }

        public void checkLogin()
        {
            if (Login.Length < 4)
                throw new ArgumentException("Длина логина меньше 4 символов");

            if (Login.Length > 20)
                throw new ArgumentException("Максимальная длина логина 20 символов");

            if (!Regex.IsMatch(Login, @"^[a-zA-z]+([-_]?[a-z0-9]+){0,2}$"))
                throw new ArgumentException("Некорректный логин");
        }

        public void checkPassword()
        {
            if (Password.Length < 6)
                throw new ArgumentException("Длина пароля меньше 6 символов");

            if (Password.Length > 30)
                throw new ArgumentException("Максимальная длина пароля 30 символов");

            if (!Regex.IsMatch(Password, @"(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])"))
                throw new ArgumentException("Слишком легкий пароль");
        }
    }
}

namespace PurchasingDepartment.Models
{
    internal interface IUserControl
    {
        bool Authenticate();
        void checkLogin();
        void checkPassword();
    }
}

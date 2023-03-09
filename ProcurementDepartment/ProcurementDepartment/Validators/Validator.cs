using ProcurementDepartment.Models.ProcurementModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProcurementDepartment.Validators
{
    public class Validator
    {
        public static bool checkOrder(object supplier, object warehouse, object status, string date)
        {


            if (String.IsNullOrEmpty(date) || supplier == null 
                    || warehouse == null || status == null)
                return false;
            
            return true;
        }

        public static bool checkProduct(string name, string strQuantity, object measureUnit, string strPrice)
        {

            if (String.IsNullOrEmpty(name) || !Int32.TryParse(strQuantity, out int result)
                    || !Decimal.TryParse(strPrice, out decimal price) || measureUnit == null )
                return false;

            return true;
        }
    }
}

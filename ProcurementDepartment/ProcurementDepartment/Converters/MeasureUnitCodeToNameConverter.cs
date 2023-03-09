using ProcurementDepartment.Models.ProcurementModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ProcurementDepartment.Converters
{
    public class MeasureUnitCodeToNameConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Get the unit of measurement code from the binding source
            int code = (int)value;

            // Use the code to look up the corresponding unit of measurement name
            string name;

            using (var db = new ProcurementModel())
            {
                name = db.ЕдиницаИзмерения.Find(code).Название;
            }

            return name;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string name = (string)value;

            int code;

            using (var db = new ProcurementModel())
            {
                ЕдиницаИзмерения measureUnit = db.ЕдиницаИзмерения.FirstOrDefault(um => um.Название.Equals(name));
                code = measureUnit.Код;
            }

            return code;
        }
    }
}

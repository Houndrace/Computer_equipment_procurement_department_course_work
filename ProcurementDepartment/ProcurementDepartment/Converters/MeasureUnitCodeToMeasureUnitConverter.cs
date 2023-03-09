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
    public class MeasureUnitCodeToMeasureUnitConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int code = (int)value;

            ЕдиницаИзмерения measurementUnit;

            using (var db = new ProcurementModel())
            {
                measurementUnit = db.ЕдиницаИзмерения.Find(code);
            }

            return measurementUnit;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            ЕдиницаИзмерения measurementUnit = (ЕдиницаИзмерения)value;

            int code;

            using (var db = new ProcurementModel())
            {
                code = measurementUnit.Код;
            }

            return code;
        }
    }
}

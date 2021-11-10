using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using Adopt_a_new_friend.Models.EntityLayer;
namespace Adopt_a_new_friend.Convertors
{
    class EmployeeConvertor : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            int addressID;
            if (!int.TryParse(values[4].ToString(), out addressID))
            {
                return null;
            }
            return new Employee()
            {
                Name = values[0].ToString(),
                Phone = values[1].ToString(),
                Email = values[2].ToString(),
                Id_address = addressID

            };
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            Employee employee = value as Employee;
            Object[] result = new object[4] { employee.Name, employee.Phone, employee.Email, employee.Id_address };
            return result;
        }
        
    }
}

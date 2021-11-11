using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using Adopt_a_new_friend.Models.EntityLayer;
namespace Adopt_a_new_friend.Convertors
{
    class UserConvertor : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            int employeeID;
            if(!int.TryParse(values[4].ToString(),out employeeID))
            {
                return null;
            }
            int clientID;
            if(!int.TryParse(values[5].ToString(),out clientID))
            {
                return null;
            }
            return new User()
            {
                Type = values[0].ToString(),
                UserName = values[1].ToString(),
                Password = values[2].ToString(),
                Employee_code = employeeID,
                Client_code = clientID

            };
        }
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            User user = value as User;
            Object[] result = new object[5] { user.Type, user.UserName, user.Password, user.Employee_code, user.Client_code };
            return result;
        }
     }
}

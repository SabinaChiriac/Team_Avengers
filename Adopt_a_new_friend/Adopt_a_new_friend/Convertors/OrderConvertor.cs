using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using Adopt_a_new_friend.Models.EntityLayer;
namespace Adopt_a_new_friend.Convertors
{
    class OrderConvertor : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            int clientID;
            if(!int.TryParse(values[3].ToString(),out clientID))
            {
                return null;
            }
            int petID;
            if(!int.TryParse(values[4].ToString(),out petID))
            {
                return null;
            }
            int employeeID;
            if(!int.TryParse(values[5].ToString(),out employeeID))
            {
                return null;
            }
            return new Order()
            {
               // Date = values[0].ToString(),
                Type = values[1].ToString(),
                Client_code = clientID,
                Id_pet = petID,
                Employee_code=employeeID
            };
        }
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            Order order = value as Order;
            Object[] result = new object[5] { order.Date,order.Type,order.Client_code,order.Id_pet,order.Employee_code};
            return result;
        }   

    }

}

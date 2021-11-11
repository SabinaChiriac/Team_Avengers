using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using Adopt_a_new_friend.Models.EntityLayer;

namespace Adopt_a_new_friend.Convertors
{
    class AddressConvertor : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return new Address()
            {
                City = values[0].ToString(),
                Street=values[1].ToString(),
                Number=values[2].ToString()
            };
        }
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            Address address = value as Address;
            Object[] result = new object[3] { address.City,address.Street,address.Number};
            return result;


        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using Adopt_a_new_friend.Models.EntityLayer;
namespace Adopt_a_new_friend.Convertors
{
    class PetConvertor IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {

           return new Pet()
          {
            Name = values[0].ToString(),
            Bread = values[1].ToString(),
            // Age=int.TryParse(values[2].ToString(), out age ),
            Description = values[3].ToString(),
            Type = values[4].ToString()

          };
        }

    public object[] ConvertBack(object[] value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        Pet pet = value as Pet;
        Object[] result = new object[5] { pet.Name, pet.Bread, pet.Age, pet.Description, pet.Type };
        return result;

    }

  }
}

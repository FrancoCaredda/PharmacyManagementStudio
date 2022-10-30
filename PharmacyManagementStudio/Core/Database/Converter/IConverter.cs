using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagementStudio.Core.Database.Converter
{
    public interface IConverter
    {
        object Convert(object value);
        object ConvertBack(object value);

        object Map(object value, object value2);
    }
}

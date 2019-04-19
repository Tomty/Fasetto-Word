using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fasetto.Word.Core;

namespace Fasetto_Word
{
    /// <summary>
    /// A converter that take a <see cref="IconType"/> and return the corresponding 
    /// FontAwesome string
    /// </summary>
    public class IconTypeToFontAwesomeConverter : BasevalueConverter<IconTypeToFontAwesomeConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((IconType)value).ToFontAwesome();
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

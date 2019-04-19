using System;
using System.Globalization;
using System.Windows;

namespace Fasetto_Word
{
    /// <summary>
    /// A converter that takes in the core horizontal alignemetn enum and covnert it to a wpf alignement
    /// </summary>
    public class HorizontalAlignmentConverter : BasevalueConverter<HorizontalAlignmentConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (HorizontalAlignment)value;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
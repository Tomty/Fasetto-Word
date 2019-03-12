using System;
using System.Globalization;
using System.Windows;

namespace Fasetto_Word
{
    /// <summary>
    /// A converter that takes in a boolean if a message was sent by me, and aligns to the right
    /// if not sent by me, align to the left
    /// </summary>
    public class SentByMeToAlignementConverter : BasevalueConverter<SentByMeToAlignementConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? HorizontalAlignment.Right : HorizontalAlignment.Left;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
using System;
using System.Globalization;
using System.Windows;

namespace Fasetto_Word
{
    /// <summary>
    /// A converter that takes in a date and converts it to a user freindly time
    /// </summary>
    public class TimeToDisplayTimeConverter : BasevalueConverter<TimeToDisplayTimeConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Get the time passed in
            var time = (DateTimeOffset)value;

            // If it is today ...
            if (time.Date == DateTimeOffset.UtcNow.Date)
                // Return just time
                return time.ToLocalTime().ToString("HH:mm");

            // Otherwise, return a full date
            return time.ToLocalTime().ToString("HH:mm, MMM yyyy");
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
using System;
using System.Diagnostics;
using System.Globalization;
using Fasetto.Word.Core;
using Fasetto.Word.Core.IoC;
using Fasetto.Word.Core.ViewModels;
using Ninject;

namespace Fasetto_Word
{
    /// <summary>
    /// Converts a string name to a service pulled from the IoC container
    /// </summary>
    class IoCConverter : BasevalueConverter<IoCConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Find the appropriate page
            switch ((string)parameter)
            {
                //Find the appopriate page
                case nameof(ApplicationViewModel):
                    return IoC.Get<ApplicationViewModel>(); ;
                default:
                    Debugger.Break();
                    return null;
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

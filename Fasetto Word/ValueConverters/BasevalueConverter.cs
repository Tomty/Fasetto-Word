
using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace Fasetto_Word
{
    public abstract class BasevalueConverter<T> : MarkupExtension, IValueConverter
        where T : class, new()
    {
        #region private members

        /// <summary>
        /// A single static instance of this value converter
        /// </summary>
        private static T mConverter = null;

        #endregion

        #region markup extension methods

        /// <summary>
        /// Provide a static instance of the value converter
        /// </summary>
        /// <param name="serviceProvider">The service provider</param>
        /// <returns></returns>
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return mConverter ?? (mConverter = new T());

            /*
            if (mConverter == null)
                mConverter = new T();
            
            return mConverter;
            */
        }

        #endregion

        #region  value converter methods

        /// <summary>
        /// The methid to convert one type to another
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public abstract object Convert(object value, Type targetType, object parameter, CultureInfo culture);

        /// <summary>
        /// The method to convert a value back to it's source type
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public abstract object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);
        #endregion
    }
}

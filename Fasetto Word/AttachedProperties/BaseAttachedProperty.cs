using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Fasetto_Word
{
    /// <summary>
    /// A base attached property to replace the vanilla WPF attached property
    /// </summary>
    /// <typeparam name="Parent">The parent class to be the attached property</typeparam>
    /// <typeparam name="Property">Type of this attached property</typeparam>
    public abstract class BaseAttachedProperty<Parent, Property>
        where Parent : BaseAttachedProperty<Parent, Property>, new()
    {
        #region public events

        /// <summary>
        /// Fire when the value changed
        /// </summary>
        public event Action<DependencyObject, DependencyPropertyChangedEventArgs> ValueChanged = (sender, e) => { };


        /// <summary>
        /// Fire when the value changed, even when the value is the same
        /// </summary>
        public event Action<DependencyObject, object> ValueUpdated = (sender, value) => { };

        #endregion

        #region public properties

        /// <summary>
        /// A singleton instance of our parent class
        /// </summary>
        public static Parent Instance { get; private set; } = new Parent();

        #endregion

        #region attached property definitions

        /// <summary>
        /// The attached property for this class
        /// </summary>
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.RegisterAttached(
                "Value", 
                typeof(Property), 
                typeof(BaseAttachedProperty<Parent, Property>), 
                new UIPropertyMetadata(
                    default(Property),
                    new PropertyChangedCallback(OnValuePropertyChanged),
                    new CoerceValueCallback(OnValuePropertyUpdated)
                    ));


        /// <summary>
        /// The callback event when the <see cref="ValueProperty"/> is changed, even if it is the same value
        /// </summary>
        /// <param name="d">The UI elemen that had it's property changed</param>
        /// <param name="e">the argument for the event</param>
        private static object OnValuePropertyUpdated(DependencyObject d, object value)
        {
            //Call the parent function
            Instance.OnValueUpdated(d, value);
            //Call event listener
            Instance.ValueUpdated(d, value);

            return value;
        }

        /// <summary>
        /// The callback event when the <see cref="ValueProperty"/> is changed
        /// </summary>
        /// <param name="d">The UI elemen that had it's property changed</param>
        /// <param name="e">the argument for the event</param>
        private static void OnValuePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            //Call the parent function
            Instance.OnValueChanged(d, e);            
            //Call event listener
            Instance.ValueChanged(d, e);
        }

        /// <summary>
        /// Set the attached property
        /// </summary>
        /// <param name="d">The element to get the property from</param>
        /// <param name="value">The value to set the property to</param>
        public static void SetValue(DependencyObject d, Property value) => d.SetValue(ValueProperty,value);

        /// <summary>
        /// Gets the attached property
        /// </summary>
        /// <param name="d">The element to get the property from</param>
        /// <returns></returns>
        public static Property GetValue(DependencyObject d) => (Property)d.GetValue(ValueProperty);

        #endregion

        #region event methods

        /// <summary>
        /// The methods that is called when an yattached property of this type is changed
        /// </summary>
        /// <param name="d">The UI elemen that this property was changed for</param>
        /// <param name="e">the argument for this event</param>
        public virtual void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) { }


        /// <summary>
        /// The methods that is called when an yattached property of this type is changed, even if the value is the same
        /// </summary>
        /// <param name="d">The UI elemen that this property was changed for</param>
        /// <param name="e">the argument for this event</param>
        public virtual void OnValueUpdated(DependencyObject d, object value) { }

        #endregion
    }


}

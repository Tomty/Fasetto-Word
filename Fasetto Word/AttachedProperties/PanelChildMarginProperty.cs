using System.Windows;
using System.Windows.Controls;

namespace Fasetto_Word
{
	/// <summary>
	/// 
	/// </summary>
	public class PanelChildMarginProperty : BaseAttachedProperty<PanelChildMarginProperty, string>
	{
		public override void OnValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
		{
			// Get the panel (grid typically)
			var panel = (sender as Panel);

			// Wait for panel to load
			panel.Loaded += (s, ee) =>
			{
				// Loop each child
				foreach (var child in panel.Children)
				{
					// set it's margin to the given value
					(child as FrameworkElement).Margin = (Thickness)(new ThicknessConverter().ConvertFromString(e.NewValue as string));
				}
			};
		}

		#region Constructor

		/// <summary>
		/// Default constructor
		/// </summary>
		public PanelChildMarginProperty()
		{

		} 
		
		#endregion
	}
}

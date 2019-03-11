﻿

using System;
using System.Windows;
using System.Windows.Controls;

namespace Fasetto_Word
{
    /// <summary>
    /// Fovuses (keyboard focus) this element on load
    /// </summary>
    class IsFocusedProperty : BaseAttachedProperty<IsFocusedProperty, bool>
    {
        public override void OnValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            //If we don't have a control, return
            if (!(sender is Control control))
                return;

            //FOcus this control once loaded
            control.Loaded += (s, se) => control.Focus();
        }
    }
}
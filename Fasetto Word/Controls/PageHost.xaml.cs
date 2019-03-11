﻿using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Fasetto_Word
{
    /// <summary>
    /// Interaction logic for PageHost.xaml
    /// </summary>
    public partial class PageHost : UserControl
    {
        #region Dependency properties

        /// <summary>
        /// The current page to show in the page host
        /// </summary>
        public BasePage CurrentPage
        {
            get => (BasePage)GetValue(CurrentPageProperty);
            set => SetValue(CurrentPageProperty, value);
        }


        /// <summary>
        /// Registers <see cref="CurrentPage"/> as a dependency property
        /// </summary>
        public static readonly DependencyProperty CurrentPageProperty =
            DependencyProperty.Register(nameof(CurrentPage), typeof(BasePage), typeof(PageHost), new UIPropertyMetadata(CurrentPagePropertyChanged)); 

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public PageHost()
        {
            InitializeComponent();
        }

        #endregion

        #region Property changed events

        /// <summary>
        /// Called when <see cref="CurrentPage"/> value has changed
        /// </summary>
        /// <param name="d"></param>
        /// <param name="e"></param>
        private static void CurrentPagePropertyChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            // Get the frames
            var newPageFrame = (sender as PageHost).NewPage;
            var oldPageFrame = (sender as PageHost).OldPage;

            // Store the current page content as the old page
            var oldPageContent = newPageFrame.Content;

            // Remove current page from new page frame
            newPageFrame.Content = null;

            // Move the previous page into the old page frame
            oldPageFrame.Content = oldPageContent;

            // Animate out previous page when the loaded event fires
            // right after this call due to moving frames
            if (oldPageContent is BasePage oldPage)
                oldPage.ShouldAnimateOut = true;

            // Set the new page content
            newPageFrame.Content = e.NewValue;

            
        } 
        #endregion
    }
}
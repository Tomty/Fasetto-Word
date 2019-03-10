using Fasetto.Word.Core;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace Fasetto_Word
{
    /// <summary>
    /// The base page for all pages to gain base functionality
    /// </summary>
    public class BasePage : Page
    {
        #region Public properties

        /// <summary>
        /// The animation played when the page is first loaded
        /// </summary>
        public PageAnimation PageLoadAnimation { get; set; } = PageAnimation.SlideAndFadeInFromRight;

        /// <summary>
        /// The animation played when the page is unloaded
        /// </summary>
        public PageAnimation PageUnloadAnimation { get; set; } = PageAnimation.SlideAndFadeOutToLeft;

        /// <summary>
        /// The time any slide animation take
        /// </summary>
        public float SlideSeconds { get; set; } = 0.4f;

        /// <summary>
        /// A flag to indicate if this page should animate out on load
        /// Useful for when we are moving the page to another frame
        /// </summary>
        public bool ShouldAnimateOut { get; set; }

        #endregion

        #region constructor
        /// <summary>
        /// Default cosntructor
        /// </summary>
        public BasePage()
        {
            //If we are animating in, hide to begin with
            if (this.PageLoadAnimation != PageAnimation.None)
                this.Visibility = Visibility.Collapsed;

            //Listen out for the page loading
            this.Loaded += BasePage_Loaded;
            
        }

        #endregion

        #region Animation Load/Unload

        /// <summary>
        /// Once the page is loaded, perform any required animation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BasePage_Loaded(object sender, RoutedEventArgs e)
        {
            // If we are setup to animate out on load
            if (ShouldAnimateOut)
                // Animate out
                await AnimateOut();
            else
                //Animate the page In
                await AnimateIn();
        }

        /// <summary>
        /// Animates the page in
        /// </summary>
        /// <returns></returns>
        public async Task AnimateIn()
        {
            if (this.PageLoadAnimation == PageAnimation.None)
                return;

            switch (this.PageLoadAnimation)
            {
                case PageAnimation.SlideAndFadeInFromRight:

                    //Start the animation
                    await this.SlideAndFadeInFromRight(this.SlideSeconds);

                    break;
            }
        }

        public async Task AnimateOut()
        {
            if (this.PageUnloadAnimation == PageAnimation.None)
                return;

            switch (this.PageUnloadAnimation)
            {
                case PageAnimation.SlideAndFadeOutToLeft:

                    //Start the animation
                    await this.SlideAndFadeOutToLeft(this.SlideSeconds);

                    break;
            }
        }
        #endregion

    }

    /// <summary>
    /// A base page with added ViewModel support
    /// </summary>
    public class BasePage<VM> : BasePage
        where VM : BaseViewModel, new()
    {

        #region private members

        /// <summary>
        /// The view model associate with this page
        /// </summary>
        private VM mViewModel;

        #endregion

        #region public properties

        /// <summary>
        /// The View Model associated with this page
        /// </summary>
        public VM ViewModel
        {
            get { return mViewModel; }
            set
            {
                //if nothing has changed, return
                if (mViewModel == value)
                    return;

                //update the value
                mViewModel = value;

                //set the data context for this page
                this.DataContext = mViewModel;
            }
        }

        #endregion

        #region constructor
        /// <summary>
        /// Default cosntructor
        /// </summary>
        public BasePage() : base()
        {
            //Create a default view model
            this.ViewModel = new VM();
        }

        #endregion
        
    }
}

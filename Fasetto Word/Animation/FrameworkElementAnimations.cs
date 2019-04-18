using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace Fasetto_Word
{
    /// <summary>
    /// Helpers to animate framework elements in specific ways
    /// </summary>
    public static class FrameworkElementAnimations
    {
        #region Slide From Left

        /// <summary>
        /// Slides an element in from the left
        /// </summary>
        /// <param name="element">the element to animate</param>
        /// <param name="keepMargin">Wheter to keep the element at the same width during animation</param>
        /// <param name="seconds">the time the animation will take</param>
        /// <param name="width">The animation width to animate to. If not specified the elements width is used</param>
        /// <returns></returns>
        public static async Task SlideAndFadeInFromLeft(this FrameworkElement element, float seconds = 0.3f, bool keepMargin = true, int width = 0)
        {
            //Create the storyboard
            var sb = new Storyboard();

            //Add slide from right animation
            sb.AddSlideFromLeft(seconds, width == 0 ? element.ActualWidth : width, keepMargin: keepMargin);

            //Add fade in animation
            sb.AddFadeIn(seconds);

            //Start animating 
            sb.Begin(element);

            //Make page visible
            element.Visibility = Visibility.Visible;

            //Wait for it to finish
            await Task.Delay((int)(seconds * 1000));
        }

        /// <summary>
        /// Slides an element out to the left
        /// </summary>
        /// <param name="element">the element to animate</param>
        /// <param name="keepMargin">Wheter to keep the element at the same width during animation</param>
        /// <param name="seconds">the time the animation will take</param>
        /// <param name="width">The animation width to animate to. If not specified the elements width is used</param>
        /// <returns></returns>
        public static async Task SlideAndFadeOutToLeft(this FrameworkElement element, float seconds = 0.3f, bool keepMargin = true, int width = 0)
        {
            //Create the storyboard
            var sb = new Storyboard();

            //Add slide from right animation
            sb.AddSlideToLeft(seconds, width == 0 ? element.ActualWidth : width, keepMargin: keepMargin);

            //Add fade in animation
            sb.AddFadeOut(seconds);

            //Start animating 
            sb.Begin(element);

            //Make page visible
            element.Visibility = Visibility.Visible;

            //Wait for it to finish
            await Task.Delay((int)(seconds * 1000));

            // Fully hide the element
            element.Visibility = Visibility.Hidden;
        }

        #endregion

        #region Slide From Right

        /// <summary>
        /// Slides an element in from the right
        /// </summary>
        /// <param name="element">the element to animate</param>
        /// <param name="keepMargin">Wheter to keep the element at the same width during animation</param>
        /// <param name="seconds">the time the animation will take</param>
        /// <param name="width">The animation width to animate to. If not specified the elements width is used</param>
        /// <returns></returns>
        public static async Task SlideAndFadeInFromRight(this FrameworkElement element, float seconds, bool keepMargin = true, int width = 0)
        {
            //Create the storyboard
            var sb = new Storyboard();

            //Add slide from right animation
            sb.AddSlideFromRight(seconds, width == 0 ? element.ActualWidth : width, keepMargin: keepMargin);

            //Add fade in animation
            sb.AddFadeIn(seconds);

            //Start animating 
            sb.Begin(element);

            //Make page visible
            element.Visibility = Visibility.Visible;

            //Wait for it to finish
            await Task.Delay((int)(seconds * 1000));
        }

        /// <summary>
        /// Slides an element out to the right
        /// </summary>
        /// <param name="element">the element to animate</param>
        /// <param name="keepMargin">Wheter to keep the element at the same width during animation</param>
        /// <param name="seconds">the time the animation will take</param>
        /// <param name="width">The animation width to animate to. If not specified the elements width is used</param>
        /// <returns></returns>
        public static async Task SlideAndFadeOutToRight(this FrameworkElement element, float seconds = 0.3f, bool keepMargin = true, int width = 0)
        {
            //Create the storyboard
            var sb = new Storyboard();

            //Add slide from right animation
            sb.AddSlideToRight(seconds, width == 0 ? element.ActualWidth : width, keepMargin: keepMargin);

            //Add fade in animation
            sb.AddFadeOut(seconds);

            //Start animating 
            sb.Begin(element);

            //Make page visible
            element.Visibility = Visibility.Visible;

            //Wait for it to finish
            await Task.Delay((int)(seconds * 1000));

            // Fully hide the element
            element.Visibility = Visibility.Hidden;
        }

        #endregion

        #region Slide From Bottom

        /// <summary>
        /// Slides an element in from the Bottom
        /// </summary>
        /// <param name="element">the element to animate</param>
        /// <param name="keepMargin">Wheter to keep the element at the same width during animation</param>
        /// <param name="seconds">the time the animation will take</param>
        /// <param name="height">The animation height to animate to. If not specified the elements height is used</param>
        /// <returns></returns>
        public static async Task SlideAndFadeInFromBottom(this FrameworkElement element, float seconds = 0.3f, bool keepMargin = true, int height = 0)
        {
            //Create the storyboard
            var sb = new Storyboard();

            //Add slide from right animation
            sb.AddSlideFromBottom(seconds, height == 0 ? element.ActualHeight : height, keepMargin: keepMargin);

            //Add fade in animation
            sb.AddFadeIn(seconds);

            //Start animating 
            sb.Begin(element);

            //Make page visible
            element.Visibility = Visibility.Visible;

            //Wait for it to finish
            await Task.Delay((int)(seconds * 1000));
        }

        /// <summary>
        /// Slides an element out to the Bottom
        /// </summary>
        /// <param name="element">the element to animate</param>
        /// <param name="keepMargin">Wheter to keep the element at the same width during animation</param>
        /// <param name="seconds">the time the animation will take</param>
        /// <param name="height">The animation height to animate to. If not specified the elements height is used</param>
        /// <returns></returns>
        public static async Task SlideAndFadeOutToBottom(this FrameworkElement element, float seconds = 0.3f, bool keepMargin = true, int height = 0)
        {
            //Create the storyboard
            var sb = new Storyboard();

            //Add slide from right animation
            sb.AddSlideToBottom(seconds, height == 0 ? element.ActualHeight : height, keepMargin: keepMargin);

            //Add fade in animation
            sb.AddFadeOut(seconds);

            //Start animating 
            sb.Begin(element);

            //Make page visible
            element.Visibility = Visibility.Visible;

            //Wait for it to finish
            await Task.Delay((int)(seconds * 1000));

            // Fully hide the element
            element.Visibility = Visibility.Hidden;
        }

        #endregion


        #region Fade In / Out

        /// <summary>
        /// Fades an element in
        /// </summary>
        /// <param name="element">the element to animate</param>
        /// <param name="seconds">the time the animation will take</param>
        /// <returns></returns>
        public static async Task FadeIn(this FrameworkElement element, float seconds = 0.3f)
        {
            //Create the storyboard
            var sb = new Storyboard();

            //Add fade in animation
            sb.AddFadeIn(seconds);

            //Start animating 
            sb.Begin(element);

            //Make page visible
            element.Visibility = Visibility.Visible;

            //Wait for it to finish
            await Task.Delay((int)(seconds * 1000));

        }

        /// <summary>
        /// Slides an element out to the Bottom
        /// </summary>
        /// <param name="element">the element to animate</param>
        /// <param name="seconds">the time the animation will take</param>
        /// <returns></returns>
        public static async Task FadeOut(this FrameworkElement element, float seconds = 0.3f)
        {
            //Create the storyboard
            var sb = new Storyboard();

            //Add fade in animation
            sb.AddFadeOut(seconds);

            //Start animating 
            sb.Begin(element);

            //Make page visible
            element.Visibility = Visibility.Visible;

            //Wait for it to finish
            await Task.Delay((int)(seconds * 1000));

            // Fully hide the element
            element.Visibility = Visibility.Hidden;
        }

        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasetto_Word
{
    /// <summary>
    /// Style of page animations for appearing/disappearing
    /// </summary>
    public enum PageAnimation
    {
        /// <summary>
        /// No animation take place
        /// </summary>
        None = 0,
        /// <summary>
        /// The page slides in and fades in from right
        /// </summary>
        SlideAndFadeInFromRight = 1,
        /// <summary>
        /// The page slides out and fades out to the left
        /// </summary>
        SlideAndFadeOutToLeft = 2
    }
}

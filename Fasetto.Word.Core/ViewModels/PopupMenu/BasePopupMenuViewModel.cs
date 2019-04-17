using Fasetto.Word.Core;
using Fasetto.Word.Core.DataModels;

namespace Fasetto.Word.Core
{
    /// <summary>
    /// A view model for any popup meus
    /// </summary>
    public class BasePopupMenuViewModel : BaseViewModel
    {
        #region public properties

        /// <summary>
        /// The background color of the bubble in ARGB value
        /// </summary>
        public string BubbleBackground { get; set; }        

        /// <summary>
        /// The alignement of the bubble arrow
        /// </summary>
        public ElementHorizontalAlignment arrowAlignement { get; set; }

        /// <summary>
        /// The content inside of this popup menu
        /// </summary>
        public BaseViewModel Content { get; set; }


        #endregion

        #region Constructor

        public BasePopupMenuViewModel()
        {
            //Set default values
            // TODO: Move colors into core and make use of it here
            BubbleBackground = "ffffff";
            arrowAlignement = ElementHorizontalAlignment.Left;
        }

        #endregion

    }
}

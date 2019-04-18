using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Fasetto_Word
{
    public class DialogWindowViewModel : WindowViewModel
    {
        #region Public properties

        /// <summary>
        /// Title of this dialog window
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The content to host inside the dialog
        /// </summary>
        public Control Content { get; set; }

        #endregion

        #region Default constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public DialogWindowViewModel(Window window) : base(window)
        {
            //Setup minimum size
            WindowMinimumHeight = 100;
            WindowMinimumWidth = 250;

            //Setup title height
            TitleHeight = 30;
        } 
        #endregion

    }
}

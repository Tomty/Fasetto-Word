using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasetto.Word.Core
{
    /// <summary>
    /// Detail for a message box dialog
    /// </summary>
    public class MessageBoxDialogViewModel : BaseDialogViewModel
    {
        /// <summary>
        /// Message to display
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// Text for the ok button
        /// </summary>
        public string OkText { get; set; }
    }
}

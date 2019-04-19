using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasetto.Word.Core
{
    /// <summary>
    /// The UI Manager that handle any UI interaction in the application
    /// </summary>
    public interface IUIManager
    {
        /// <summary>
        /// Display a single message box to the user
        /// </summary>
        /// <param name="viewModel">the view model</param>
        /// <returns></returns>
        Task ShowMessage(MessageBoxDialogViewModel viewModel);
        
    }
}

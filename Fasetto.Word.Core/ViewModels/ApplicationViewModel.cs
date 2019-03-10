using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasetto.Word.Core.ViewModels
{
    /// <summary>
    /// The application state as a view model
    /// </summary>
    public class ApplicationViewModel : BaseViewModel
    {
        /// <summary>
        /// The current page of the application
        /// </summary>
        public ApplicationPage CurrentPage { get; set; } = ApplicationPage.Login;

        /// <summary>
        /// True if SideMenu is visible
        /// </summary>
        public bool SideMenuVisible { get; set; } = false;

        /// <summary>
        /// Navigate to the specified pae
        /// </summary>
        /// <param name="page">The page to go to</param>
        public void GoToPage(ApplicationPage page)
        {
            CurrentPage = page;

            // Show side menu or not ?

            SideMenuVisible = page == ApplicationPage.Chat;
        }
    }
}

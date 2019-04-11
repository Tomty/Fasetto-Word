
using Fasetto.Word.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Fasetto.Word.Core
{
    /// <summary>
    /// A view model for a chat message thread list
    /// </summary>
    public class ChatMessageListViewModel : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// The chat thread items for the list
        /// </summary>
        public List<ChatMessageListItemViewModel> Items { get; set; }

        /// <summary>
        /// True to show the attachement menu, false to hide 
        /// </summary>
        public bool AttachementMenuVisible { get; set; }

        public ChatAttachmentPopupMenuViewModel AttachmentMenu { get; set; }

        #endregion

        #region Public Commands

        /// <summary>
        /// The command for when the attachement button is clicked
        /// </summary>
        public ICommand AttachementButtonCommand { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Defautl constructor
        /// </summary>
        public ChatMessageListViewModel()
        {
            AttachementButtonCommand = new RelayCommand(AttachmentButton);

            //Make a default menu
            AttachmentMenu = new ChatAttachmentPopupMenuViewModel();
        }

        #endregion

        #region Command Methods

        /// <summary>
        /// When the attachement button is clicked show/hide the attachement popup
        /// </summary>
        public void AttachmentButton()
        {
            // toggle menu visibility
            AttachementMenuVisible ^= true;
        }

        #endregion

    }

}

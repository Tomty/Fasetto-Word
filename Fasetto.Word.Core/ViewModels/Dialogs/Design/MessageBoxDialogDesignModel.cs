using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasetto.Word.Core
{
    public class MessageBoxDialogDesignModel : MessageBoxDialogViewModel
    {
        #region Singleton
        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static MessageBoxDialogDesignModel Instance => new MessageBoxDialogDesignModel();
        #endregion

        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public MessageBoxDialogDesignModel()
        {
            Message = "Design time message";
            OkText = "OK";
        } 
        #endregion
    }
}

using System;
using System.Windows.Input;

namespace Fasetto.Word.Core
{
    /// <summary>
    /// 
    /// </summary>
    public class SettingsViewModel : BaseViewModel
    {
        #region Public command

        /// <summary>
        /// The command to close the settings menu
        /// </summary>
        public ICommand CloseCommand { get; set; }

        /// <summary>
        /// The command to open the settings menu
        /// </summary>
        public ICommand OpenCommand { get; set; }
        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public SettingsViewModel()
        {
            //Create commands
            CloseCommand = new RelayCommand(Close);
            OpenCommand = new RelayCommand(Open);
        }

        /// <summary>
        /// Open the settings menu
        /// </summary>
        private void Open()
        {
            IoC.IoC.Application.SettingsMenuVisible = true;
        }

        /// <summary>
        /// Closes the settings menu
        /// </summary>
        private void Close()
        {
            IoC.IoC.Application.SettingsMenuVisible = false;
        }

        #endregion
    }
}

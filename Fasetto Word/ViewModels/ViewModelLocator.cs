﻿using Fasetto.Word.Core;
using Fasetto.Word.Core.IoC;
using Fasetto.Word.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasetto_Word
{
    /// <summary>
    /// Locates view models from the IoC for use in binding in Xaml files
    /// </summary>
    public class ViewModelLocator
    {
        #region Public properties
        /// <summary>
        /// Singleton instance of the locator
        /// </summary>
        public static ViewModelLocator Instance { get; private set; } = new ViewModelLocator();
        #endregion

        /// <summary>
        /// The application view model
        /// </summary>
        public static ApplicationViewModel ApplicationViewModel => IoC.Application;


        /// <summary>
        /// The Settings view model
        /// </summary>
        public static SettingsViewModel SettingsViewModel => IoC.Settings;

    }
}

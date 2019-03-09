using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Fasetto.Word.Core
{
    /// <summary>
    /// Helpers for the <see cref="SecureString"/> class
    /// </summary>
    public static class SecureStringHelpers
    {
        /// <summary>
        /// Unsecure a <see cref="SecureString"/> to plain text
        /// </summary>
        /// <param name="secureString"></param>
        /// <returns></returns>
        public static string Unsecure(this SecureString secureString)
        {
            //make sure we have a secured string
            if (secureString == null)
                return string.Empty;

            //Get a pointer for an unsecure string in memory
            var unManagedString = IntPtr.Zero;

            try
            {
                unManagedString = Marshal.SecureStringToGlobalAllocUnicode(secureString);
                return Marshal.PtrToStringUni(unManagedString);

            }
            finally 
            {
                //Clean up any memory allocation
                Marshal.ZeroFreeGlobalAllocUnicode(unManagedString);
            }

        }
    }
}

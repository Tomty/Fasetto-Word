using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasetto.Word.Core
{
    /// <summary>
    /// Helpers class for <see cref="IconType"/>
    /// </summary>
    public static class IconTypeExtensions
    {
        /// <summary>
        /// convert <see cref="IconType"/> to a FontAwesome string
        /// <param name="type">The type to convert</param>           
        /// </summary>
        public static string ToFontAwesome(this IconType type)
        {
            //return a fontawesome string based on the icon type
            switch(type)
            {
                case (IconType.File):
                    return "\uf0f6";
                case (IconType.Picture):
                    return "\uf1c5";
                // if none found return null
                default:
                    return null;
            }
        }
    }
}

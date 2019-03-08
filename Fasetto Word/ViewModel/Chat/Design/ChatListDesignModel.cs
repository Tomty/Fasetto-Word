using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasetto_Word
{
    /// <summary>
    /// The design-time date for a <see cref="ChatListDesignModel"/>
    /// </summary>
    public class ChatListDesignModel : ChatListViewModel
    {

        #region singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static ChatListDesignModel Instance { get; } = new ChatListDesignModel(); 

        #endregion

        #region default constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public ChatListDesignModel()
        {
            Items = new List<ChatListItemViewModel>
            {
                new ChatListItemViewModel
                {
                    Name = "Luke",
                    Initials = "LM",
                    Message = "This chat app is awesome! I bet it will be fast too",
                    ProfilePictureRGB = "3009c5"
                },
                new ChatListItemViewModel
                {
                    Name = "Jesse",
                    Initials = "JA",
                    Message = "Hey dude, here are the new icons.",
                    ProfilePictureRGB = "fe4503"
                },
                new ChatListItemViewModel
                {
                    Name = "Parnell",
                    Initials = "PL",
                    Message = "The new server is up, go to 192.168.1.1",
                    ProfilePictureRGB = "00d405"
                },
            };
        }
        #endregion
    }
}

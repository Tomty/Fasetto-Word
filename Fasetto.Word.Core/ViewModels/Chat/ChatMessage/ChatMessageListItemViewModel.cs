﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasetto.Word.Core
{
    /// <summary>
    /// A view model for each chat message thread item in a chat thread
    /// </summary>
    public class ChatMessageListItemViewModel : BaseViewModel
    {
        /// <summary>
        /// The display name of the sender of the message
        /// </summary>
        public string SenderName { get; set; }

        /// <summary>
        /// The latest message form this chat list
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// The initials for the profile picture background
        /// </summary>
        public string Initials { get; set; }

        /// <summary>
        /// RGB value (in hex) for the background color of the profile picture
        /// </summary>
        public string ProfilePictureRGB { get; set; }

        /// <summary>
        /// True if this item is currently selected
        /// </summary>
        public bool IsSelected { get; set; }

        /// <summary>
        /// True if this message was sent by the signed in user 
        /// </summary>
        public bool SentByMe { get; set; }

        /// <summary>
        /// The time the message was read, or <see cref="DateTimeOffset.MinValue"/> if not read
        /// </summary>
        public DateTimeOffset MessageReadTime { get; set; }

        /// <summary>
        /// True if the message has been read
        /// </summary>
        public bool MessageRead => MessageReadTime > DateTimeOffset.MinValue;

        /// <summary>
        /// The time the message was sent
        /// </summary>
        public DateTimeOffset MessageSentTime { get; set; }
    }

}

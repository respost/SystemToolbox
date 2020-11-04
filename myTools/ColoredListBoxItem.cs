using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace myTools
{
    public class ColoredListBoxItem
    {
        /// <summary>
        /// creates a new ColoredListBoxItem
        /// </summary>
        /// <param name="prefix">the prefix which will be used</param>
        /// <param name="text">the real message</param>
        /// <param name="color">the color of both</param>
        public ColoredListBoxItem(DateTime time, string prefix, string text, Color color)
        {
            Time = time;
            Text = text;
            Prefix = prefix;
            TextColor = color;
        }

        /// <summary>
        /// the real message
        /// </summary>
        public DateTime Time { get; set; }

        /// <summary>
        /// the prefix of the text
        /// </summary>
        public string Prefix { get; set; }

        /// <summary>
        /// the real message
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// the color of the message
        /// </summary>
        public Color TextColor { get; set; }
    }

    public enum LogType
    {
        /// <summary>
        /// OpenVPN changed the internal state.l
        /// </summary>
        Created,

        /// <summary>
        /// The management interface wants to say something.
        /// </summary>
        Changed,

        /// <summary>
        /// A "normal" message is logged by OpenVPN via Management Interface.
        /// </summary>
        Deleted,

        /// <summary>
        /// A debug message is sent. This is primary for internal usage.
        /// </summary>
        Renamed
    }
 
}

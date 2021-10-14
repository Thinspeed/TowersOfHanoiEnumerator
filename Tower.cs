using System;
using System.Collections.Generic;
using System.Text;

namespace TowersOfHanoiEnumerator
{
    /// <summary>
    /// Represents a tower of Hanoi.
    /// </summary>

    public enum Tower : byte
    {
        /// <summary>
        /// First tower.
        /// </summary>
        From = 1,

        /// <summary>
        /// Second tower.
        /// </summary>
        Buffer,

        /// <summary>
        /// Third tower.
        /// </summary>
        To,

    }
}

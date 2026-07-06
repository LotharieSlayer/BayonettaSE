using System;

namespace BayonettaSE.Utils.Hex
{
    /// <summary>
    /// Functions that can be used to convert hex strings to dec values
    /// </summary>
    public class FieldConversions
    {
        /// <summary>
        /// Simply returns the value provided, no conversion necessary.
        /// </summary>
        public static Func<int, int> ToSimpleDecimal = hexValue => hexValue;
        /// <summary>
        /// Simply returns the value provided, no conversion necessary.
        /// </summary>
        public static Func<int, int> FromSimpleDecimal = decimalValue => decimalValue;
        /// <summary>
        /// Returns the hex provided as the equivalent decimal value that the user would see in-game.
        /// </summary>
        public static Func<int, int> ToCoreDecimal = hexValue => (hexValue - 1) / 8;
        /// <summary>
        /// Returns the decimal provided as the equivalent representation that would occur in the save file.
        /// </summary>
        public static Func<int, int> FromCoreDecimal = decimalValue => (decimalValue * 8) + 1;
    }
}
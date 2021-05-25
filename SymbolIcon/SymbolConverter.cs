using System;

namespace SymbolIcon
{
    public static class SymbolConverter
    {
        #region CharToSymbol
        /// <summary>
        /// Converts a <see cref="Char"/> value to a <see cref="Symbol"/>.
        /// </summary>
        /// <param name="glyph"></param>
        /// <returns></returns>
        // ReSharper disable once UnusedMember.Global
        public static Symbol CharToSymbol(char glyph) =>
            (Symbol)glyph;
        #endregion

        #region IntToSymbol
        /// <summary>
        /// Converts an <see cref="Int32"/> value to a <see cref="Symbol"/>.
        /// </summary>
        /// <param name="glyph"></param>
        /// <returns></returns>
        // ReSharper disable once UnusedMember.Global
        public static Symbol IntToSymbol(int glyph) =>
            (Symbol)glyph;
        #endregion

        #region SymbolToGlyph
        /// <summary>
        /// Converts a <see cref="Symbol"/> value to its icon.
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns></returns>
        public static string SymbolToGlyph(Symbol symbol) =>
            Convert.ToChar((int)symbol).ToString();
        #endregion
    }
}

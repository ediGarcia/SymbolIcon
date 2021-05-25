using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace SymbolIcon
{
    /// <inheritdoc cref="UserControl" />
    /// <summary>
    /// Interaction logic for FontIcon.xaml
    /// </summary>
    public partial class FontIcon
    {
        #region Properties

        /// <summary>
        /// Current icon.
        /// </summary>
        [Category("Appearance"), Description("Current icon.")]
        public Symbol Icon
        {
            get => (Symbol) GetValue(IconProperty);
            set => SetValue(IconProperty, value);
        }

        public static readonly DependencyProperty IconProperty = DependencyProperty.Register("Icon", typeof(Symbol), typeof(FontIcon),
            new FrameworkPropertyMetadata((Symbol)0, FrameworkPropertyMetadataOptions.AffectsRender,
                (o, args) => (o as FontIcon).TxbIcon.Text = SymbolConverter.SymbolToGlyph((Symbol)args.NewValue)));

        #endregion

        public FontIcon() =>
            InitializeComponent();
    }
}

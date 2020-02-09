using System.Windows;

namespace QIQI.Sample.WpfFontPicker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenFontDialogButton_Click(object sender, RoutedEventArgs e)
        {
            FontPicker1.OpenFontDialog();
        }
    }
}

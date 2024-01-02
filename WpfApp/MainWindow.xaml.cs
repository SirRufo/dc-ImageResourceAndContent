using System.Windows;
using System.Windows.Media.Imaging;

namespace WpfApp
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

        private void CntButton_Click( object sender, RoutedEventArgs e )
        {
            CustomImage.Source = new BitmapImage( new Uri( "/Images/cnt.png", UriKind.Relative ) );
        }
        private void ResButton_Click( object sender, RoutedEventArgs e )
        {
            CustomImage.Source = new BitmapImage( new Uri( "/Images/res.png", UriKind.Relative ) );
        }
    }
}
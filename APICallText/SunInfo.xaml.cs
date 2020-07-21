using APIHelperLibrary;
using System.Windows;

namespace APICallText
{
    /// <summary>
    /// Interaction logic for SunInfo.xaml
    /// </summary>
    public partial class SunInfo : Window
    {
        public SunInfo()
        {
            InitializeComponent();
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var sunInfo = await SunProcessor.LoadSunInfo(40.7128, -74.0060); // new york

            SunRiseTextBlock.Text = $"Sunrise is at {sunInfo.SunRise.ToLocalTime().ToShortTimeString()}";
            SunSetTextBlock.Text = $"Sunset is as {sunInfo.SunSet.ToLocalTime().ToShortTimeString()}";
        }

    }
}

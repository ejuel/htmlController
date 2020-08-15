// For roadmap of planned features, see: https://docs.google.com/document/d/1kg3DW67yjs3DcU9kXiGIHd91lLocttz44sFLUwcJQzk/edit?usp=sharing

using System.Threading;
using System.Windows;
using System.Windows.Forms;

namespace htmlController
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            while (true)
            {
                Thread.Sleep(5000);
                SendKeys.SendWait("A"); //Testing user inputs
            }
        }
        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            SendKeys.Send("A");
        }
    }
}

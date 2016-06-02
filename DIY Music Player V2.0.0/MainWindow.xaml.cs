using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DIY_Music_Player_V2._0._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PlayerUtilities utils;
        public MainWindow()
        {
            utils = new PlayerUtilities(this);
            InitializeComponent();
        }

        private void PlayPauseButton_Click(object sender, RoutedEventArgs e)
        {
            utils.PlayPause();
        }
    }
}

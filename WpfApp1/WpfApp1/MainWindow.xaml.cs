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

namespace WpfApp1
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

        private void Window_Closing(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.Activate();
        }

        private void GroupBoxkichthuocdam(object sender, TextChangedEventArgs e)
        {
            kichthuocdam.Visibility= Visibility.Visible;
        }

        private void GroupBoxkichthuocsan(object sender, TextChangedEventArgs e)
        {
            kichthuocsan.Visibility= Visibility.Visible;
        }
        private void GroupBoxvatlieu(object sender, TextChangedEventArgs e)
        {
            vankhuon.Visibility= Visibility.Visible;
        }
        private void GroupBoxtaitrong(object sender, TextChangedEventArgs e)
        {
            taitrong.Visibility= Visibility.Visible;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}

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

namespace SkypeMenuAdmin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //var uriSource = new Uri(@"c:\users\tanas\documents\visual studio 2015\Projects\SkypeMenuAdmin\SkypeMenuAdmin\Image\fmc.jpg");
            //image.Source = new BitmapImage(uriSource);
        }

        private void btnO365_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new MoveToO365();
         
        }

        private void btnOnPrem_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new MoveToOnPrem();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

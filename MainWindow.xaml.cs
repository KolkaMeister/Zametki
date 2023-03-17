using System;
using System.IO;
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

namespace Zametki
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            textBox.Text = File.ReadAllText(@"sourcetext");
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            var rows = textBox.Text.Split("\n");
            List<string> list = new List<string>();
            string final= null;
            foreach ( var row in rows )
            {
                if (row == "\r")
                    continue;
                final += row;
            }
            File.WriteAllText(@"sourcetext", final);
        }
        private void ColorChanged(object sender, RoutedEventArgs e)
        {
           // textBox.Foreground = ColorBox.SelectedValue.ToString();

        }
        private void SizeChanged(object sender, RoutedEventArgs e)
        {
            

        }
        private void FamilyChanged(object sender, RoutedEventArgs e)
        {
            

        }

    }

}

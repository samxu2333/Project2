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

namespace Project2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Make every ellipase in mainGrid to collapsed at the beginning
            foreach (object child in mainGrid.Children)
            {
                if (child is Ellipse ellipse)
                    {
                        ellipse.Visibility = Visibility.Collapsed;
                    }
            }
        }

        private void numberOfEllipses_TextChanged(object sender, TextChangedEventArgs e)
        {
            //convert textbox text to int
            if (int.TryParse(numberOfEllipses.Text, out int ellipseCount))
            {
                //use for loop to adjust ellipse nummber and show visiablity
                for (int i = 0; i < ellipseCount + 2 && i < mainGrid.Children.Count; i++)
                {
                    if (mainGrid.Children[i] is Ellipse ellipse)
                    {
                            ellipse.Visibility = Visibility.Visible;
                    }
                }
            }
        }
        // input can only be integer
        private void numberOfEllipses_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !int.TryParse(e.Text, out int result);
        }
    }
}

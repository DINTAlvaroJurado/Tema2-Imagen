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

namespace Tema2_Imagen
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Alta(object sender, RoutedEventArgs e)
        {
            if (buttonAlta.IsEnabled)
                imagen.Opacity = 1;
        }

        private void RadioButton_Media(object sender, RoutedEventArgs e)
        {
            if (buttonAlta.IsEnabled)
                imagen.Opacity = 0.6;
        }

        private void RadioButton_Baja(object sender, RoutedEventArgs e)
        {
            if (buttonAlta.IsEnabled)
                imagen.Opacity = 0.3;
        }

        private void buttonRelleno(object sender, RoutedEventArgs e)
        {
            if (relleno.IsEnabled)
                imagen.Stretch = Stretch.Fill;
        }

        private void buttonUniforme(object sender, RoutedEventArgs e)
        {
            if (relleno.IsEnabled)
                imagen.Stretch = Stretch.Uniform;
        }

        private void buttonRellenoUniforme(object sender, RoutedEventArgs e)
        {
            if (relleno.IsEnabled)
                imagen.Stretch = Stretch.UniformToFill;
        }

        private void buttonSinAjuste(object sender, RoutedEventArgs e)
        {
            if (relleno.IsEnabled)
                imagen.Stretch = Stretch.None;
        }
    }
}

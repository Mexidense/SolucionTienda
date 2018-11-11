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

namespace Tienda
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

        private void insertButton_Click(object sender, RoutedEventArgs e)
        {
            ServiceProductoReference.ServiceProductoClient service = new ServiceProductoReference.ServiceProductoClient();
            if (service.agregarProducto(Int32.Parse(codigoTextBox.Text), nombreTextBox.Text, Int32.Parse(valorTextBox.Text)))
                successTextBox.Text = "Producto insertado";

        }
    }
}

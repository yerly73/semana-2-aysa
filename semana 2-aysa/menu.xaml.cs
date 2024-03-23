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
using System.Windows.Shapes;

namespace semana_2_aysa
{
    /// <summary>
    /// Lógica de interacción para menu.xaml
    /// </summary>
    public partial class menu : Window
    {
        public menu()
        {
            InitializeComponent();
        }

        private void OperacionesButton_Click(object sender, RoutedEventArgs e)
        {
            Operaciones operaciones = new Operaciones();
            operaciones.Show();



        }
        private void MantenimientosButton_Click(object sender, RoutedEventArgs e)
        {
            Mantenimiento mantenimientos = new Mantenimiento ();
            mantenimientos.Show();



        }
        private void ReportesButton_Click(object sender, RoutedEventArgs e)
        {
            Reporte reportes = new Reporte();
            reportes.Show();



        }
    }
    }

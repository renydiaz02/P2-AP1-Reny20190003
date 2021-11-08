using P2_AP1_Reny20190003.UI.Consultas;
using P2_AP1_Reny20190003.UI.Registros;
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

namespace P2_AP1_Reny20190003
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

        private void ProyectosMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rProyecto proyecto = new rProyecto();
            proyecto.Show();
        }

        private void TiposTareasMenuItem_Click(object sender, RoutedEventArgs e)
        {
            cTiposTareas consulta = new cTiposTareas();
            consulta.Show();
        }

        private void ProyectoCMenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

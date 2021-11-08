using P2_AP1_Reny20190003.BLL;
using P2_AP1_Reny20190003.Entidades;
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

namespace P2_AP1_Reny20190003.UI.Consultas
{
    /// <summary>
    /// Interaction logic for cTiposTareas.xaml
    /// </summary>
    public partial class cTiposTareas : Window
    {
        public cTiposTareas()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var listado = new List<TiposTareas>();

            switch (FiltroComboBox.SelectedIndex)
            {
                case 0: //Listado
                    listado = TiposTareasBLL.GetTiposTarea();
                    break;
            }

            DatosDataGrid.ItemsSource = null;
            DatosDataGrid.ItemsSource = listado;
        }
    }
}

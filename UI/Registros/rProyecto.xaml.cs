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

namespace P2_AP1_Reny20190003.UI.Registros
{
    /// <summary>
    /// Interaction logic for rProyecto.xaml
    /// </summary>
    public partial class rProyecto : Window
    {
        private Proyectos proyecto = new Proyectos();

        private ProyectosDetalles detalles = new ProyectosDetalles();
        public rProyecto()
        {
            InitializeComponent();
            this.DataContext = proyecto;
            TipoTareaComboBox.ItemsSource = TiposTareasBLL.GetTiposTarea();
            TipoTareaComboBox.SelectedValuePath = "TipoTareaId";
            TipoTareaComboBox.DisplayMemberPath = "DescripcionTipoTarea";
            TotalTextBox.Text = "0";
        }
        private void Cargar()
        {
            this.DataContext = null;
            this.DataContext = proyecto;
        }
        private void Limpiar()
        {
            this.proyecto = new Proyectos();
            this.DataContext = proyecto;
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            Proyectos esValido = ProyectosBLL.Buscar(proyecto.ProyectoId);
            return (esValido != null);
        }
        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            Proyectos encontrado = ProyectosBLL.Buscar(proyecto.ProyectoId);

            if (encontrado != null)
            {
                proyecto = encontrado;
                Cargar();
            }
            else
            {
                Limpiar();
                MessageBox.Show("Hubo un Error, el Proyecto no está en la base de datos!", "ERROR", 
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void AgregarButton_Click(object sender, RoutedEventArgs e)
        {
            proyecto.Detalle.Add(new ProyectosDetalles(Convert.ToInt32(ProyectoIdTextBox.Text),
                (int)TipoTareaComboBox.SelectedValue, RequerimientoTextBox.Text, 
                int.Parse(TiempoTextBox.Text), (TiposTareas)TipoTareaComboBox.SelectedItem, proyecto));
            TotalTextBox.Text = proyecto.Total.ToString();

            Cargar();

            TotalTextBox.Focus();
            TotalTextBox.Clear();
        }

        private void RemoverFilaButton_Click(object sender, RoutedEventArgs e)
        {
            if (DetalleDataGrid.Items.Count >= 1 && DetalleDataGrid.SelectedIndex <= DetalleDataGrid.Items.Count - 1)
            {
                proyecto.Detalle.RemoveAt(DetalleDataGrid.SelectedIndex);
                proyecto.Total -= int.Parse(TotalTextBox.Text);
                Cargar();
            }
        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            bool paso = false;

            if (proyecto.ProyectoId == 0)
            {
                paso = ProyectosBLL.Guardar(proyecto);
            }
            else
            {
                if (ExisteEnLaBaseDeDatos())
                {
                    paso = ProyectosBLL.Guardar(proyecto);
                }
                else
                {
                    MessageBox.Show("No se halla en la base de datos!", "ERROR");
                }
            }

            if (paso)
            {
                Limpiar();

                MessageBox.Show("Guardado!", "Exito", MessageBoxButton.OK, 
                    MessageBoxImage.Information);
            }
            else
                MessageBox.Show("Falló al guardar!", "ERROR", 
                    MessageBoxButton.OK, MessageBoxImage.Error);

        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            Proyectos existe = ProyectosBLL.Buscar(proyecto.ProyectoId);

            if (existe == null)
            {
                MessageBox.Show("Grupo no encontrado en la base de datos", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);

                return;
            }
            else
            {
                ProyectosBLL.Eliminar(proyecto.ProyectoId);

                MessageBox.Show("Eliminado!", "Exito", 
                    MessageBoxButton.OK, MessageBoxImage.Information);

                Limpiar();
            }
        }
    }
}

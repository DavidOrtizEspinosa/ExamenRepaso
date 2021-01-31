using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ExamenRepaso
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<PrediccionDia> dias = new ObservableCollection<PrediccionDia>();

        public MainWindow()
        {
            InitializeComponent();
            dias = PrediccionDia.ObtenerDatos();
            tiempoSemana.DataContext = dias;
            formularioGrid.DataContext = tiempoSemana.SelectedItem;
        }
    }
}

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
using Modelo;
using Negócio;

namespace Telas
{
    /// <summary>
    /// Lógica interna para Disciplina.xaml
    /// </summary>
    public partial class Disciplina : Window
    {
        NDisciplina n = new NDisciplina();
        public Disciplina()
        {
            InitializeComponent();
            grid.ItemsSource = n.ListarDisciplina();
        }

        private void InsertClick(object sender, RoutedEventArgs e)
        {
            MDisciplina x = new MDisciplina();
            x.Nivel = txtnivel.Text;
            n.InserirDisciplina(x);
        }

        private void SelectClick(object sender, RoutedEventArgs e)
        {
            grid.ItemsSource = n.ListarDisciplina();
        }

        private void DeleteClick(object sender, RoutedEventArgs e)
        {
            if (grid.SelectedItem != null)
            {
                MDisciplina a = grid.SelectedItem as MDisciplina;
                n.ExcluirDisciplina(a);
                grid.ItemsSource = null;
                grid.ItemsSource = n.ListarDisciplina();
            }
        }

        private void grid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (grid.SelectedItem != null)
            {
                MDisciplina c = grid.SelectedItem as MDisciplina;
                c.Nivel = txtnivel.Text;
            }
            else
            {
                txtnivel.Text = null;
            }
        }
    }
}

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
using Negócio;
using Modelo;
namespace Telas
{
    /// <summary>
    /// Lógica interna para CadastroAluno.xaml
    /// </summary>
    public partial class CadastroAluno : Window
    {
        NAluno n = new NAluno(); 
        public CadastroAluno()
        {
            InitializeComponent();
            grid.ItemsSource = n.ListarAluno();
        }

        private void InsertClick(object sender, RoutedEventArgs e)
        {
            MAluno x = new MAluno();
            x.Nome = txtn.Text;
            x.Email = txte.Text;
            x.Nascimento = DateTime.Parse(txtnasci.Text);
            x.Senha = txts.Text;
            n.InserirAluno(x);
        }

        private void SelectClick(object sender, RoutedEventArgs e)
        {
            grid.ItemsSource = n.ListarAluno();
        }

        private void UpdateClick(object sender, RoutedEventArgs e)
        {
            MAluno x = new MAluno();
            x.Nome = txtn.Text;
            x.Email = txte.Text;
            x.Nascimento = DateTime.Parse(txtnasci.Text);
            x.Senha = txts.Text;
            n.AtualizarAluno(x);
            grid.ItemsSource = null;
            grid.ItemsSource = n.ListarAluno();
        }



        private void DeleteClick(object sender, RoutedEventArgs e)
        {
            if (grid.SelectedItem != null)
            {
                MAluno a = grid.SelectedItem as MAluno;
                n.ExcluirAluno(a);
                grid.ItemsSource = null;
                grid.ItemsSource = n.ListarAluno();
            }
        }

        private void grid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (grid.SelectedItem != null)
            {
                MProfessor c = grid.SelectedItem as MProfessor;
                txtn.Text = c.Nome;
                txte.Text = c.Email;
                txtnasci.Text = c.Nascimento.ToString();
                txts.Text = c.Senha;
            }
            else
            {
                txtn.Text = null;
                txte.Text = null;
                txtnasci.Text = null;
                txts.Text = null;
            }
        }

    }
}

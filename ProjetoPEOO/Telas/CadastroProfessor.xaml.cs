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
    /// Lógica interna para CadastroProfessor.xaml
    /// </summary>
    public partial class CadastroProfessor : Window
    {
        NProfessor n = new NProfessor();
        private int k;
        public CadastroProfessor()
        {
            InitializeComponent();
            grid.ItemsSource = n.ListarProfessor();
        }

        private void InsertClick(object sender, RoutedEventArgs e)
        {
            MProfessor x = new MProfessor();
            x.Nome = txtnome.Text;
            x.Email = txtemail.Text;
            x.Nascimento = DateTime.Parse(txtnascimento.Text);
            x.Senha = txtsenha.Text;
            x.Formacao = txtform.Text;
            n.InserirProfessor(x);
            grid.ItemsSource = n.ListarProfessor();

        }

        private void SelectClick(object sender, RoutedEventArgs e)
        {
            
        }

        private void UpdateClick(object sender, RoutedEventArgs e)
        {
            MProfessor x = new MProfessor();
            x.Nome = txtnome.Text;
            x.Email = txtemail.Text;
            x.Nascimento = DateTime.Parse(txtnascimento.Text);
            x.Senha = txtsenha.Text;
            x.Formacao = txtform.Text;
            x.Id = (grid.SelectedItem as MProfessor).Id;
            n.AtualizarProfessor(x);
            grid.ItemsSource = null;
            grid.ItemsSource = n.ListarProfessor();
        }

        private void DeleteClick(object sender, RoutedEventArgs e)
        {
            if (grid.SelectedItem != null)
            {
                MProfessor a = grid.SelectedItem as MProfessor;
                n.ExcluirProfessor(a);
                grid.ItemsSource = null;
                grid.ItemsSource = n.ListarProfessor();
            }

        }
        private void grid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (grid.SelectedItem != null)
            {
                MProfessor c = grid.SelectedItem as MProfessor;
                txtnome.Text = c.Nome;
                txtemail.Text = c.Email;
                txtnascimento.Text = c.Nascimento.ToString();
                txtsenha.Text = c.Senha;
                txtform.Text = c.Formacao;
            }
            else
            {
                txtnome.Text = null;
                txtemail.Text = null;
                txtnascimento.Text = null;
                txtsenha.Text = null;
                txtform.Text = null;
            }
        }
    }
}

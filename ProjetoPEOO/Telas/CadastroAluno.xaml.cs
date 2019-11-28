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
        private int k;
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
            string l = null;
            if(k>=1 && k < 10) l = "20191011110000"+k.ToString();
            else if(k >= 10 && k < 100)l = "2019101111000" + k.ToString();
            else if (k >= 100 && k < 1000)l = "201910111100" + k.ToString();
            else if (k >= 1000 && k < 10000) l = "2019101111" + k.ToString();
            x.Matricula = l;
            n.InserirAluno(x);
            grid.ItemsSource = n.ListarAluno();
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
            string l = null;
            if (k >= 1 && k < 10) l = "20191011110000" + k.ToString();
            else if (k >= 10 && k < 100) l = "2019101111000" + k.ToString();
            else if (k >= 100 && k < 1000) l = "201910111100" + k.ToString();
            else if (k >= 1000 && k < 10000) l = "2019101111" + k.ToString();
            x.Matricula = l;
            n.AtualizarAluno(x);
            grid.ItemsSource = null;
            grid.ItemsSource = n.ListarAluno();
        }

        private void grid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (grid.SelectedItem != null)
            {
                MAluno a = grid.SelectedItem as MAluno;

            }
        }

        private void DeleteClick(object sender, RoutedEventArgs e)
        {
            MAluno x = new MAluno();
            x.Id = int.Parse(txtid.Text);
            n.ExcluirAluno(x);
            grid.ItemsSource = null;
            grid.ItemsSource = n.ListarAluno();
        }
    }
}

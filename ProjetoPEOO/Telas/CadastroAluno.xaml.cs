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
using Microsoft.Win32;
using System.IO;

namespace Telas
{
    /// <summary>
    /// Lógica interna para CadastroAluno.xaml
    /// </summary>
    public partial class CadastroAluno : Window
    {
        NAluno n = new NAluno();
        private string foto = String.Empty;

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
            x.Foto = foto;
            x.Nascimento = DateTime.Parse(txtnasci.Text);
            x.Senha = txts.Text;
            n.InserirAluno(x);
            txtn.Text = null;
            foto = null;
            txte.Text = null;
            txts.Text = null;
            txtnasci.Text = null;
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

        private void AddFotoClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog w = new OpenFileDialog();
            w.Filter = "Arquivos Jpg|*.jpg";
            if (w.ShowDialog().Value)
            {
                byte[] b = File.ReadAllBytes(w.FileName);
                foto = Convert.ToBase64String(b);

                BitmapImage bi = new BitmapImage();
                bi.BeginInit();
                bi.StreamSource = new MemoryStream(b);
                bi.EndInit();

                image.Source = bi;
            }
        }
    }
}

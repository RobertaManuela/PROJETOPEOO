using System;
using System;
using Microsoft.Win32;
using System.Collections.Generic;
using System.Linq;
using System.IO;
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

namespace Telas
{
    /// <summary>
    /// Lógica interna para Professor.xaml
    /// </summary>
    public partial class Professor : Window
    {
        public Professor(MProfessor a)
        {   

            InitializeComponent();
            InitializeComponent();
            txtNome.Text = a.Nome;
            txtEmail.Text = a.Email;
            txtMatricula.Text = a.Matricula;
            txtSenha.Text = a.Senha;
            txtNascimento.Text = a.Nascimento.ToString();

            OpenFileDialog w = new OpenFileDialog();
            w.Filter = "Arquivos Jpg|*.jpg";
            byte[] b = Convert.FromBase64String(a.Foto);

            BitmapImage bi = new BitmapImage();
            bi.BeginInit();
            bi.StreamSource = new MemoryStream(b);
            bi.EndInit();

            img.Source = bi;
        }

        private void ListarTurmasClick(object sender, RoutedEventArgs e)
        {

        }

        private void UpdateClick(object sender, RoutedEventArgs e)
        {

        }
    }
}

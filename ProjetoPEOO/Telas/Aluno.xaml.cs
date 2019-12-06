using System;
using Microsoft.Win32;
using System.Collections.Generic;
using System.Linq;
using System.IO;
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
    /// Lógica interna para Aluno.xaml
    /// </summary>
    public partial class Aluno : Window
    {
        public Aluno(MAluno a)
        {
            InitializeComponent();
            txtN.Text = a.Nome;
            txtE.Text = a.Email;
            txtM.Text = a.Matricula;
            txtS.Text = a.Senha;
            txtNasci.Text = a.Nascimento.ToString();

            OpenFileDialog w = new OpenFileDialog();
            w.Filter = "Arquivos jpg|*.jpg";
            byte[] b = Convert.FromBase64String(a.Foto);

            BitmapImage bi = new BitmapImage();
            bi.BeginInit();
            bi.StreamSource = new MemoryStream(b);
            bi.EndInit();

            img.Source = bi;
        }

        private void UpdateClick(object sender, RoutedEventArgs e)
        {

        }
    }
}

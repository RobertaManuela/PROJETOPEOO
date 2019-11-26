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
using Aluno;

namespace TELAS
{
    /// <summary>
    /// Lógica interna para CadastroAluno.xaml
    /// </summary>
    public partial class CadastroAluno : Window
    {
        public CadastroAluno()
        {
            InitializeComponent();
            SelectClick(null, null);
        }

        private void SelectClick(object sender, RoutedEventArgs e)
        {
            NAluno n = new Aluno();
            grid.ItemsSource = null;
            grid.ItemsSource = n.Select();
        }
    }

        private void InsertClick(object sender, RoutedEventArgs e)
        {
            MAluno m = new MAluno();
            m.Nome = txtn.Text;
            m.Email = txte.Text;
            m.Nascimento = DateTime.Parse(txtnasci.Text);

            NAluno n = new NAluno();
            n.Inserir(m);

            SelectClick(sender, e);
    }

        private void UpdateClick(object sender, RoutedEventArgs e)
        {
            MAluno m = new MAluno();
            m.Nome = txtn.Text;
            m.Email = txte.Text;
            m.Nascimento = DateTime.Parse(txtnasci.Text);

            NAluno n = new NAluno();
            n.Update(m);

            SelectClick(sender, e);
    }

        private void DeleteClick(object sender, RoutedEventArgs e)
        {
            MAluno m = new MAluno();
            m.Id = int.Parse(txtId.Text);

            NAluno n = new NAluno();
            n.Delete(m);

            SelectClick(sender, e);
    }
  }
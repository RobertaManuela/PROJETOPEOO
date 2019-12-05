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

namespace Telas
{
    /// <summary>
    /// Lógica interna para Administrador.xaml
    /// </summary>
    public partial class Administrador : Window
    {
        public Administrador()
        {
            InitializeComponent();
        }

        private void cad_Aluno(object sender, RoutedEventArgs e)
        {
            Window a = new CadastroAluno();
            a.ShowDialog();
        }

        private void cad_Prof(object sender, RoutedEventArgs e)
        {
            Window p = new CadastroProfessor();
            p.ShowDialog();
        }

        private void cad_Turma(object sender, RoutedEventArgs e)
        {
            Window t = new CadastroTurma();
            t.ShowDialog();
        }

        private void cad_Discs(object sender, RoutedEventArgs e)
        {
            Window d = new Disciplina();
            d.ShowDialog();
        }

        private void cad_alunoturma(object sender, RoutedEventArgs e)
        {
            Window at = new MatriculaAluno();
            at.ShowDialog();
        }
    }
}

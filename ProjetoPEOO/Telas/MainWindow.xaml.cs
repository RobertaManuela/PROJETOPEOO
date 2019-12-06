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
    /// Lógica interna para Login.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnEntrar(object sender, RoutedEventArgs e)
        {
            bool logou = false;
            MAluno u = new MAluno();
            MProfessor a = new MProfessor();
            int i = 0;
            do
            {
                logou = VerificarSenha(ref i, txtUsuario.Text, txtSenha.Password, ref u,ref a);
                if (!logou) MessageBox.Show("Usuário ou senha inválidos");
                else break;
            } while (logou);
            if (logou)
            {
                if (i == 0)
                {
                    Window janela = new Administrador();
                    Close();
                    janela.ShowDialog();
                }
                else if (i == 1)
                {
                    Window janela = new Aluno(u);
                    Close();
                    janela.ShowDialog();
                }
                else if (i == 2)
                {
                    Window janela = new Professor(a);
                    Close();
                    janela.ShowDialog();
                }
            }
        }
        public static bool VerificarSenha(ref int p, string n, string s, ref MAluno u, ref MProfessor a)
        {
            bool r = false;
            if (n == "Admin")
            {
                r = s == "admin";
                p = 0;
            }
            if (r == false)
            {
                NProfessor f = new NProfessor();
                List<MProfessor> lis = f.ListarProfessor();
                foreach (MProfessor x in lis)
                {
                    if (x.Matricula == n && s == x.Senha)
                    {
                        r = true;
                        p = 2;
                        a = x;
                        break;
                    }
                }
            }
            if (r == false)
            {
                NAluno e = new NAluno();
                List<MAluno> b = e.ListarAluno();
                foreach (MAluno x in b)
                {
                    if (x.Matricula == n && s == x.Senha)
                    {
                        r = true;
                        p = 1;
                        u = x;
                        break;
                    }
                }
            }
            return r;
        }
    }
    
}

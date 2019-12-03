﻿using System;
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
    /// Lógica interna para CadastroTurma.xaml
    /// </summary>
    public partial class CadastroTurma : Window
    {
        NTurma n = new NTurma();
        public CadastroTurma()
        {
            InitializeComponent();
            Cb.ItemsSource = n.ListarDisciplinas();
            Bc.ItemsSource = n.ListarTurma();
        }

        private void InsertClick(object sender, RoutedEventArgs e)
        {
            MTurma x = new MTurma();
            x.Semestre = txtSemestre.Text;
            Cb.SelectedItem
            n.InserirTurma(x);
        }

        private void SelectClick(object sender, RoutedEventArgs e)
        {
            grid.ItemsSource = n.ListarTurma();
        }

        private void UpdateClick(object sender, RoutedEventArgs e)
        {
            MTurma x = new MTurma();
            x.Semestre = txtSemestre.Text;
            n.AtualizarTurma(x);
            grid.ItemsSource = null;
            grid.ItemsSource = n.ListarTurma();
        }

        private void DeleteClick(object sender, RoutedEventArgs e)
        {
            if (grid.SelectedItem != null)
            {
                MTurma a = grid.SelectedItem as MTurma;
                n.ExcluirTurma(a);
                grid.ItemsSource = null;
                grid.ItemsSource = n.ListarTurma();
            }
        }

        private void grid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (grid.SelectedItem != null)
            {
                MTurma c = grid.SelectedItem as MTurma;
                x.Semestre = txtSemestre.Text;
            }
            else
            {
                txtSemestre.Text = null;
            }
        }
    }
}

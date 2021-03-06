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

namespace ChatBot
{
    /// <summary>
    /// Lógica de interacción para Configuracion.xaml
    /// </summary>
    /// 
    
    public partial class Configuracion : Window
    {
        public string ColorFondo { get; set; }
        public string ColorUsuario { get; set; }
        public string ColorRobot { get; set; }
        public string Sexo { get; set; }
        public Configuracion()
        {
            ColorFondo = Properties.Settings.Default.ColorFondo;
            ColorUsuario = Properties.Settings.Default.ColorUsuario;
            ColorRobot = Properties.Settings.Default.ColorRobot;
            Sexo = Properties.Settings.Default.Sexo;

            InitializeComponent();
            DataContext = this;
            

            colorFondo.ItemsSource = typeof(Colors).GetProperties();
            colorUsuario.ItemsSource = typeof(Colors).GetProperties();
            colorRobot.ItemsSource = typeof(Colors).GetProperties();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
   
            DialogResult = true;
        }
    }
}

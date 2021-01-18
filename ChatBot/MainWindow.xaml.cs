using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChatBot
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Mensaje> listaMensaje = new ObservableCollection<Mensaje>();
        public MainWindow()
        {
            InitializeComponent();
            
            ItemsControl.DataContext = listaMensaje;

        }

        private void CommandBinding_Executed_Nueva(object sender, ExecutedRoutedEventArgs e)
        {

            listaMensaje.Clear();
        }

        private void CommandBinding_CanExecute_Nueva(object sender, CanExecuteRoutedEventArgs e)
        {
            if (listaMensaje.Count > 0)
            {
                e.CanExecute = true;
            }
            else
            {
                e.CanExecute = false;
            }
        }

        private void CommandBinding_Executed_Guardar(object sender, ExecutedRoutedEventArgs e)
        {
            String conversacion = "";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Txt Files|*.txt";
            if (saveFileDialog.ShowDialog() == true)
            {
                
                for (int i = 0; i < listaMensaje.Count; i++)
                {
                    conversacion += listaMensaje[i].Emisor + "\n-->" + listaMensaje[i].MensajeUsu + "\n";
                }

                File.WriteAllText(saveFileDialog.FileName, conversacion);
            }
        }

        private void CommandBinding_CanExecute_Guardar(object sender, CanExecuteRoutedEventArgs e)
        {
            if (listaMensaje.Count > 0)
            {
                e.CanExecute = true;
            }
            else
            {
                e.CanExecute = false;
            }
        }

        private void CommandBinding_Executed_Salir(object sender, ExecutedRoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void CommandBinding_Executed_ComprobarConexion(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Conexión correcta con el servidor del Bot", "Comprobar conexión", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void CommandBinding_CanExecute_ComprobarConexion(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CommandBinding_Executed_Configuracion(object sender, ExecutedRoutedEventArgs e)
        {
            Configuracion configuracionWindow = new Configuracion();

            configuracionWindow.Title = "Configuración de la aplicación";
            configuracionWindow.Owner = this;
            if (configuracionWindow.ShowDialog() == true)

            {

                Properties.Settings.Default.ColorFondo = configuracionWindow.ColorFondo;
                Properties.Settings.Default.ColorUsuario = configuracionWindow.ColorUsuario;
                Properties.Settings.Default.ColorRobot = configuracionWindow.ColorRobot;
                Properties.Settings.Default.Sexo = configuracionWindow.Sexo;

                Properties.Settings.Default.Save();

            }
        }

        private void CommandBinding_CanExecute_Configuracion(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CommandBinding_Executed_Enviar(object sender, ExecutedRoutedEventArgs e)
        {
            listaMensaje.Add(new Mensaje("Usuario", mensajeTextBox.Text));
            listaMensaje.Add(new Mensaje("Bot", "Lo siento, estoy un poco cansado para hablar."));
            mensajeTextBox.Text = "";
            scrollChatScrollViewer.ScrollToEnd();
        }


        private void CommandBinding_CanExecute_Enviar(object sender, CanExecuteRoutedEventArgs e)
        {

            if (mensajeTextBox != null && mensajeTextBox.Text != "")
            {
                e.CanExecute = true;
            }
            else
            {
                e.CanExecute = false;
            }
        }
    }
}

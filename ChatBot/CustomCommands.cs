using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ChatBot
{
    public static class CustomCommands
    {

        public static readonly RoutedUICommand Nueva = new RoutedUICommand(

            "Nueva Conversacion",
            "Nueva",
            typeof(CustomCommands),
            new InputGestureCollection
                {
                    new KeyGesture(Key.N, ModifierKeys.Control)
                }

            );

        public static readonly RoutedUICommand Guardar = new RoutedUICommand(

            "Guardar Conversacion",
            "Guardar",
            typeof(CustomCommands),
            new InputGestureCollection
                {
                    new KeyGesture(Key.G, ModifierKeys.Control)
                }

            );

        public static readonly RoutedUICommand Salir = new RoutedUICommand(

            "Salir",
            "Salir",
            typeof(CustomCommands),
            new InputGestureCollection
                {
                    new KeyGesture(Key.S, ModifierKeys.Control)
                }

            );

        public static readonly RoutedUICommand ComprobarConexion = new RoutedUICommand(

            "ComprobarConexion",
            "ComprobarConexion",
            typeof(CustomCommands),
            new InputGestureCollection
                {
                    new KeyGesture(Key.O, ModifierKeys.Control)
                }

            );

        public static readonly RoutedUICommand Configuracion = new RoutedUICommand(

            "Configuracion",
            "Configuracion",
            typeof(CustomCommands),
            new InputGestureCollection
                {
                    new KeyGesture(Key.C, ModifierKeys.Control)
                }

            );

        public static readonly RoutedUICommand Enviar = new RoutedUICommand(

            "Enviar",
            "Enviar",
            typeof(CustomCommands),
            new InputGestureCollection
                {
                    new KeyGesture(Key.Enter)
                }

            );
    }
}

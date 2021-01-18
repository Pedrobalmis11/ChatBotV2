using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot
{
    class Mensaje : INotifyPropertyChanged
    {

        private string _emisor;

        public string Emisor
        {
            get { return _emisor; }
            set
            {
                _emisor = value;
                NotifyPropertyChanged("Emisor");
            }
        }


        private string _mensajeusu;

        public string MensajeUsu
        {
            get { return _mensajeusu; }
            set
            {
                _mensajeusu = value;
                NotifyPropertyChanged("MensajeUsu");
            }
        }

        public Mensaje()
        {
        }

        public Mensaje(string emisor, string mensajeusu)
        {
            Emisor = emisor;
            MensajeUsu = mensajeusu;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

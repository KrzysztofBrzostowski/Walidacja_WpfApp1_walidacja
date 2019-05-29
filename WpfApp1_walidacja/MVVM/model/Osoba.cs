using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1_walidacja.MVVM.model
{
    public class Osoba : INotifyPropertyChanged, IDataErrorInfo     
    {
        private string m_imie;

        public string Imie
        {
            get { return m_imie; }
            set
            {
                m_imie = value;
                Powiadom("Imie");
            }
        }

        public string Error => "";//dla obiektu

        public string this[string columnName]
        {
            get
            {
                if (Imie != "Krzysztof")
                {
                    return "Wlasciwosc bledna";

                }
                else
                    return null;
            }
        }

        void Powiadom(string nazwaWlasciwosci)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(nazwaWlasciwosci));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }

}

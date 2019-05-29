using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfApp1_walidacja.MVVM.model;

namespace WpfApp1_walidacja.MVVM.viewModel
{

    public class osobaViewModel
    {
        public Func<object, bool> TrueFunc = new Func<object, bool>(o => { return true; });
        public Osoba Osoba { get; set; }
        public ICommand Zatwierdz { get; set; }

        public osobaViewModel()
        {
            this.Osoba = new Osoba();
            this.Zatwierdz = new CommandBase(ZatwierdzAction, TrueFunc);
        }

        void ZatwierdzAction(object param)
        {
            MessageBox.Show(Osoba.Imie);
        }

    }
}

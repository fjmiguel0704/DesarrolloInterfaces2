using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BIblioteca;

namespace Ejercicio3.ViewModel
{
    internal class MainPageVM : clsPersona, INotifyPropertyChanged
    {
        private String nombre;
        public override String propertyName
        {
            get { return nombre;  }
            set { nombre = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Entry : INotifyPropertyChanged
    {
        private Slider valorSlider;
        private int tamañoEntry;
        private int tamañoLabel;

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string property)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(property));
        }

        public Slider Slider
        {
            get { return valorSlider; }
            set
            {
                if (valorSlider != value)
                {
                    valorSlider = value;
                    OnPropertyChanged("Slider");
                }
            }
        }

        public int EntrySize
        {
            get { return tamañoEntry; }
            set
            {
                if (tamañoEntry != value)
                {
                    tamañoEntry = value;
                    OnPropertyChanged("EntrySize");
                    RecalcularLabelSize(); // Calcula el nuevo tamaño del Label
                }
            }
        }

        public int LabelSize
        {
            get { return tamañoLabel; }
            private set
            {
                if (tamañoLabel != value)
                {
                    tamañoLabel = value;
                    OnPropertyChanged("LabelSize");
                }
            }
        }

        private void RecalcularLabelSize()
        {
            // Puedes ajustar esta fórmula según tus necesidades
            LabelSize = tamañoEntry * 2; // Ejemplo: el doble del tamaño de Entry
        }
    }
}

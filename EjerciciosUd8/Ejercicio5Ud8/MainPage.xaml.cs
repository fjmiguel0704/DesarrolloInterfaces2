using Entidades;
using System.Collections.ObjectModel;

namespace Ejercicio5Ud8
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            ObservableCollection<Persona> listadoPersonas = new ObservableCollection<Persona>(ListadoPersonas.listarPersonas());

            BindingContext = this;

            ListaContactosView.ItemsSource = listadoPersonas;
        }
    }
}
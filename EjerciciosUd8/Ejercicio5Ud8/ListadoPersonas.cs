using Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5Ud8
{
    static class ListadoPersonas
    {
        static ObservableCollection<Persona> listadoPersonas = new ObservableCollection<Persona>();
        public static ObservableCollection<Persona> listarPersonas()
        {
            listadoPersonas.Add(new Persona("Carlos", "Jimenez"));
            listadoPersonas.Add(new Persona("Antonio", "Jimenez"));
            listadoPersonas.Add(new Persona("Antonio", "Mayo"));
            listadoPersonas.Add(new Persona("Marta", "Lopez"));
            listadoPersonas.Add(new Persona("Fernando", "Miguel"));
            listadoPersonas.Add(new Persona("Claudia", "Garrido"));
            listadoPersonas.Add(new Persona("Nicolás", "Villalobo"));
            listadoPersonas.Add(new Persona("Lucia", "Lorence"));
            listadoPersonas.Add(new Persona("Sergio", "Ramirez"));
            listadoPersonas.Add(new Persona("Cristian", "Miguez"));

            return listadoPersonas;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public class clsPersona : INotifyPropertyChanged
    {
        #region atributos
        private String nombre;
        private String apellidos;
        private int edad;
        #endregion

        #region constructores
        public clsPersona()
        {
            nombre = "Fernando";
        }
        public clsPersona(string nombre)
        {
            this.nombre = nombre;
        }

        public clsPersona(String nombre, String apellidos, int edad)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.edad = edad;
        }
        #endregion

        #region propiedades
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value;
                OnPropertyChanged();
            }
        }

        public String Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public String nombreCompleto
        {
            get { return $"Su nombre completo es: {nombre} {apellidos}"; }
        }  

        public String FuncionNombreCompleto()
        {
            return $"Su nombre completo es: {nombre} {apellidos}";
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName]string property = null) { 
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));          
        }
    }
}

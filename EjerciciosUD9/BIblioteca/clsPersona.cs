using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BIblioteca
{
    public class clsPersona
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
            set
            {
                nombre = value;
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
    }
}
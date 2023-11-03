namespace Entidades
{
    public class Persona
    {
        #region atributos
        private String nombre;
        private String apellidos;
        private int idDept;
        #endregion

        #region constructores
        public Persona()
        {
            nombre = "";
        }

        public Persona(String nombre, String apellidos)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
        }
        #endregion

        #region propiedades
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public String Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public int IdDept
        {
            get { return idDept; }
            set { idDept = value; }
        }

        public String Direccion { get; set; }

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

namespace Ferremax.API.Models

{
    public class Cliente
    {
        public int id { get; set; }
        public string razonSocial { get; set; }

        public string rut { get; set; }

        public string direccion { get; set; }

        public string nombre { get; set; }

        public string apellido { get; set; }

        public string telefono { get; set; }




        public Cliente(int id, String razonSocial, String rut, String direccion, String nombre, String apellido, String telefono)
        {
            this.id = id;
            this.razonSocial = razonSocial;
            this.rut = rut;
            this.direccion = direccion;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;



        }

        public Cliente()
        {
            this.id = new int();
            this.razonSocial = string.Empty;
            this.rut = string.Empty;
            this.direccion = string.Empty;
            this.nombre = string.Empty;
            this.apellido = string.Empty;
            this.telefono = string.Empty;

        }

    }

}
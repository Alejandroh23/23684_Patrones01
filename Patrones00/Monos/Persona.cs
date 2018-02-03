using System;
namespace Patrones00.Models
{
    public abstract class Persona
    {
        private String nombre;
        private int Edad;
        private camina formacaminar;

        public Persona(String nombre, int Edad, camina formacaminar)
        {
            this.nombre = nombre;
            this.Edad = Edad;
            this.formacaminar = formacaminar;
        }

        public void eat()
        {
            Console.Write("Yo como.");
        }

        public void GO2()
        {
            Console.Write("Estoy en el baño.");
        }

        public void walking()
        {
            this.formacaminar.walking();
        }
    }
}
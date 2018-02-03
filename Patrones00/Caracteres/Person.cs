using System;

namespace Patrones00
{
    public abstract class Person
    {
        private String nombre;
        private int Edad;
        private walk walkBehavior;

        public Person(String nombre, int Edad, walk walkBehavior)
        {
            this.nombre = nombre;
            this.Edad = Edad;
            this.walkBehavior = walkBehavior;
        }

        public void eat()
        {
            System.out.println("Estoy comiendo.");
        }

        public void baño()
        {
            System.out.println("Estoy del uno.");
        }

        public void caminar()
        {
            this.walkBehavior.caminar();
        }
    }
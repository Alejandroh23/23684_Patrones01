import Persona;
import Student;
import Prof;
import camionero;
import No pass;
import camina;
import Overtwofeet;
import Sobremanos;

using System;

namespace Patrones00
{
    public class Main
    {
        public static void main(String[] args)
        {
            Prof profe = new Prof("Ricardo", 29, new Ontwofeet());
            profe.caminar();

            Student stud = new Student("Alex", 22, new Overhands());
            stud.caminar();

            Camion camionero = new Camion("Trumpitas", 69, new Nopass());
            camionero.caminar();
        }
    }
}
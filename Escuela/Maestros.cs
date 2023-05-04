/*Instituto Tecnologico Superior de Cintalapa
Programación Orientada a Objetos
Alumno: Darwin Amaury Nataren Arellano
Profesor: Jorge Ivan Bermudez Rodriguez
Unidad: 03
Practica: Escuela Herencia y Polimorfismo
*/
using System;
using System.Collections.Generic;

namespace Universidad
{
    public class Maestros : Escuela
    {
        public Maestros(string nombre, string apellidoP, string apellidoM)
        {
            Nombre = nombre;
            ApPaterno = apellidoP;
            ApMaterno = apellidoM;
        }

        public Maestros(string curp, string nombre)
        {
            Nombre = nombre;
            CURP = curp;
        }

        public Maestros(string nombre, DateTime fecha)
        {
            Nombre = nombre;
            FechaN = fecha;
        }

        public Maestros(int matricula, string nombre)
        {
            Matricula = matricula;
            Nombre = nombre;
        }

        public Maestros(string nombre, string curp, int matricula)
        {
            Nombre = nombre;
            CURP = curp;
            Matricula = matricula;
        }
    }
}
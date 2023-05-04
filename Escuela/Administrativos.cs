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
    public class Administrativos : Escuela
    {
        public Administrativos(string nombre, string apellidoP, string apellidoM)
        {
            Nombre = nombre;
            ApPaterno = apellidoP;
            ApMaterno = apellidoM;
        }

        public Administrativos(string curp, string nombre)
        {
            Nombre = nombre;
            CURP = curp;
        }

        public Administrativos(string nombre, DateTime fecha)
        {
            Nombre = nombre;
            FechaN = fecha;
        }

        public Administrativos(int matricula, string nombre)
        {
            Matricula = matricula;
            Nombre = nombre;
        }

        public Administrativos(string nombre, string curp, int matricula)
        {
            Nombre = nombre;
            CURP = curp;
            Matricula = matricula;
        }
    }
}
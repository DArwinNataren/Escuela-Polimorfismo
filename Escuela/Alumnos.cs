/*Instituto Tecnologico Superior de Cintalapa
Programación Orientada a Objetos
Alumno: Darwin Amaury Nataren Arellano
Profesor: Jorge Ivan Bermudez Rodriguez
Unidad: 03
Practica: Escuela Herencia y Polimorfismo
*/
using System;
namespace Universidad
{
    public class Alumnos : Escuela
    { 
            public Alumnos(string nombre, string apellidoP, string apellidoM)
            {
                Nombre = nombre;
                ApPaterno = apellidoP;
                ApMaterno = apellidoM;
            }

            public Alumnos(string curp, string nombre)
            {
                Nombre = nombre;
                CURP = curp;
            }

            public Alumnos(string nombre, DateTime fecha)
            {
                Nombre = nombre;
                FechaN = fecha;
            }

            public Alumnos(int matricula, string nombre)
            {
                Matricula = matricula;
                Nombre = nombre;
            }

            public Alumnos(string nombre, string curp, int matricula)
            {
                Nombre = nombre;
                CURP = curp;
                Matricula = matricula;
            }
    }
}
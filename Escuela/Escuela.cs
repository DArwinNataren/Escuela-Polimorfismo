/*Instituto Tecnologico Superior de Cintalapa
Programación Orientada a Objetos
Alumno: Darwin Amaury Nataren Arellano
Profesor: Jorge Ivan Bermudez Rodriguez
Unidad: 03
Practica: Escuela Herencia y Polimorfismo
*/
using System;
using System.Data;

namespace Universidad
{
    public class Escuela
    {
        public int Matricula { get; set; }
        public string Nombre { get; set; }
        public string ApMaterno { get; set; }
        public string ApPaterno { get; set; }
        public DateTime FechaN { get; set; }
        public string CURP { get; set; }
        //::::::::::::::::::::::::::::::::
        public int _Matricula
        { get => Matricula; set => Matricula = value; }
        public string _Nombre
        { get => Nombre; set => Nombre = value; }
        public string _ApellidoPaterno
        { get => ApPaterno; set => ApPaterno = value; }
        public string _ApellidoMaterno
        { get => ApMaterno; set => ApMaterno = value; }
        public DateTime _Fecha
        { get => FechaN; set => FechaN = value; }
        public string _CURP
        { get => CURP; set => CURP = value; }
        public void Registrar()
        {
            Console.WriteLine("Matricula: "+Matricula+"\nNombre: "+Nombre+ "\nApellido Paterno: "
                + ApPaterno+ "\nApellido Materno: " + ApMaterno+ "\nFecha nacimiento: " + FechaN.ToShortDateString()+ "\nCURP: " + CURP+ "\n");
        }
        public void VerDatos()
        {
            Console.WriteLine(Matricula + " " + Nombre + " " + ApMaterno + " " + ApMaterno + " " + FechaN.ToShortDateString() + " " + CURP);
        }
        //construir parametros
        public Escuela(int matricula, string nombre, string apellidoP, string apellidoM, DateTime fecha, string curp)
        {
            Matricula = matricula;
            Nombre = nombre;
            ApPaterno = apellidoP;
            ApMaterno = apellidoM;
            FechaN = fecha;
            CURP = curp;

        }
        //Constructor por defecto Vacio
        public Escuela() { }

    }
}

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
    public class program
    {
        static void Main(string[] args)
        {
            
            Administrativos Ob1 = new Administrativos("Juan", "Pérez", "Gómez");
            Administrativos Ob2 = new Administrativos("María", "García", "López");
            Administrativos Ob3 = new Administrativos("Pedro", "MASP990902HDFRTD03");
            Administrativos Ob4 = new Administrativos("Ana", "ROHA011130MDFDNN04");
            Administrativos Ob5 = new Administrativos("Rosa", new DateTime(2000, 2, 15));
            Administrativos Ob6 = new Administrativos("José", new DateTime(1996, 7, 8));
            Administrativos Ob7 = new Administrativos(1006,"Luisa");
            Administrativos Ob8 = new Administrativos(1007,"Jorge");
            Administrativos Ob9 = new Administrativos("Diana", "RUMO760712HDFRRJ01",1008);
            Administrativos Ob10 = new Administrativos("Carmen", "PERC860612MDFMRC08",1009);
            Administrativos Ob11 = new Administrativos("Manuel", new DateTime(1997, 12, 24));
            Administrativos Ob12 = new Administrativos(1011,"Marta"); ;
            Administrativos Ob13 = new Administrativos("Sofia" ,new DateTime(1991,02,14)) ;
            Administrativos Ob14 = new Administrativos("Carlos","Gomez","Ruiz");
            Administrativos Ob15 = new Administrativos("Andrea","ANFD890512MHCTRA1") ;
            List<Escuela> Personal = new List<Escuela>();
            Personal.Add(Ob1);
            Personal.Add(Ob2);
            Personal.Add(Ob3);
            Personal.Add(Ob4);
            Personal.Add(Ob5);
            Personal.Add(Ob6);
            Personal.Add(Ob7);
            Personal.Add(Ob8);
            Personal.Add(Ob9);
            Personal.Add(Ob10);
            Personal.Add(Ob11);
            Personal.Add(Ob12);
            Personal.Add(Ob13);
            Personal.Add(Ob14);
            Personal.Add(Ob15);

            foreach (Escuela item in Personal)
            {
                item.Registrar();
            }

            Alumnos obj1 = new Alumnos("Sofia", new DateTime(2002, 02, 14));
            Alumnos obj2 = new Alumnos("Carlos", new DateTime(2002, 09, 22));
            Alumnos obj3 = new Alumnos("Ana", new DateTime(2002, 06, 03));
            Alumnos obj4 = new Alumnos("Luis ", new DateTime(2002, 11, 01));
            Alumnos obj5 = new Alumnos("Maria ", new DateTime(2002, 03, 27));
            Alumnos obj6 = new Alumnos("Miguel ", new DateTime(2002, 07, 08));
            Alumnos obj7 = new Alumnos("Julia ", new DateTime(2001, 12, 12));
            Alumnos obj8 = new Alumnos("Juan ", new DateTime(2002, 04, 19));
            Alumnos obj9 = new Alumnos("Andrea ", new DateTime(2002, 08, 23));
            Alumnos obj10 = new Alumnos("David ", new DateTime(2003, 05, 06));
            Alumnos obj11 = new Alumnos("Laura", new DateTime(2003, 01, 30));
            Alumnos obj12 = new Alumnos("Pedro", new DateTime(2004, 10, 10));
            Alumnos obj13 = new Alumnos("Carmen", new DateTime(2002, 07, 25));
            Alumnos obj14 = new Alumnos("Jorge", new DateTime(2002, 09, 17));
            Alumnos obj15 = new Alumnos("Ana", new DateTime(2000, 02, 04));
            Alumnos obj16 = new Alumnos("Jose", new DateTime(1977, 06, 15));
            Alumnos obj17 = new Alumnos("Natalia", new DateTime(1996, 11, 09));
            Alumnos obj18 = new Alumnos("Juan", new DateTime(1984, 05, 28));
            Alumnos obj19 = new Alumnos("Andrea", new DateTime(1994, 03, 21));
            Alumnos obj20 = new Alumnos("Carlos", new DateTime(1979, 08, 02));
            Alumnos obj21 = new Alumnos(201234567, "Ana");
            Alumnos obj22 = new Alumnos(202345678, "Luis");
            Alumnos obj23 = new Alumnos(203456789, "Sofia");
            Alumnos obj24 = new Alumnos(204567890, "Diego");
            Alumnos obj25 = new Alumnos(205678901, "María");
            Alumnos obj26 = new Alumnos(206789012, "Juan");
            Alumnos obj27 = new Alumnos(207890123, "Lucía");
            Alumnos obj28 = new Alumnos(208901234, "Carlos");
            Alumnos obj29 = new Alumnos(209012345, "Julia");
            Alumnos obj30 = new Alumnos(210123456, "Pedro");
            Alumnos obj31 = new Alumnos("LOMM001231HDFRRNA3", "Mariana");
            Alumnos obj32 = new Alumnos("TOGV000102HDFLRCJ8", "Víctor");
            Alumnos obj33 = new Alumnos("MEGG010624MDFLNSA7", "Gabriela");
            Alumnos obj34 = new Alumnos("ROML020515HDFSVL09", "Luis");
            Alumnos obj35 = new Alumnos("GOMM030728MDFRRNA1", "Miguel");
            Alumnos obj36 = new Alumnos("CUSS040421MDFNTL01", "Samantha");
            Alumnos obj37 = new Alumnos("HOLC050330HDFRLRL5", "Cristina");
            Alumnos obj38 = new Alumnos("FAOR060909MDFRRNA8", "Oscar");
            Alumnos obj39 = new Alumnos("JIML070126MDFLNNL5", "Luisa");
            Alumnos obj40 = new Alumnos("PERL080624HDFRRNJ7", "Ramiro");
            Alumnos obj41 = new Alumnos("Diego", "García", "López");
            Alumnos obj42 = new Alumnos("Lucía", "Martínez", "Gómez");
            Alumnos obj43 = new Alumnos("Juan", "Hernández", "Castillo");
            Alumnos obj44 = new Alumnos("Sofía", "Pérez", "Vargas");
            Alumnos obj45 = new Alumnos("Luis", "Gutiérrez", "Morales");
            Alumnos obj46 = new Alumnos("Ana", "Flores", "Mendoza");
            Alumnos obj47 = new Alumnos("Carlos", "Ruiz", "Sánchez");
            Alumnos obj48 = new Alumnos("María", "Díaz", "Jiménez");
            Alumnos obj49 = new Alumnos("Pedro", "González", "Rodríguez");
            Alumnos obj50 = new Alumnos("Lucas", "Torres", "Ramírez");
            List<Escuela> Alumnado = new List<Escuela>();
            Alumnado.Add(obj1);
            Alumnado.Add(obj2);
            Alumnado.Add(obj3);
            Alumnado.Add(obj4);
            Alumnado.Add(obj5);
            Alumnado.Add(obj6);
            Alumnado.Add(obj7);
            Alumnado.Add(obj8);
            Alumnado.Add(obj9);
            Alumnado.Add(obj10);
            Alumnado.Add(obj11);
            Alumnado.Add(obj12);
            Alumnado.Add(obj13);
            Alumnado.Add(obj14);
            Alumnado.Add(obj15);
            Alumnado.Add(obj16);
            Alumnado.Add(obj17);
            Alumnado.Add(obj18);
            Alumnado.Add(obj19);
            Alumnado.Add(obj20);
            Alumnado.Add(obj21);
            Alumnado.Add(obj22);
            Alumnado.Add(obj23);
            Alumnado.Add(obj24);
            Alumnado.Add(obj25);
            Alumnado.Add(obj26);
            Alumnado.Add(obj27);
            Alumnado.Add(obj28);
            Alumnado.Add(obj29);
            Alumnado.Add(obj30);
            Alumnado.Add(obj31);
            Alumnado.Add(obj32);
            Alumnado.Add(obj33);
            Alumnado.Add(obj34);
            Alumnado.Add(obj35);
            Alumnado.Add(obj36);
            Alumnado.Add(obj37);
            Alumnado.Add(obj38);
            Alumnado.Add(obj39);
            Alumnado.Add(obj40);
            Alumnado.Add(obj41);
            Alumnado.Add(obj42);
            Alumnado.Add(obj43);
            Alumnado.Add(obj44);
            Alumnado.Add(obj45);
            Alumnado.Add(obj46);
            Alumnado.Add(obj47);
            Alumnado.Add(obj48);
            Alumnado.Add(obj49);
            Alumnado.Add(obj50);
            foreach (Alumnos item in Alumnado)
            {
                item.Registrar();
            }
 
            Maestros Objeto1 = new Maestros(3001, "Juan");
            Maestros Objeto2 = new Maestros(3002, "María");
            Maestros Objeto3 = new Maestros(3003, "Carlos");
            Maestros Objeto4 = new Maestros(3004, "Ana");
            Maestros Objeto5 = new Maestros("Jorge", "López", "Flores");
            Maestros Objeto6 = new Maestros("Laura", "García", "Pérez");
            Maestros Objeto7 = new Maestros("David", "Díaz", "Martínez");
            Maestros Objeto8 = new Maestros("Carmen", "Fernández", "Gutiérrez");
            Maestros Objeto9 = new Maestros("Francisco", "MAHF610618HDFVRL08");
            Maestros Objeto10 = new Maestros("Alejandra", "SAGA851128MDFNGL01");
            Maestros Objeto11 = new Maestros("Miguel", "Castillo", "Flores");
            Maestros Objeto12 = new Maestros("Patricia", "Vargas", "Pérez");
            Maestros Objeto13 = new Maestros("Manuel", new DateTime(1957, 10, 29));
            Maestros Objeto14 = new Maestros("Lucía",new DateTime(1998, 7, 17));
            Maestros Objeto15 = new Maestros("Maria",new DateTime(1978, 8, 22));
            Maestros Objeto16 = new Maestros("Ricardo",new DateTime(1982, 5, 11));
            Maestros Objeto17 = new Maestros( "Isabel", "CAMI651130MDFTRL02", 3017);
            Maestros Objeto18 = new Maestros( "Javier",  "MAHJ730318HDFTRV03",3018);
            Maestros Objeto19 = new Maestros( "Patricia", "GOFP701207MDFMRR07",3019);
            Maestros Objeto20 = new Maestros( "Pablo", "GOFP701207MDFMRR07",3020);

            List<Escuela> Maestro = new List<Escuela>();
            Maestro.Add(Objeto1);
            Maestro.Add(Objeto2);
            Maestro.Add(Objeto3);
            Maestro.Add(Objeto4);
            Maestro.Add(Objeto5);
            Maestro.Add(Objeto6);
            Maestro.Add(Objeto7);
            Maestro.Add(Objeto8);
            Maestro.Add(Objeto9);
            Maestro.Add(Objeto10);
            Maestro.Add(Objeto11);
            Maestro.Add(Objeto12);
            Maestro.Add(Objeto13);
            Maestro.Add(Objeto14);
            Maestro.Add(Objeto15);
            Maestro.Add(Objeto16);
            Maestro.Add(Objeto17);
            Maestro.Add(Objeto18);
            Maestro.Add(Objeto19);
            Maestro.Add(Objeto20);
            foreach (Escuela item in Maestro)
            {
                item.Registrar();
            }

        }
    }
}
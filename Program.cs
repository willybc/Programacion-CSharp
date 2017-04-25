﻿using institucion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace institucion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GESTION DE INSTITUCION");

            Persona[] lista = new Persona[3];
            lista[0] = new Alumno("Wilfredo", "Bardales")
            {
                Id = 1,
                Edad = 20,
                Telefono = 1166861931,
                Email = "willybc06@gmail.com"
            };


            lista[1] = new Profesor()
            {
                Id = 2,
                Nombre = "Juan",
                Apellido = "Ruiz",
                Edad = 34,
                Teléfono = 55555555,
                Catedra = "Programacion"
            };

            lista[2] = new Profesor()
            {
                Id = 3,
                Nombre = "William",
                Apellido = "Torvalds",
                Edad = 25,
                Teléfono = 911,
                Catedra = "Algebra"
            };


            Console.WriteLine(Persona.ContadorPersonas);
            Console.WriteLine("Resumenes");

            foreach (Persona p in lista)
            {
                Console.WriteLine($"Tipo {p.GetType()}");
                Console.WriteLine(p.ConstruirResumen());

                IEnteInstituto ente = p;

                ente.ConstruirLlaveSecreta("Hola");
            }

            Console.WriteLine("S T R U C T S");
            /* PRIMERA MANERA */
            CursoStruct c_class1 = new Models.CursoStruct(70);
            c_class1.Curso = "101-B";

            /*SEGUNDA MANERA */
            CursoStruct newC = new CursoStruct();
            newC.Curso = "564-A";

            var cursoFreak = c_class1;
            cursoFreak.Curso = "666-G";

            Console.WriteLine($"Curso c = {c_class1.Curso}");
            Console.WriteLine($"Curso Freak = {cursoFreak.Curso}");






            Console.WriteLine("C L A S E S");
            /* PRIMERA MANERA */
            CursoClass c_class = new CursoClass(70);
            c_class.Curso = "101-B";

            /*SEGUNDA MANERA */
            var newCc_class = new CursoStruct();
            newCc_class.Curso = "564-A";

            var cursoFreakc_class = c_class;
            cursoFreak.Curso = "666-G";

            Console.WriteLine($"Curso c = {c_class.Curso}");
            Console.WriteLine($"Curso Freak = {cursoFreakc_class.Curso}");

            /*ENUMERACIONES*/
            Console.WriteLine("E N U M E R A C I O N E S");

            var alumnoEst = new Alumno("Pablo", "Number") {
                Id = 6,
                Edad = 86,
                Telefono = 5660187,
                Estado= EstadosAlumno.Activo
            };

            Persona personaX = alumnoEst;
            Console.Write("Estado de alumno" + alumnoEst.Estado);

            IEnteInstituto iei = alumnoEst;

            Console.WriteLine("Estado de alumno" + alumnoEst.Estado);

            Console.WriteLine($"Tipo: { typeof(EstadosAlumno)} ");
            Console.WriteLine($"Tipo: { typeof(Alumno)} ");
            Console.WriteLine($"Tipo: { alumnoEst.GetType() }");
            Console.WriteLine($"Tipo: { personaX.GetType() }");

            Console.WriteLine($"Nombre: { nameof(Alumno)} ");
            Console.WriteLine($"Tamaño: { sizeof(int)} ");


            Console.ReadLine();

        }
    }
}

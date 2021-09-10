using S2_DPA_ConsoleProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace S2_DPA_ConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string nombreCurso = "Desarrollo de Ambiente Web";
            int edad = 20;
            double monto = 350.50;

            var nuevaEdad = 30;
            var nuevoMonto = 340.70;

            Console.WriteLine("El curso es: " + nombreCurso);

            var persona1 = new Persona();
            persona1.dni = "46114537";
            persona1.nombreCompleto = "Frank Alvino";
            persona1.telefono = 1234567;

            var persona2 = new Persona()
            {
                dni = "12345678",
                nombreCompleto = "Ginaluca Lapidula",
                telefono = 44332255
             };

            var persona3 = new Persona("98765432","Andre Carrillo",87655667);

            var listadoPersona = new List<Persona>();
            listadoPersona.Add(persona1);
            listadoPersona.Add(persona2);
            listadoPersona.Add(persona3);

            foreach (var item in listadoPersona)
            {
                Console.WriteLine(item.nombreCompleto + " "+ item.dni);
            }

            var busqueda = listadoPersona.Where(x=>x.dni == "46114537").FirstOrDefault();

            Console.WriteLine("Se encontró a: "+busqueda.nombreCompleto);
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_Nomina
{
    internal class Menu
    {
        private readonly ArrayList empleadosAsalariados;
        private readonly ArrayList empleadosPorHoras;
        private readonly ArrayList empleadosPorComision;
        private readonly ArrayList empleadosAsalariadosPorComision;

        public Menu(ArrayList a, ArrayList h, ArrayList c, ArrayList ac)
        {
            empleadosAsalariados = a;
            empleadosPorHoras = h;
            empleadosPorComision = c;
            empleadosAsalariadosPorComision = ac;
        }

        private void ActualizarDesdeLista(ArrayList lista)
        {

            Console.Write($"\nSeleccione el número del empleado (0 a {lista.Count - 1}): ");
            if (!int.TryParse(Console.ReadLine(), out int indice))
            {
                Console.WriteLine("Número inválido ");
                return;
            }

            if (indice < 0 || indice >= lista.Count)
            {
                Console.WriteLine("Índice fuera de rango");
                return;
            }

            if (lista[indice] is Persona emp)
            {
                emp.ActualizarDesdeConsola();
                Console.WriteLine("Empleado actualizado");
            }
            else
            {
                Console.WriteLine("El elemento seleccionado no es un empleado válido");
            }
        }
        public void MostrarMenu() {
            while (true)
            {
                Console.WriteLine("\n=== SISTEMA DE NÓMINA ===");
                Console.WriteLine("1. Actualizar informacion");
                Console.WriteLine("2. Salir");
                Console.WriteLine("3. Salir");
                Console.Write("\nSeleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        bool volverMenuPrincipal = false;
                        while (!volverMenuPrincipal)
                        {
                            Console.WriteLine("\n--- ACTUALIZAR INFORMACIÓN DE EMPLEADOS ---");
                            Console.WriteLine("1. Empleados Asalariados");
                            Console.WriteLine("2. Empleados Por Horas");
                            Console.WriteLine("3. Empleados Por Comisión");
                            Console.WriteLine("4. Empleados Asalariados Por Comisión");
                            Console.WriteLine("5. Volver al menú principal");
                            Console.Write("\nSeleccione el tipo de empleado: ");

                            string tipoEmpleado = Console.ReadLine();

                            switch (tipoEmpleado)
                            {
                                case "1": ActualizarDesdeLista(empleadosAsalariados); break;
                                case "2": ActualizarDesdeLista(empleadosPorHoras); break;
                                case "3": ActualizarDesdeLista(empleadosPorComision); break;
                                case "4": ActualizarDesdeLista(empleadosAsalariadosPorComision); break;

                                case "5":
                                    volverMenuPrincipal = true;
                                    break;

                                default:
                                    Console.WriteLine("\nOpción no válida. Intente nuevamente.");
                                    break;
                            }
                        }
                        break;

                    case "2":
                        Console.WriteLine("\nSaliendo del sistema...");
                        return;

                    default:
                        Console.WriteLine("\nOpción no válida. Intente nuevamente.");
                        break;
                }
            }
        }
    }
}

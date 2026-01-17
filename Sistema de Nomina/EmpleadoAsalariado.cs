using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Sistema_de_Nomina
{
    internal class EmpleadoAsalariado : Persona
    {
        public decimal salarioSemanal { get; private set; }
        public EmpleadoAsalariado(string primerNombre, string apellidoPaterno, int numeroSeguroSocial, decimal salarioSemanal)
            : base(primerNombre, apellidoPaterno, numeroSeguroSocial)
        {
            this.salarioSemanal = salarioSemanal;
        }

        public override decimal CalcularPago()
        {
            return (decimal)salarioSemanal;
        }

        public override void ActualizarDesdeConsola()
        {
            Console.Write("Nuevo nombre: ");
            primerNombre = Console.ReadLine() ?? "";

            Console.Write("Nuevo apellido: ");
            apellidoPaterno = Console.ReadLine() ?? "";

            Console.Write("Nuevo seguro social: ");
            numeroSeguroSocial = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Nuevo salario: ");
            salarioSemanal = decimal.Parse(Console.ReadLine() ?? "");
        }

    }
}

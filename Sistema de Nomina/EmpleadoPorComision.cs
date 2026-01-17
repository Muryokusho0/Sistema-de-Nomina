namespace Sistema_de_Nomina
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal class EmpleadoPorComision : Persona
    {
        public int ventasBrutas { get; private set; }

        public double tarifaComision { get; private set; }

        public EmpleadoPorComision(string primerNombre, string apellidoPaterno, int numeroSeguroSocial, int ventasBrutas, double tarifaComision)
            : base(primerNombre, apellidoPaterno, numeroSeguroSocial)
        {
            this.ventasBrutas = ventasBrutas;
            this.tarifaComision = tarifaComision;
        }

        public override decimal CalcularPago()
        {
            return (decimal)(ventasBrutas * tarifaComision);
        }

        public override void ActualizarDesdeConsola()
        {
            Console.Write("Nuevo nombre: ");
            primerNombre = Console.ReadLine() ?? "";

            Console.Write("Nuevo apellido: ");
            apellidoPaterno = Console.ReadLine() ?? "";

            Console.Write("Nuevo seguro social: ");
            numeroSeguroSocial = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Nuevas ventas brutas: ");
            ventasBrutas = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Nueva tarifa de comisión (en decimal): ");
            tarifaComision = double.Parse(Console.ReadLine() ?? "0");
        }
    }
}

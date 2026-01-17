using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_Nomina
{
    internal class EmpleadoAsalariadoPorComisión : EmpleadoPorComision
    {
        public decimal salarioBase { get; private set; }
        public EmpleadoAsalariadoPorComisión(string primerNombre, string apellidoPaterno, int numeroSeguroSocial, int ventasBrutas, double tarifaComision, decimal salarioBase)
            : base(primerNombre, apellidoPaterno, numeroSeguroSocial, ventasBrutas, tarifaComision)
        {
            this.salarioBase = salarioBase;
        }

        public new decimal CalcularPago()
        {
            decimal pago = base.CalcularPago() + salarioBase + (salarioBase * 0.10m);
            return pago;
        }

        public override void ActualizarDesdeConsola()
        {
            base.ActualizarDesdeConsola();
            Console.Write("Nuevo salario base: ");
            salarioBase = decimal.Parse(Console.ReadLine() ?? "0");
        }
    }
}

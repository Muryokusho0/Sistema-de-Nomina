namespace Sistema_de_Nomina
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal class EmpleadoPorHoras : Persona
    {
        public decimal SueldoPorHora { get; private set; }

        public int HorasTrabajadas { get; private set; }

        public EmpleadoPorHoras(string apellidoPaterno, int numeroSeguroSocial,decimal SueldoPorHora, int HorasTrabajadas) 
            : base( apellidoPaterno, numeroSeguroSocial)
        {
            this.SueldoPorHora = SueldoPorHora;
            this.HorasTrabajadas = HorasTrabajadas;
        }

        public override decimal CalcularPago()
        {
            if (HorasTrabajadas <= 40)
            {
                return SueldoPorHora * HorasTrabajadas;
            }
            else
            {
                decimal pagoHorasExtra = (SueldoPorHora * 40) + (SueldoPorHora * 1.5m * (HorasTrabajadas - 40));
                return pagoHorasExtra;
            }
        }

        public override void ActualizarDesdeConsola()
        {
            Console.Write("Nuevo apellido: ");
            apellidoPaterno = Console.ReadLine() ?? "";

            Console.Write("Nuevo seguro social: ");
            numeroSeguroSocial = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Nuevo sueldo por hora: ");
            SueldoPorHora = decimal.Parse(Console.ReadLine() ?? "0");

            Console.Write("Nuevas horas trabajadas: ");
            HorasTrabajadas = int.Parse(Console.ReadLine() ?? "0");
        }
    }
}

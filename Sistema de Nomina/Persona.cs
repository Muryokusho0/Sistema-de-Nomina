using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_Nomina
{
    internal abstract class Persona
    {
        public string primerNombre { get; protected set; }
        public string apellidoPaterno { get; protected set; }
        public int numeroSeguroSocial { get; protected set; }

        protected Persona(string primerNombre, string apellidoPaterno, int numeroSeguroSocial)
        {
            this.primerNombre = primerNombre;
            this.apellidoPaterno = apellidoPaterno;
            this.numeroSeguroSocial = numeroSeguroSocial;
        }

        protected Persona(string apellidoPaterno, int numeroSeguroSocial)
        {
            this.apellidoPaterno = apellidoPaterno;
            this.numeroSeguroSocial = numeroSeguroSocial;
        }

        public abstract void ActualizarDesdeConsola();

        public abstract decimal CalcularPago();
        public override string ToString()
        {
            return $"Nombre: {primerNombre} | Pago: {CalcularPago():N2}";
        }

    }
}

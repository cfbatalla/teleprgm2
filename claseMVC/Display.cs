using System;

namespace empleados_vista
{
    class Display
    {
        private double salario;
        private double porcentajeDeducible;
        private double totalimpuestosdeducibles;
        public double TotalImpuestosDeducibles
        {
            get { return this.totalimpuestosdeducibles; }
            set { this.totalimpuestosdeducibles = value; }
        }

        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        public double PorcentajeDeducible
        {
            get { return porcentajeDeducible; }
            set { porcentajeDeducible = value; }
        }
        public Display()
        {
            this.Salario = 0;
            this.PorcentajeDeducible = 0;
            this.TotalImpuestosDeducibles = 0;
            this.ObtieneValores();
        }
        private void ObtieneValores()
        {
            Console.WriteLine("Introduzca el Salario del Empleado");
            this.Salario = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduzca el porcentaje de deducibles para este Empleado");
            this.PorcentajeDeducible = Convert.ToDouble(Console.ReadLine());

        }

        public void MuestraTotales()
        {
            Console.WriteLine("El Total Impuestos Deducibles para este empleado es:{0}", this.TotalImpuestosDeducibles);
        }
    }
}
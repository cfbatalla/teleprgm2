using System;

namespace empleados_model
{
    public class empleado
    {
        private string nombre;
        private string apellido;
        private int cedula;
        private DateTime fechaDeIngreso;
        private double impuestoAplicable;
        private double salario;
        public Double Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        public double ImpuestoAplicable
        {
            get { return impuestoAplicable; }
            set { impuestoAplicable = value; }
        }
        public int Cedula
        {
            get
            {
                return cedula;
            }
            set
            {
                cedula = value;
            }
        }

        public DateTime FechaDeIngreso
        {
            get
            {
                return fechaDeIngreso;
            }
            set
            {
                fechaDeIngreso = value;
            }
        }

        private string departamento;

        public string Departamento
        {
            get
            {
                return departamento;
            }
            set
            {
                departamento = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }

        public bool CedulaValida()
        {
            return true;
        }

        public virtual string solicitarJubilacion()
        {
            return "El empleado procedera a Jubilarse";
        }

        public virtual double notasDeDesempenio()
        {
            double vResult = 0;
            vResult = this.Cedula / 19;
            return vResult;
        }
    }

    public class empleadoAlmacen : empleado
    {
        private bool esDespachador = false;
        public bool EsDespachador()
        {
            return false;
        }

        public empleadoAlmacen()
        {
            Console.WriteLine("Instanciación de la clase empleadoAlmacen ejecutada");
            this.Departamento = "Almacen";


        }

        public double promedioDeEnvios()
        {
            try
            {
                int vTamanoDelArreglo = 0;
                int[] vCantidadDeEnvio = new int[vTamanoDelArreglo];
                int i = 0;
                double vTotal = 0;
                double vResult = 0;
                for (i = 0; i < 10; i++)
                {
                    vCantidadDeEnvio[i] = i + 100;
                }
                foreach (int item in vCantidadDeEnvio)
                {
                    vTotal += item;
                }
                vResult = vTotal / vTamanoDelArreglo;
                return vResult;
            }
            catch (Exception e)
            // catch (DivideByZeroException ex)  
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }

        public override string solicitarJubilacion()
        {
            return "El almacenista procedera a Jubilarse";
        }

        public override double notasDeDesempenio()
        {
            double vResult = 0;
            vResult = this.promedioDeEnvios() / 19;
            return vResult;
        }

        public double TotalImpuestosDeducibles()
        {
            double vResult = (this.Salario * this.ImpuestoAplicable) / 100;
            return vResult;
        }
    }

    public class empleadoadministrativo : empleado { }

}
using System;
using empleados_vista;
using empleados_model;

namespace empleados_controller
{
    class controladorEmpleados
    {
        private Display oDisplay;
        private empleadoAlmacen oEmpleadoAlmacen;
        public controladorEmpleados()
        {
            oDisplay = new Display();
            oEmpleadoAlmacen = new empleadoAlmacen();
            oEmpleadoAlmacen.Salario = oDisplay.Salario;
            oEmpleadoAlmacen.ImpuestoAplicable = oDisplay.PorcentajeDeducible;
            oDisplay.TotalImpuestosDeducibles = oEmpleadoAlmacen.TotalImpuestosDeducibles();
            oDisplay.MuestraTotales();
        }

    }
}

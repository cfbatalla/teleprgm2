

# Modelo-Vista-Controlador

<div>Es una forma de organizar el código. La idea es dividir la logica de la aplicacion en elementos interconectados. Su intención fue aislar la interfaz de usuario con la logica del negocio (la funcionalidad del sistema).</div>

<div>Modelo Vista Controlador (MVC) es un estilo de arquitectura de software que separa los datos de una aplicación, la interfaz de usuario, y la lógica de control en tres componentes distintos.</div>

## Funciones del Modelo

<div>El Modelo que contiene una representación de los datos que maneja el sistema, su lógica de negocio, y sus mecanismos de persistencia.</div>

<div>Es el único encargado del acceso a la capa de almacenamiento de datos. Lo ideal es que el modelo sea independiente del sistema de almacenamiento.</div>

<div>Define las reglas de negocio. En nuestro ejemplo, obtiene un porcentaje de impuestos a partir del salario.</div>

</div>

`

<pre>   public double TotalImpuestosDeducibles()
        {
            double vResult = (this.Salario * this.ImpuestoAplicable) / 100;
            return vResult;
        }
  </pre>

`

## Funciones del Controlador

<div>El Controlador, que actúa como intermediario entre el Modelo y la Vista, gestiona el flujo de información entre ellos y las transformaciones para adaptar los datos a las necesidades de cada uno. El Controlador provee coordinacion entre la vista y el modelo. Asi, el controlador decide que vistas presentar y con que datos en ella. Además, traslada las acciones del usuario a la logica del negocio.</div>

<div>Es sensible a los eventos de entrada (Enter o un clic, apertura de un combo, etc.).</div>

<div>Contiene reglas de gestión de eventos.</div>

</div>

`

<pre>  class controladorEmpleados
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
  </pre>

`

## Funciones de la Vista

<div>La Vista, o interfaz de usuario, se encarga de la información que se envía al cliente y los mecanismos interacción con éste.</div>

<div>Entre sus funciones, estan:</div>

<div>Recibir datos del modelo y los muestra al usuario.</div>

<div>Tienen un registro de su controlador asociado (normalmente porque además lo instancia).</div>

<div>Pueden dar el servicio de "Actualización()", para que sea invocado por el controlador o por el modelo (cuando es un modelo activo que informa de los cambios en los datos producidos por otros agentes).</div>

`

<pre> 
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
 </pre>

`</div>

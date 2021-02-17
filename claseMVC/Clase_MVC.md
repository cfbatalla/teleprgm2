Es una forma de organizar el código.  La idea es dividir la logica de la aplicacion en elementos interconectados. Su intención fue aislar la interfaz de usuario con la logica del negocio (la funcionalidad del sistema).  
Modelo Vista Controlador (MVC) es un estilo de arquitectura de software que separa los datos de una aplicación, la interfaz de usuario, y la lógica de control en tres componentes distintos.


Funciones del Modelo
El Modelo que contiene una representación de los datos que maneja el sistema, su lógica de negocio, y sus mecanismos de persistencia.
Es el único encargado del acceso a la capa de almacenamiento de datos. Lo ideal es que el modelo sea independiente del sistema de almacenamiento.
Define las reglas de negocio. En nuestro ejemplo, obtiene un porcentaje de impuestos a partir del salario.

      public double TotalImpuestosDeducibles()
        {
            double vResult = (this.Salario * this.ImpuestoAplicable) / 100;
            return vResult;
        }

Funciones del Controlador
El Controlador, que actúa como intermediario entre el Modelo y la Vista, gestiona el flujo de información entre ellos y las transformaciones para adaptar los datos a las necesidades de cada uno. El Controlador provee coordinacion entre la vista y el modelo. Asi, el controlador decide que vistas presentar y con que datos en ella. Además, traslada las acciones del usuario a la logica del negocio.
Es sensible a los eventos de entrada (Enter o un clic, apertura de un combo, etc.).
Contiene reglas de gestión de eventos.

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

Funciones de la Vista
La Vista, o interfaz de usuario, se encarga de la información que se envía al cliente y los mecanismos interacción con éste.
Entre sus funciones, estan:
Recibir datos del modelo y los muestra al usuario.
Tienen un registro de su controlador asociado (normalmente porque además lo instancia).
Pueden dar el servicio de "Actualización()", para que sea invocado por el controlador o por el modelo (cuando es un modelo activo que informa de los cambios en los datos producidos por otros agentes).
 
-------------------
El patron de arquitectura Modelo-Vista-Controlador (MVC) separa una aplicación en tres grupos principales de componentes: Modelos, Vistas y Controladores.  Este patrón permite la separación en la ejecución de tareas.  
En este patrón, las solicitudes de los usuarios son dirigidas por el controlador el cual es el responsable de trabajar con el Modelo para ejecutar las acciones de usuario resultando en consultas.  El Controlador selecciona la vista a desplegar que ha sido alimentada con datos enviados por el Modelo. 
  
Esta clase trata de la lectura/escritura de archivos y codificacion de texto. La interacción con archivos es implementada en C# a traves de la clase StreamReader en el namespace System.IO.  
La lectura y escritura a un archivo se ejecutan gracias al concepto de 'Flujo de datos' o 'Stream'. Entonces, moveremos datos en zonas en la memoria, pero generalmente lo haremos de la memoria a un dispositivo de almacenamiento como el disco duro o del dispositivo nuevamente a la memoria.  
Cuando hacemos uso de los flujos, la información no es enviada en un solo movimiento, sino que se envía ordenadamente byte por byte.  
El namespace System.IO es el que contiene tipos que permiten leer y escribir en los archivos y secuencias de datos, así como tipos que proporcionan compatibilidad básica con los archivos y directorios. Las clases más relacionadas con la escritura y lectura de archivos (File Input/Output o File I/O) son:

*   FileStream, cuyo propósito es lectura y escritura de datos binarios (no de texto legible), a cualquier archivo de tipo binario, aunque se puede utilizar para acceder a cualquier tipo de archivo, inclusive los de texto.
*   StreamReader y StreamWriter, las cuales están diseñadas para lectura y escritura de archivos de texto. Estas clases se asumen como de un nivel más alto que FileStream.

![](https://docs.google.com/drawings/d/1YT1eqdOuBTxZLKFfX6mnLa2FlE8Sy8pkF1ZwP8-RHrQ/pub?w=949&h=594)

La clase 'archivos', que esta en el archivo 'archivos.cs',  tiene dos métodos que corresponden al manejo de la lectura y escritura de un archivo de texto llamado "miTexto.txt" ubicado en el mismo directorio. 

Dentro de "miTexto.txt" tendrá lineas de texto con la siguiente secuencia: nombre; cédula de identidad,correo electronico. de esta forma:

Carlos Batalla,15598676,carlosfranz@ucla.edu.ve

xxx,yyy,zzz@ddd.com

aaa,bbb,ccc@ddd.com

TAREA 1

Usando el tratamiento de cadenas, desglose cada linea del archivo para que muestre por pantalla:

Nombre del Alumno:Carlos Batala

Cédula de Identidad: 15.598.676

Correo electrónico: [carlosfranz@ucla.edu.ve](mailto:carlosfranz@ucla.edu.ve)

TAREA 2:

Introduzca el manejo de excepciones en el método CreaSalida.  

TAREA 3:

Observe las diferencias en el tratamiento de texto entre los dos métodos y su codificación (más detalles [aquí](https://es.wikipedia.org/wiki/Codificaci%C3%B3n_de_caracteres)). Como este código esta desarrollado en Linux, usé [UTF-8](https://es.wikipedia.org/wiki/UTF-8). Implemente la codificación de acuerdo a la arquitectura en la que se encuentra.

Código para la lectura/escritura de un archivo de texto: 

<pre>using System;
using System.IO;
using System.Text;

namespace archivos {
  public class Archivos {
    private string rutas;

    public void LeePorLotes() {
     int vCapacidadDelStream = 0;
      string vLinea = null;
      try {
        StreamReader vLeeStreams = new StreamReader("miTexto.txt");
        vLinea = vLeeStreams.ReadLine();
        while (vLinea != null) {
          //tratamiento de la linea como entrada. TAREA 1
          Console.WriteLine(vLinea);
          vLinea = vLeeStreams.ReadLine();
        }
        vLeeStreams.Close();
      } catch (Exception e) {
        Console.WriteLine("Excepcion:" + e.Message);
      } finally {
        Console.WriteLine("Ejecución del método finalizada");
      }
    }

    public void CreaSalida() {  

      //Introducir manejo de excepciones TAREA 2
      FileStream vFs = new FileStream("miTexto.txt", FileMode.Create);
      string vCadena = "Carlos Franz";
      byte[] writeArr = Encoding.UTF8.GetBytes(vCadena); //TAREA 3
      vFs.Write(writeArr, 0, vCadena.Length);
      vFs.Close();
    }

  }
}
</pre>


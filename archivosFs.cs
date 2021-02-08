using System;
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

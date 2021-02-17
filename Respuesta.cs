using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace archivos {
  public class Archivos {
    private string rutas;

    public void LeePorLotes() {
      int vCapacidadDelStream = 0;
      string vLinea = null;
      int vIndice;
      try {
        string[] vDesglosado = null;
        StreamReader vLeeStreams = new StreamReader("miTexto.txt");
        vLinea = vLeeStreams.ReadLine();
        while (vLinea != null) {
          vDesglosado = this.ArregloDesglosado(vLinea);
          vIndice = 1;
          foreach(string vToPrint in vDesglosado) {
            switch (vIndice) {
            case 1:
              Console.WriteLine("El nombre es:{0}", vToPrint);
              break;
            case 2:
              Console.WriteLine("La cédula es:{0}", vToPrint);
              break;
            case 3:
              Console.WriteLine("El correo es:{0}", vToPrint);
              break;
            }
            vIndice += 1;
          }
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
      FileStream vFs = new FileStream("miTexto.txt", FileMode.Create);
      string vCadena = "Carlos Franz";
      byte[] writeArr = Encoding.UTF8.GetBytes(vCadena);
      vFs.Write(writeArr, 0, vCadena.Length);
      vFs.Close();
    }

    public void LeePorLotes2() {
      string vAux = null;
      byte[] infoArchivo = new byte[1000];
      FileStream fs = new FileStream("miTexto.txt", FileMode.Open);
      fs.Read(infoArchivo, 0, (int) fs.Length);
      vAux = Encoding.UTF8.GetString(infoArchivo);
      Console.WriteLine(vAux);
    }

    private string[] ArregloDesglosado(string vEntrada) {
      string[] vResult = vEntrada.Split(',');
      return vResult;
    }
  }
}

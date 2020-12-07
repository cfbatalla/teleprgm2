using System;
using Vehiculos;

namespace clase_01{
    class Program{
        static void Main(string[] args){
            string nombre = null;
            string pais = " ";
            int edad = 0;
            bool AptoParaLicencia = false;
            Console.WriteLine("cual es tu nombre?");
            nombre = Console.ReadLine();            
            Console.WriteLine("cual es tu edad?");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("hola {0}, tienes {1} años de edad.",nombre,edad);
            if (edad > 16){
                AptoParaLicencia = true;
                Console.WriteLine("Lo esperamos mañana para que tramite su licencia");                                
                //como nace?? Instanciando la clase
                Vehiculo oVehiculo = new Vehiculo(); 
                oVehiculo.Arrancar();
                }
            else {
                AptoParaLicencia = false;
                Console.WriteLine("Ud, no tiene edad suficiente para manejar!");}  
        }
    }
   

   
}

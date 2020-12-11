using System;
using Vehiculos;

namespace clase_02{
    class Program{
        static void Main(string[] args){
            string nombre = null;            
            int edad = 0;
            bool AptoParaLicencia = false;
            for (int i=0;i<=1;i++){            
                Console.WriteLine("cual es tu nombre?");
                nombre = Console.ReadLine();            
                Console.WriteLine("cual es tu edad?");
                edad = Convert.ToInt32(Console.ReadLine());                
                if (edad > 16){
                    AptoParaLicencia = true;                    
                    Vehiculo oVehiculo = new Vehiculo();
                    Console.WriteLine("Introduce el modelo del vehiculo, por favor:");
                    oVehiculo.modelo = Console.ReadLine();
                    Console.WriteLine("hola {0}, tienes {1} años de edad y el modelo de su carro es {2}",nombre,edad,oVehiculo.modelo);            
                }
                else {
                    AptoParaLicencia = false;
                    Console.WriteLine("Ud, no tiene edad suficiente para manejar!");}  
            }            
        }
    }
}

using System;

namespace clase01{
    class Program{
        static void Main(string[] args){
            string nombre;
            int edad;            
            bool AptoParaLicencia;
            Console.WriteLine("cual es tu nombre?");
            nombre = Console.ReadLine();
            Console.ReadLine();
            Console.WriteLine("cual es tu edad?");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("hola {0}, tienes {1} años de edad.",nombre,edad);
            if (edad > 16){
                AptoParaLicencia = true;
                Console.WriteLine("Lo esperamos mañana para que tramite su licencia");
                }
            else {
                AptoParaLicencia = false;
                Console.WriteLine("Ud, no tiene edad suficiente para manejar!");}            
        }
    }
}

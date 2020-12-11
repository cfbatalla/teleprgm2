using System;

namespace Vehiculos{
    public class Vehiculo{
    //declaramos atributos de la clase
        string marca;
        string color;
        string placa;
        double precio;
        int CantidadDePuertas;
        public string modelo;
        bool LucesTraserasEncendidad = false;
    //declaramos metodos de la clase
        public void Arrancar(){
            Console.WriteLine("El carro ha arrancado");
        //aqui van todo lo que implica que el carro haya arrancado
    }  //{} es un bloque de codigo
        public void Frenar(){
             LucesTraserasEncendidad = true;
    }
        public void Acelerar(){}
        public void AcelerarConMusica(){}
    
        private void VerificarEstadoBateria(){
        
        
    }
}
}

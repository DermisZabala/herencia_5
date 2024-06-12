using System;
using System.Drawing;
using System.Reflection;

namespace Herencia_5
{
    internal class Program : Object
    {
        static void Main(string[] args)
        {

            Avion miAvion = new Avion("A-29B Super Tucano", "Verde oscuro");
            Coche miMercedes = new Coche("Mercedes-Benz Clase E (W124)", "Gris");

            Vehiculo[] vehiculos = new Vehiculo[2];
            vehiculos[0] = miAvion;
            vehiculos[1] = miMercedes;

            Console.WriteLine("Avión");
            Console.WriteLine(miAvion.Modelo());
            Console.WriteLine(miAvion.Color());
            miAvion.ArrancarMotor();
            vehiculos[0].Conducir();
            miAvion.Aterrizaje();
            miAvion.PararMotor();

            Console.WriteLine("\nCoche");
            Console.WriteLine(miMercedes.Modelo());
            Console.WriteLine(miMercedes.Color());
            miMercedes.ArrancarMotor();
            vehiculos[1].Conducir();
            miMercedes.Estacionando();
            miMercedes.PararMotor();

            //Uso de polimorfismo
            Console.WriteLine("\n\nUso de polimorfismo\n");
            Coche miCoche = new Coche("Honda Civic", "Negro");
            Vehiculo miVehiculo = miCoche;
            miVehiculo.Conducir(); //miVehiculo se comporta como un coche

            Avion miAvion2 = new Avion("Desconocido", "Blanco");
            miVehiculo = miAvion2;
            miVehiculo.Conducir();//En este caso miVehiculo se comporta como un avión

        }
    }
    class Vehiculo
    {
        private string modelo;
        private string color;
        public Vehiculo(string modelo, string color)
        {
            this.modelo = modelo;
            this.color = color;
        }
        public void ArrancarMotor()
        {
            Console.WriteLine("El motor esta arrancando");
        }
        public void PararMotor()
        {
            Console.WriteLine("El motor esta parando");
        }
        public virtual void Conducir()
        {
            Console.WriteLine("Voy conduciendo");
        }
        public string Modelo()
        {
            return "Nombre del modelo: " + modelo;
        }
        public string Color()
        {
            return "Color: " + color;
        }
        
    }
    class Avion : Vehiculo
    {
        public Avion(string modelo, string color) : base(modelo, color)
        {

        }
        public override void Conducir()
        {
            Console.WriteLine("Voy pilotando por encima de las nubes");
        }
        public void Aterrizaje()
        {
            Console.WriteLine("Estoy aterrizando");
        }
    }
    class Coche : Vehiculo
    {
        public Coche(string modelo, string color):base(modelo, color)
        {

        }
        public override void Conducir()
        {
            Console.WriteLine("Voy conduciendo en la carretera");
        }
        public void Estacionando()
        {
            Console.WriteLine("Me estoy estacionando");
        }
    }
}
namespace Tarea_2.Paso_2Herencia_y_Polimorfismo
{
    public class paso_2
    {
        public static void Tarea1 () {
            Vehiculo vehiculo1 = new Automovil("Toyota", "Corolla", 2022, 4);
            Console.WriteLine("Información del Vehículo 1:");
            vehiculo1.MostrarInformacion();
            Vehiculo vehiculo2 = new Motocicleta("Honda", "CBR500R", 2023, 3);
            Console.WriteLine("Información del Vehículo 2:");
            vehiculo2.MostrarInformacion();
            Vehiculo vehiculo3 = new Camioneta("Ford", "Ranger", 2021, 1);
            Console.WriteLine("Información del Vehículo 3:");
            vehiculo3.MostrarInformacion();
        }

    }
}

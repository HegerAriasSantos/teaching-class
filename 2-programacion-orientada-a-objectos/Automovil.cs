namespace Tarea_2.Paso_2Herencia_y_Polimorfismo
{
    public class Automovil : Vehiculo
    {
        public int PasajerosMax { get; set; }

        public Automovil(string marca, string modelo, int año, int pasajerosMax)
            : base(marca, modelo, año)
        {
            PasajerosMax = pasajerosMax;
        }
        public override void MostrarInformacion()
        {
            Console.WriteLine($"Camioneta - Marca: {Marca}, Modelo: {Modelo}, Año: {Año}, Cantidad de pasajeros maximos: {PasajerosMax}");
        }

    }
}

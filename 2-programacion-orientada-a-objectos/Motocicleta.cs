namespace Tarea_2.Paso_2Herencia_y_Polimorfismo
{
    public class Motocicleta : Vehiculo
    {
        public int Canastas { get; set; }

        public Motocicleta(string marca, string modelo, int año, int canastas)
            : base(marca, modelo, año)
        {
            Canastas = canastas;
        }
        public override void MostrarInformacion()
        {
            Console.WriteLine($"Camioneta - Marca: {Marca}, Modelo: {Modelo}, Año: {Año}, Canastas: {Canastas}");
        }
    }
}

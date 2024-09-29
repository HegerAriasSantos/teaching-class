namespace Tarea_2.Paso_2Herencia_y_Polimorfismo
{
    public class Camioneta : Vehiculo
    {
        public int Caja { get; set; }

        public Camioneta(string marca, string modelo, int año, int caja)
            : base(marca, modelo, año)
        {
            Caja = caja;
        }
        public override void MostrarInformacion()
        {

            Console.WriteLine($"Camioneta - Marca: {Marca}, Modelo: {Modelo}, Año: {Año}, Caja: {Caja}");
        }

    }
}

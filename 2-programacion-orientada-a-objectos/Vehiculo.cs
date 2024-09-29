namespace Tarea_2.Paso_2Herencia_y_Polimorfismo
{
        public class Vehiculo
        {
            public string Marca { get; set; }
            public string Modelo { get; set; }
            public int Año { get; set; }
            public Vehiculo(string marca, string modelo, int año)
            {
                Marca = marca;
                Modelo = modelo;
                Año = año;
            }
            public virtual void MostrarInformacion()
            {
                Console.WriteLine($"Marca: {Marca},Modelo: {Modelo}, Año: {Año}");
            }
        }
}

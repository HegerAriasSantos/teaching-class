namespace Tarea_1.Paso_1_Introduccion_a_la_POO
{
    public class Persona
    {
        public int Edad { get; set; }
        public string Nombre { get; set; }
    
        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public virtual void MostrarInformacion()
        {
        Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");
        }
    }
}
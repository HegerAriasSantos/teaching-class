namespace Tarea_1.Paso_1_Introduccion_a_la_POO
{
    public class paso_1
    {
        public static void Tarea1()
        {
            Persona Persona1 = new Persona("Pedro", 14);
            Console.WriteLine("Información de persona 1:");
            Persona1.MostrarInformacion();
            Persona Persona2 = new Persona("Mateo", 23);
            Console.WriteLine("Información de persona 2:");
            Persona2.MostrarInformacion();
            Persona Persona3 = new Persona("Juan", 25);
            Console.WriteLine("Información de persona 3:");
            Persona3.MostrarInformacion();
            Persona Persona4 = new Persona("Mari", 4);
            Console.WriteLine("Información de persona 4:");
            Persona4.MostrarInformacion();
            Persona Persona5 = new Persona("Juana", 20);
            Console.WriteLine("Información de persona 5:");
            Persona5.MostrarInformacion();
        }

    }
}

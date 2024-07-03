using System;
using System.Collections.Generic;
class Persona
{
    //atributos
    public string nombre;
    public int edad; 

    //Contructor
    public Persona (string nombre, int edad)
    {
        this.nombre = nombre;
        this.edad = edad;
    }

        // metodo para moostrar informacion 
        public void MostrarInformacion()
{
        Console.WriteLine($"Nombre: {nombre}, Edad: {edad}");
}
}

class Program
{
    static void Main (string[] args)
    {
        //crea una lista de personas
        List<Persona> personas = new List<Persona>();
        //crear una instancia de la clase persona usando el contructor
        personas.Add(new Persona("Juan", 30));
        personas.Add(new Persona("Pedro", 55));
        personas.Add(new Persona("Maria", 62));
        personas.Add(new Persona("Jose", 32));
        personas.Add(new Persona("Juana", 34));

        //llamar al metodo para mostrar informacion 
        for (int i = 0; i < personas.Count; i++)
        {
            personas[i].MostrarInformacion();
        }
}
}
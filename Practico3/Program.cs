// See https://aka.ms/new-console-template for more information
using BusinessLayer.Implementations;
using BusinessLayer.Interfaces;
using DataAccessLayer.Implementations;
using DataAccessLayer.Interfaces;
using Shared;

IDAL_Personas dalPersonas = new DAL_Personas_EF();
IBL_Personas blPersonas = new BL_Personas(dalPersonas);

Console.WriteLine("Mi Primera APP...");

do
{
    try
    {
        Console.WriteLine("##### Nueva Persona #####");


        Persona persona = new Persona();
        Console.WriteLine("Nombre: ");
        persona.Nombre = Console.ReadLine();
        Console.WriteLine("Documento: ");
        persona.Documento = Console.ReadLine();

        blPersonas.AddPersona(persona);

        Console.WriteLine("Persona:");
        Console.WriteLine("     Nombre: " + persona.Nombre);
        Console.WriteLine("     Documento: " + persona.Documento);
        Console.WriteLine("Escriba exit para salir o cualquier tecla para continuar");

    } catch (Exception ex) 
    {
        Console.WriteLine("ERROR: " + ex.Message);
    }
} while (!Console.ReadLine().Equals("exit"));

Console.WriteLine("Documento a buscar: ");

string documento = Console.ReadLine();
Console.WriteLine("PERSONA: ");
Persona p = blPersonas.Get(documento);
Console.WriteLine("     Nombre: " + p.Nombre);


Console.WriteLine("Presione una tecla para ver lista de Personas..");
Console.ReadKey();


Console.WriteLine("LISTA DE PERSONAS: ");

    foreach (Persona persona in blPersonas.GetPersonas())
    {
        Console.WriteLine("     Nombre: " + persona.Nombre);
        Console.WriteLine("     Documento: " + persona.Documento);
        Console.WriteLine("---------------------------------------------");
    }
Console.WriteLine("Presione una tecla para ver lista de Personas..");



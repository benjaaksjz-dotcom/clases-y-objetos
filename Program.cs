// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices.Marshalling;

public class Estudiante
{

    public string Nombre { get; set; }

    public string? apellido { get; set; }

    public void Informacion()
    {
Console.WriteLine($"Bienvenido")

    }
} 

public class Program
{
    public class Program
{
    public static void Main()
    {
        Estudiante estudiante1 = new Estudiante();
        estudiante1.Nombre = "Benjamin ";
        estudiante1.Apellido = "Hidalgo";
        estudiante1.Informacion();
        Estudiante estudiante2 = new Estudiante();
        estudiante2.Nombre = "Jordan";
        estudiante2.Apellido = "Laferte";
        estudiante2.Informacion();

        Auto auto1 = new Auto();
        auto1.Color = "Rojo";
        auto1.Marca = "Ford";
        auto1.Frenar();
    }
}

public class Auto {
    public string Color { get; set; }
    
    public string? Marca { get; set; }
    
    public void Frenar()
    {
        Console.WriteLine($"Su auto acaba de frenar");
        Console.WriteLine($"{Marca} - {Color}");
    }
}
}
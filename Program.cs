using Calificaciones.Calificaciones;

namespace Calificaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //declaramos un objeto de la clase materia 
            Materia POO = new Materia();

            //capturamos el nombre de la materia 
            Console.WriteLine("Captura el nombre de la materia : ");
            POO.Nombre = Console.ReadLine() ?? string.Empty;

            //Capturamos las calificaciones
            Console.WriteLine("Captura la calificacion del parcial 1 : ");
            POO.Parcial1 = float.Parse(Console.ReadLine() ?? string.Empty);

            Console.WriteLine("Captura la calificacion del parcial 2 : ");
            POO.Parcial2 = float.Parse(Console.ReadLine() ?? string.Empty);

            Console.WriteLine("Captura la calificacion del parcial 3 : ");
            POO.Parcial3 = float.Parse(Console.ReadLine() ?? string.Empty);

            //mostramos el resultado
            Console.WriteLine("Segun las calificaciones obtenidas en la materia : "+POO.Nombre +"\n"+
                "Parcial 1 : "+ POO.Parcial1+ "\n" +
                "Parcial 2 : "+ POO.Parcial2+ "\n" +
                "Parcial 3 : "+ POO.Parcial3+ "\n" +
                "Se tiene un promedio de : "+POO.CalcularPromedio());
        }
    }
}

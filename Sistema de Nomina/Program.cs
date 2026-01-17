using Sistema_de_Nomina;
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {

        ArrayList empleadosAsalariados = new ArrayList
        {
            new EmpleadoAsalariado("Juan", "García", 111111111, 850.00m),
            new EmpleadoAsalariado("María", "López", 222222222, 950.00m),
            new EmpleadoAsalariado("Pedro", "Martínez", 333333333, 1200.00m),
            new EmpleadoAsalariado("Ana", "Rodríguez", 444444444, 1050.00m),
            new EmpleadoAsalariado("Luis", "Fernández", 555555555, 900.00m)
        };

        ArrayList empleadosPorHoras = new ArrayList
        {
            new EmpleadoPorHoras("González", 666666666, 15.50m, 40),
            new EmpleadoPorHoras("Sánchez", 777777777, 18.00m, 45),
            new EmpleadoPorHoras("Ramírez", 888888888, 16.75m, 38),
            new EmpleadoPorHoras("Torres", 999999999, 20.00m, 50),
            new EmpleadoPorHoras("Flores", 101010101, 17.25m, 42)
        };

        ArrayList empleadosPorComision = new ArrayList
        {
            new EmpleadoPorComision("Carlos", "Díaz", 121212121, 10000, 0.06),
            new EmpleadoPorComision("Laura", "Morales", 131313131, 15000, 0.08),
            new EmpleadoPorComision("Jorge", "Castro", 141414141, 12500, 0.07),
            new EmpleadoPorComision("Sofia", "Vargas", 151515151, 20000, 0.09),
            new EmpleadoPorComision("Miguel", "Herrera", 161616161, 18000, 0.065)
        };

        ArrayList empleadosAsalariadosPorComision = new ArrayList
        {
            new EmpleadoAsalariadoPorComisión("Roberto", "Jiménez", 171717171, 8000, 0.05, 500.00m),
            new EmpleadoAsalariadoPorComisión("Patricia", "Ruiz", 181818181, 12000, 0.06, 600.00m),
            new EmpleadoAsalariadoPorComisión("Daniel", "Ortiz", 191919191, 10000, 0.055, 550.00m),
            new EmpleadoAsalariadoPorComisión("Carmen", "Mendoza", 202020202, 15000, 0.07, 700.00m),
            new EmpleadoAsalariadoPorComisión("Fernando", "Silva", 212121212, 11000, 0.06, 650.00m)
        };

        Menu menu = new Menu(empleadosAsalariados, empleadosPorHoras, empleadosPorComision, empleadosAsalariadosPorComision);
        menu.MostrarMenu();
        Console.WriteLine("Presione una tecla para continuar...");
        Console.ReadKey();

    }
}
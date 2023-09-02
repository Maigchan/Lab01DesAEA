// See https://aka.ms/new-console-template for more information
using Lab01;
using System.Runtime.InteropServices;
using System;

Console.WriteLine("Hello, World!");

Usuario usuario = new Usuario("GianPaul", 20);
Empleado empleado = new Empleado("Henry", 150, 20);


List<Usuario> usuarios = new List<Usuario> {
    usuario, empleado
};

Grifo grifo = new Grifo(usuarios);


bool salir = false;
while (!salir)
{
    Console.WriteLine("¡Hola, bienvenido!");
    Console.WriteLine("1. Mostrar informacion de usuarios");
    Console.WriteLine("2. Agregar cliente");
    Console.WriteLine("3. Agregar empleado");
    Console.Write("Elige una opción: ");

    string opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            grifo.ShowUsers(grifo.usuarios);
            break;
        case "2":
            Console.WriteLine("Agregar cliente: ");
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Saldo: ");
            if (double.TryParse(Console.ReadLine(), out double saldo))
            {
                Console.Write("Sueldo: ");
                if (double.TryParse(Console.ReadLine(), out double sueldo))
                {
                    Cliente nuevoCliente = new Cliente(nombre, saldo, sueldo);
                    usuarios.Add(nuevoCliente);

                    Console.WriteLine("Cliente agregado con éxito.");
                }
                else
                {
                    Console.WriteLine("El sueldo debe ser un número válido.");
                }
            }
            else
            {
                Console.WriteLine("El saldo debe ser un número válido.");
            }
            break;
        case "3":
            Console.WriteLine("Agregar empleado: ");
            Console.Write("Nombre: ");
            string nombreEmpleado = Console.ReadLine();

            Console.Write("Saldo: ");
            if (double.TryParse(Console.ReadLine(), out double saldoEmpleado))
            {
                Console.Write("Sueldo: ");
                if (double.TryParse(Console.ReadLine(), out double sueldoEmpleado))
                {
                    Empleado nuevoEmpleado = new Empleado(nombreEmpleado, saldoEmpleado, sueldoEmpleado);
                    usuarios.Add(nuevoEmpleado);
                    Console.WriteLine("Empleado agregado con éxito.");
                }
                else
                {
                    Console.WriteLine("El sueldo debe ser un número válido.");
                }
            }
            else
            {
                Console.WriteLine("El saldo debe ser un número válido.");
            }
            break;
        case "4":
            salir = true;
            Console.WriteLine("¡Hasta luego!");
            break;
        default:
            Console.WriteLine("Opción inválida. Por favor, elige una opción válida.");
            break;
    }

    Console.WriteLine();
}
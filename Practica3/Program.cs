using System;
using System.Collections.Generic;

namespace Practica3
{
    class Program
    {
        //Ejercicio 1 "Estudiantes"
        static void Main()
        {
            List<Estudiante> estudiantes = new List<Estudiante>();
            Queue<string> clientes = new Queue<string>();
            Stack<Tarea> tareas = new Stack<Tarea>();

            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Gestionar Estudiantes");
                Console.WriteLine("2. Gestionar Clientes");
                Console.WriteLine("3. Gestionar Tareas");
                Console.WriteLine("4. Salir");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        GestionarEstudiantes(estudiantes);
                        break;
                    case "2":
                        GestionarClientes(clientes);
                        break;
                    case "3":
                        GestionarTareas(tareas);
                        break;
                    case "4":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }

        static void GestionarEstudiantes(List<Estudiante> estudiantes)
        {
            while (true)
            {
                Console.WriteLine("1. Agregar Estudiante");
                Console.WriteLine("2. Eliminar Estudiante");
                Console.WriteLine("3. Mostrar Estudiantes");
                Console.WriteLine("4. Regresar");
                string opcion = Console.ReadLine();

                if (opcion == "4") break;

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese el nombre del estudiante: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Ingrese la calificación del estudiante: ");
                        double calificacion = Convert.ToDouble(Console.ReadLine());
                        estudiantes.Add(new Estudiante(nombre, calificacion));
                        break;
                    case "2":
                        Console.Write("Ingrese el nombre del estudiante a eliminar: ");
                        string nombreEliminar = Console.ReadLine();
                        estudiantes.RemoveAll(e => e.Nombre == nombreEliminar);
                        break;
                    case "3":
                        Console.WriteLine("Lista de Estudiantes:");
                        foreach (var est in estudiantes)
                        {
                            Console.WriteLine($"Nombre: {est.Nombre}, Calificación: {est.Calificacion}");
                        }
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }





        //Ejercicio 2 "Clientes"
        static void GestionarClientes(Queue<string> clientes)
        {
            while (true)
            {
                Console.WriteLine("1. Agregar Cliente");
                Console.WriteLine("2. Atender Cliente");
                Console.WriteLine("3. Mostrar Clientes en Cola");
                Console.WriteLine("4. Regresar");
                string opcion = Console.ReadLine();

                if (opcion == "4") break;

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese el nombre del cliente: ");
                        string cliente = Console.ReadLine();
                        clientes.Enqueue(cliente);
                        break;
                    case "2":
                        if (clientes.Count > 0)
                        {
                            string clienteAtendido = clientes.Dequeue();
                            Console.WriteLine($"Atendiendo a: {clienteAtendido}");
                        }
                        else
                        {
                            Console.WriteLine("No hay clientes en la cola.");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Clientes en Cola:");
                        foreach (var cli in clientes)
                        {
                            Console.WriteLine(cli);
                        }
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }





        //Ejercicio 3 Tareas
        static void GestionarTareas(Stack<Tarea> tareas)
        {
            while (true)
            {
                Console.WriteLine("1. Agregar Tarea");
                Console.WriteLine("2. Completar Tarea");
                Console.WriteLine("3. Mostrar Tareas Pendientes");
                Console.WriteLine("4. Regresar");
                string opcion = Console.ReadLine();

                if (opcion == "4") break;

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese la descripción de la tarea: ");
                        string descripcion = Console.ReadLine();
                        tareas.Push(new Tarea(descripcion));
                        break;
                    case "2":
                        if (tareas.Count > 0)
                        {
                            Tarea tareaCompletada = tareas.Pop();
                            Console.WriteLine($"Tarea completada: {tareaCompletada.Descripcion}");
                        }
                        else
                        {
                            Console.WriteLine("No hay tareas pendientes.");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Tareas Pendientes:");
                        foreach (var tar in tareas)
                        {
                            Console.WriteLine(tar.Descripcion);
                        }
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }


            }

        }
    }

}
      